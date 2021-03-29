using Andead.DockerClient.Domain.Entities.Docker.Responses;
using Andead.DockerClient.Domain.Exceptions;
using Andead.DockerClient.Infrastructure.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Andead.DockerClient.Infrastructure.Suppliers.Docker
{
    public class DockerResponse : IDisposable
    {
        private readonly HttpResponseMessage _responseMessage;
        private readonly JsonSerializerSettings _jsonSerializerSettings;
        private readonly Lazy<IReadOnlyDictionary<string, IEnumerable<string>>> _headers;

        public DockerResponse(HttpResponseMessage responseMessage, JsonSerializerSettings jsonSerializerSettings)
        {
            _responseMessage = responseMessage;
            _jsonSerializerSettings = jsonSerializerSettings;

            _headers = new Lazy<IReadOnlyDictionary<string, IEnumerable<string>>>(() =>
            {
                var headers = _responseMessage.Headers.ToDictionary(h => h.Key, h => h.Value);
                if (_responseMessage.Content?.Headers == null)
                {
                    return headers;
                }

                foreach (var item in _responseMessage.Content.Headers)
                {
                    headers[item.Key] = item.Value;
                }

                return headers;
            });
        }

        public HttpStatusCode StatusCode => _responseMessage.StatusCode;
        public IReadOnlyDictionary<string, IEnumerable<string>> Headers => _headers.Value;

        public async Task<string> GetContentString()
        {
            if (_responseMessage?.Content == null)
            {
                return default;
            }

            var responseText = await _responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseText;
        }

        public async Task<string> GetIndentedContentString()
        {
            if (_responseMessage?.Content == null)
            {
                return default;
            }

            var responseText = await _responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseText.ToIndentedJSONString();
        }

        protected async Task<T> DeserializeContent<T>()
        {
            if (_responseMessage?.Content == null)
            {
                return default;
            }

            try
            {
                using var responseStream = await _responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false);
                using var streamReader = new System.IO.StreamReader(responseStream);
                using var jsonTextReader = new JsonTextReader(streamReader)
                {
                    SupportMultipleContent = true
                };

                var serializer = JsonSerializer.Create(_jsonSerializerSettings);
                T result = default;

                while (jsonTextReader.Read())
                {
                    result = serializer.Deserialize<T>(jsonTextReader);
                }

                return result;
            }
            catch (JsonException)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new Exception(message);
            }
        }

        public virtual async Task<T> GetContentOrThrow<T>()
        {
            switch (StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Created:
                case HttpStatusCode.NoContent:
                case HttpStatusCode.NotModified:
                    var reply = await DeserializeContent<T>();
                    if (reply == null && typeof(T) != typeof(EmptyResponse))
                    {
                        throw new Exception("Response was null which was not expected.");
                    }
                    return reply;
                case HttpStatusCode.BadRequest:
                case HttpStatusCode.NotFound:
                case HttpStatusCode.Conflict:
                case HttpStatusCode.InternalServerError:
                    var error = await DeserializeContent<ErrorResponse>();
                    if (error == null)
                    {
                        throw new Exception("Response was null which was not expected.");
                    }
                    throw new ApiException(error.Message, StatusCode, null, null);
                default:
                    {
                        var contentString = await GetContentString();
                        throw new Exception($"The response was not expected ({StatusCode}): {contentString}");
                    }
            }
        }

        public void Dispose()
        {
            _responseMessage?.Dispose();
        }
    }
}
