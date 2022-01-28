using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notification, ICommand
    {
        public MarkTodoAsDoneCommand()
        {
        }

        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }

        public string User { get; set; }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            AddNotifications(
                new Contract<MarkTodoAsDoneCommand>()
                    .Requires()
                    .IsMinValue(6, User,"Usuário inválido!")
                    .Notifications
                );
        }
    }
}
