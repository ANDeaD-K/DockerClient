namespace Andead.DockerClient.Domain.Entities.Docker.Responses
{
    public class CreateContainerResponse
    {
        public string Id { get; set; }
        public string[] Warnings { get; set; }
    }
}
