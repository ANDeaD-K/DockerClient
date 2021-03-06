using Andead.DockerClient.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Queries.GetSystemInformation
{
    public class GetSystemInformationQuery : IRequest<SystemInformationDto>
    {
    }

    public class GetSystemInformationQueryHandler : IRequestHandler<GetSystemInformationQuery, SystemInformationDto>
    {
        private readonly IDockerClient _dockerClient;
        private readonly IMapper _mapper;

        public GetSystemInformationQueryHandler(IDockerClient dockerClient, IMapper mapper)
        {
            _dockerClient = dockerClient;
            _mapper = mapper;
    }

        public async Task<SystemInformationDto> Handle(GetSystemInformationQuery _, CancellationToken cancellationToken)
        {
            var result = await _dockerClient.GetSystemInformation();
            return _mapper.Map<SystemInformationDto>(result);
        }
    }
}
