using Andead.DockerClient.Application.Common.Mappings;
using Andead.DockerClient.Domain.Entities.Docker.Responses;

namespace Andead.DockerClient.Application.Commands.CreateContainer
{
    public class CreateContainerResponseDto : IMapFrom<CreateContainerResponse>
    {
        public string Id { get; set; }
        public string[] Warnings { get; set; }
    }
}
