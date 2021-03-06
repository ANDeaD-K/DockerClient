using Andead.DockerClient.Application.Commands.CreateContainer;
using Andead.DockerClient.Application.Commands.CreateImage;
using Andead.DockerClient.Application.Commands.ListContainers;
using Andead.DockerClient.Application.Commands.StartContainer;
using Andead.DockerClient.Application.Queries.GetSystemInformation;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Andead.DockerClient.WebUI.Controllers
{
    public class DockerController : ApiControllerBase
    {
        [HttpGet("info")]
        public async Task<ActionResult<SystemInformationDto>> GetInfo()
        {
            return await Mediator.Send(new GetSystemInformationQuery());
        }

        [HttpPost("containers/start")]
        public async Task StartContainer(StartContainerCommand command)
        {
            await Mediator.Send(command);
        }

        [HttpGet("containers/get")]
        public async Task<ActionResult<ListContainersResponseDto[]>> GetListContainers([FromQuery]ListContainersCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPost("containers/create")]
        public async Task<ActionResult<CreateContainerResponseDto>> CreateContainer(CreateContainerCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPost("images/create")]
        public async Task CreateImage(CreateImageCommand command)
        {
            await Mediator.Send(command);
        }
    }
}
