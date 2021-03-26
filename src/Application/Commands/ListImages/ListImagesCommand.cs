using Andead.DockerClient.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Commands.ListContainers
{
    public class ListImagesCommand : IRequest<ListImagesResponseDto[]>
    {
        public bool All { get; set; }
        public string Filters { get; set; }
        public bool Digests { get; set; }
    }

    public class ListImagesCommandHandler : IRequestHandler<ListImagesCommand, ListImagesResponseDto[]>
    {
        private readonly IDockerClient _dockerClient;
        private readonly IMapper _mapper;

        public ListImagesCommandHandler(IDockerClient dockerClient, IMapper mapper)
        {
            _dockerClient = dockerClient;
            _mapper = mapper;
        }

        public async Task<ListImagesResponseDto[]> Handle(ListImagesCommand request, CancellationToken cancellationToken)
        {
            var result = await _dockerClient.GetListImages(request);
            return _mapper.Map<ListImagesResponseDto[]>(result);
        }
    }
}
