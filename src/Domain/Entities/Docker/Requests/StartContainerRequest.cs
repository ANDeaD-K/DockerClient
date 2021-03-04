using Andead.DockerClient.Domain.Entities.Docker.Attributes;
using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public class StartContainerRequest : DockerRequestBase
    {
        [Parameter(ParameterType.Path)]
        public string Id { get; set; }

        [Parameter(ParameterType.Query)]
        public string DetachKeys { get; set; }

        public override string Path { get; } = "containers/{id}/start?{detachKeys}";

        public override HttpMethod HttpMethod => HttpMethod.Post;
    }
}
