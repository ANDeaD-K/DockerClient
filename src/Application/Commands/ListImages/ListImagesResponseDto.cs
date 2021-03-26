using Andead.DockerClient.Application.Common.Mappings;
using Andead.DockerClient.Domain.Entities.Docker.Responses;

namespace Andead.DockerClient.Application.Commands.ListContainers
{
    public class ListImagesResponseDto : IMapFrom<ListImagesResponse>
    {
        public string Id { get; set; }
        public string[] RepoTags { get; set; }
        public string[] RepoDigests { get; set; }
        public int Size { get; set; }
        public int Containers { get; set; }
    }
}
