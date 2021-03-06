using Andead.DockerClient.Application.Commands.CreateContainer;
using Andead.DockerClient.Application.Commands.CreateImage;
using Andead.DockerClient.Application.Commands.ListContainers;
using Andead.DockerClient.Application.Commands.StartContainer;
using Andead.DockerClient.Domain.Entities.Docker.Responses;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Common.Interfaces
{
    public interface IDockerClient
    {
        Task<SystemInformationResponse> GetSystemInformation();

        Task StartContainer(StartContainerCommand command);

        Task<ListContainersResponse[]> GetListContainers(ListContainersCommand command);

        Task<CreateContainerResponse> CreateContainer(CreateContainerCommand command);

        Task CreateImage(CreateImageCommand command);
    }
}
