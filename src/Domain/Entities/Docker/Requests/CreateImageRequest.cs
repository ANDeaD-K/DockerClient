using Andead.DockerClient.Domain.Entities.Docker.Attributes;
using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public class CreateImageRequest : DockerRequestBase
    {
        [Parameter(ParameterType.Query)]
        public string FromImage { get; set; }

        public override string Path => "images/create?{fromImage}";

        public override HttpMethod HttpMethod => HttpMethod.Post;
    }
}
