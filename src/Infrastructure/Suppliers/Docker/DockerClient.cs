using Andead.DockerClient.Domain.Entities.Docker.Requests;
using Andead.DockerClient.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Infrastructure.Suppliers.Docker
{
    public class DockerClient
    {
        private const string API_VERSION = "1.41";
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings();

        public DockerClient(HttpClient httpClient, IConfiguration configuration)
        {
            httpClient.BaseAddress = new Uri(configuration.GetDockerHost());

            _httpClient = httpClient;
        }

        private readonly Func<HttpResponseMessage, JsonSerializerSettings, DockerResponse> ResponseBuilder = (message, serializerSettings) => 
            new DockerResponse(message, serializerSettings);

        private readonly Func<object, JsonSerializerSettings, HttpContent> ContentBuilder = (request, serializerSettings) =>
        {
            var content = new StringContent(JsonConvert.SerializeObject(request, serializerSettings));
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            return content;
        };

        public Task<DockerResponse> ExecuteAsync<TRequest>(TRequest request)
            where TRequest : DockerRequestBase
        {
            return ExecuteAsync(request, CancellationToken.None);
        }

        public async Task<DockerResponse> ExecuteAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
            where TRequest : DockerRequestBase
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var content = ContentBuilder(request, _serializerSettings);
            var requestText = await content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            using (var message = new HttpRequestMessage())
            {
                message.Content = !request.EmptyRequestBody ? content : null;
                message.Method = request.HttpMethod;
                message.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                message.RequestUri = new Uri($"/v{API_VERSION}/{request.GetPath()}", UriKind.Relative);

                var httpResponse = await _httpClient
                    .SendAsync(message, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);

                var response = ResponseBuilder(httpResponse, _serializerSettings);
                return response;
            }
        }
    }
}
