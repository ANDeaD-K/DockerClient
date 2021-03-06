using Andead.DockerClient.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Commands.StartContainer
{
    public class StartContainerCommand : IRequest
    {
        public string Id { get; set; }
        public string DetachKeys { get; set; }
    }

    public class StartContainerCommandHandler : IRequestHandler<StartContainerCommand>
    {
        private readonly IDockerClient _dockerClient;

        public StartContainerCommandHandler(IDockerClient dockerClient)
        {
            _dockerClient = dockerClient;
        }

        public async Task<Unit> Handle(StartContainerCommand request, CancellationToken cancellationToken)
        {
            await _dockerClient.StartContainer(request);
            return Unit.Value;
        }
    }
}
