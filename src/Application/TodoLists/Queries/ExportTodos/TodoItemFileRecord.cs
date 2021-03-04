using Andead.DockerClient.Application.Common.Mappings;
using Andead.DockerClient.Domain.Entities;

namespace Andead.DockerClient.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
