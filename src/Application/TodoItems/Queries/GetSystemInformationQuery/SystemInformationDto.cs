using Andead.DockerClient.Application.Common.Mappings;
using Andead.DockerClient.Domain.Entities.Docker.Responses;

namespace Andead.DockerClient.Application.TodoItems.Queries.GetSystemInformationQuery
{
    public class SystemInformationDto : IMapFrom<SystemInformationResponse>
    {
        public string Id { get; set; }
        public int Containers { get; set; }
        public int ContainersRunning { get; set; }
        public int ContainersPaused { get; set; }
        public int ContainersStopped { get; set; }
        public string KernelVersion { get; set; }
        public string OperatingSystem { get; set; }
        public string OSVersion { get; set; }
        public string OSType { get; set; }
	    public string Architecture { get; set; }
        public string[] Warnings { get; set; }
    }
}
