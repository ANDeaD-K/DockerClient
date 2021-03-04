using Andead.DockerClient.Domain.Entities.Docker.Attributes;
using System.Net.Http;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    public class ListContainersRequest : DockerRequestBase
    {
        [Parameter(ParameterType.Query)]
        public bool All { get; set; }

        [Parameter(ParameterType.Query)]
        public int Limit { get; set; }

        [Parameter(ParameterType.Query)]
        public bool Size { get; set; }

        [Parameter(ParameterType.Query)]
        public string Filters { get; set; }

        public override string Path => "containers/json?{all}{limit}{size}{filters}";

        public override HttpMethod HttpMethod => HttpMethod.Get;
    }
}
