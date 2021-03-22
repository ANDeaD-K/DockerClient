using Andead.DockerClient.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Commands.CreateContainer
{
    public class CreateContainerCommand : IRequest<CreateContainerResponseDto>
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public bool OpenStdin { get; set; }
        public string[] ExposedPorts { get; set; }
    }

    public class CreateContainerCommandHandler : IRequestHandler<CreateContainerCommand, CreateContainerResponseDto>
    {
        private readonly IDockerClient _dockerClient;
        private readonly IMapper _mapper;

        public CreateContainerCommandHandler(IDockerClient dockerClient, IMapper mapper)
        {
            _dockerClient = dockerClient;
            _mapper = mapper;
        }

        public async Task<CreateContainerResponseDto> Handle(CreateContainerCommand request, CancellationToken cancellationToken)
        {
            var result = await _dockerClient.CreateContainer(request);
            return _mapper.Map<CreateContainerResponseDto>(result);
        }
    }
}
