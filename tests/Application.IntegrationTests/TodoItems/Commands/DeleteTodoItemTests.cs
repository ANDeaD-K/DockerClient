﻿using Andead.DockerClient.Application.Common.Exceptions;
using Andead.DockerClient.Application.TodoItems.Commands.CreateTodoItem;
using Andead.DockerClient.Application.TodoItems.Commands.DeleteTodoItem;
using Andead.DockerClient.Application.TodoLists.Commands.CreateTodoList;
using Andead.DockerClient.Domain.Entities;
using FluentAssertions;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Andead.DockerClient.Application.IntegrationTests.TodoItems.Commands
{
    using static Testing;

    public class DeleteTodoItemTests : TestBase
    {
        [Test]
        public void ShouldRequireValidTodoItemId()
        {
            var command = new DeleteTodoItemCommand { Id = 99 };

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<NotFoundException>();
        }

        [Test]
        public async Task ShouldDeleteTodoItem()
        {
            var listId = await SendAsync(new CreateTodoListCommand
            {
                Title = "New List"
            });

            var itemId = await SendAsync(new CreateTodoItemCommand
            {
                ListId = listId,
                Title = "New Item"
            });

            await SendAsync(new DeleteTodoItemCommand
            {
                Id = itemId
            });

            var list = await FindAsync<TodoItem>(listId);

            list.Should().BeNull();
        }
    }
}
