using Andead.DockerClient.Application.Common.Mappings;
using Andead.DockerClient.Domain.Entities.Docker.Responses;

namespace Andead.DockerClient.Application.Commands.ListContainers
{
    public class ListContainersResponseDto : IMapFrom<ListContainersResponse>
    {
        public string Id { get; set; }
        public string[] Names { get; set; }
        public string Image { get; set; }
        public string ImageID { get; set; }
        public string Command { get; set; }
        public string Created { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
    }
}
