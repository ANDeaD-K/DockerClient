using Andead.DockerClient.Domain.Common;
using System.Threading.Tasks;

namespace Andead.DockerClient.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
