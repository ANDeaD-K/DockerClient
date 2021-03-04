using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public class SystemInformationRequest : DockerRequestBase
    {
        public override string Path => "info";

        public override HttpMethod HttpMethod => HttpMethod.Get;
    }
}
