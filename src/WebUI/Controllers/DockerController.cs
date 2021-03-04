using Andead.DockerClient.Application.TodoItems.Commands.ListContainersCommand;
using Andead.DockerClient.Application.TodoItems.Commands.StartContainerCommand;
using Andead.DockerClient.Application.TodoItems.Queries.GetSystemInformationCommand;
using Andead.DockerClient.Application.TodoItems.Queries.GetSystemInformationQuery;
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
    }
}
