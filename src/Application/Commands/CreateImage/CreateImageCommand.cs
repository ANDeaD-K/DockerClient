using Andead.DockerClient.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Commands.CreateImage
{
    public class CreateImageCommand : IRequest
    {
        public string FromImage { get; set; }
    }

    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand>
    {
        private readonly IDockerClient _dockerClient;

        public CreateImageCommandHandler(IDockerClient dockerClient)
        {
            _dockerClient = dockerClient;
        }

        public async Task<Unit> Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            await _dockerClient.CreateImage(request);
            return Unit.Value;
        }
    }
}
