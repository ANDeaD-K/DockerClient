using Andead.DockerClient.Application.TodoItems.Commands.ListContainersCommand;
using Andead.DockerClient.Application.TodoItems.Commands.StartContainerCommand;
using Andead.DockerClient.Domain.Entities.Docker.Responses;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Common.Interfaces
{
    public interface IDockerClient
    {
        Task<SystemInformationResponse> GetSystemInformation();

        Task StartContainer(StartContainerCommand command);

        Task<ListContainersResponse[]> GetListContainers(ListContainersCommand command);
    }
}
