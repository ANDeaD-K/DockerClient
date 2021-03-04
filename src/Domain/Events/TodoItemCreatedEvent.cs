using Andead.DockerClient.Domain.Common;
using Andead.DockerClient.Domain.Entities;

namespace Andead.DockerClient.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
