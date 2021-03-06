using Andead.DockerClient.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Commands.ListContainers
{
    public class ListContainersCommand : IRequest<ListContainersResponseDto[]>
    {
        public bool All { get; set; }
        public int Limit { get; set; }
        public bool Size { get; set; }
        public string Filters { get; set; }
    }

    public class ListContainersCommandHandler : IRequestHandler<ListContainersCommand, ListContainersResponseDto[]>
    {
        private readonly IDockerClient _dockerClient;
        private readonly IMapper _mapper;

        public ListContainersCommandHandler(IDockerClient dockerClient, IMapper mapper)
        {
            _dockerClient = dockerClient;
            _mapper = mapper;
        }

        public async Task<ListContainersResponseDto[]> Handle(ListContainersCommand request, CancellationToken cancellationToken)
        {
            var result = await _dockerClient.GetListContainers(request);
            return _mapper.Map<ListContainersResponseDto[]>(result);
        }
    }
}
