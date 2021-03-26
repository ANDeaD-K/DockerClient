using Andead.DockerClient.Domain.Entities.Docker.Attributes;
using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public class ListImagesRequest : DockerRequestBase
    {
        [Parameter(ParameterType.Query)]
        public bool All { get; set; }

        [Parameter(ParameterType.Query)]
        public string Filters { get; set; }

        [Parameter(ParameterType.Query)]
        public bool Digests { get; set; }

        public override string Path => "images/json?{all}{filters}{digests}";

        public override HttpMethod HttpMethod => HttpMethod.Get;
    }
}
