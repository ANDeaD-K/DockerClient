using Andead.DockerClient.Domain.Entities.Docker.Extensions;
using Newtonsoft.Json;
using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public abstract class DockerRequestBase
    {
        [JsonIgnore]
        public abstract string Path { get; }

        [JsonIgnore]
        public abstract HttpMethod HttpMethod { get; }

        [JsonIgnore]
        public virtual bool EmptyRequestBody { get; } = true;

        public string GetPath() => this.GetUrlWithParameters(Path);
    }
}
