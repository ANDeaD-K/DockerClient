using Andead.DockerClient.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Andead.DockerClient.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
