using Andead.DockerClient.Domain.Entities.Docker.Extensions;
using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public abstract class DockerRequestBase
    {
        public abstract string Path { get; }
        public abstract HttpMethod HttpMethod { get; }
        public virtual bool EmptyRequestBody { get; } = true;

        public string GetPath() => this.GetUrlWithParameters(Path);
    }
}
