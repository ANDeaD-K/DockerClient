using Andead.DockerClient.Application.Commands.CreateContainer;
using Andead.DockerClient.Application.Commands.CreateImage;
using Andead.DockerClient.Application.Commands.ListContainers;
using Andead.DockerClient.Application.Commands.StartContainer;
using Andead.DockerClient.Application.Common.Interfaces;
using Andead.DockerClient.Domain.Entities.Docker.Requests;
using Andead.DockerClient.Domain.Entities.Docker.Responses;
using System.Linq;
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

        public async Task<CreateContainerResponse> CreateContainer(CreateContainerCommand command)
        {
            var response = await _client.ExecuteAsync(new CreateContainerRequest
            {
                Name = command.Name,
                Image = command.Image,
                OpenStdin = command.OpenStdin,
                ExposedPorts = command.ExposedPorts.ToDictionary(x => x, _ => new object())
            });

            return await response.GetContentOrThrow<CreateContainerResponse>();
        }

        public async Task CreateImage(CreateImageCommand command)
        {
            var response = await _client.ExecuteAsync(new CreateImageRequest
            {
                FromImage = command.FromImage
            });

            await response.GetContentOrThrow<EmptyResponse>();
        }
    }
}
