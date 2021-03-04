using Andead.DockerClient.Application.Common.Interfaces;
using Andead.DockerClient.Application.TodoItems.Commands.ListContainersCommand;
using Andead.DockerClient.Application.TodoItems.Commands.StartContainerCommand;
using Andead.DockerClient.Domain.Entities.Docker.Requests;
using Andead.DockerClient.Domain.Entities.Docker.Responses;
using System.Threading.Tasks;

namespace Andead.DockerClient.Infrastructure.Services
{
    public class DockerClientService : IDockerClient
    {
        private readonly Suppliers.Docker.DockerClient _client;

        public DockerClientService(Suppliers.Docker.DockerClient client)
        {
            _client = client;
        }

        public async Task<SystemInformationResponse> GetSystemInformation()
        {
            var response = await _client.ExecuteAsync(new SystemInformationRequest());
            return await response.GetContentOrThrow<SystemInformationResponse>();
        }

        public async Task StartContainer(StartContainerCommand command)
        {
            var response = await _client.ExecuteAsync(new StartContainerRequest
            {
                Id = command.Id,
                DetachKeys = command.DetachKeys
            });
            await response.GetContentOrThrow<EmptyResponse>();
        }

        public async Task<ListContainersResponse[]> GetListContainers(ListContainersCommand command)
        {
            var response = await _client.ExecuteAsync(new ListContainersRequest
            {
                All = command.All,
                Limit = command.Limit,
                Size = command.Size,
                Filters = command.Filters
            });

            return await response.GetContentOrThrow<ListContainersResponse[]>();
        }
    }
}
