using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsUnDoneCommand : Notification, ICommand
    {
        public MarkTodoAsUnDoneCommand()
        {
        }

        public MarkTodoAsUnDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }

        public string User { get; set; }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            AddNotifications(
                new Contract<MarkTodoAsUnDoneCommand>()
                    .Requires()
                    .IsMinValue(6, User, "Usuário inválido!")
                    .Notifications
                );
        }
    }
}
