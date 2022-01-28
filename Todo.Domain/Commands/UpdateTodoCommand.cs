using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notification, ICommand
    {
        public UpdateTodoCommand()
        {
        }

        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string User { get; set; }


        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            AddNotifications(
                new Contract<UpdateTodoCommand>()
                    .Requires()
                    .IsMinValue(3, Title, "Por favor descreva melhor essa tarefa!")
                    .IsMinValue(6, User, "Usuário inválido!")
                    .Notifications
                );
        }
    }
}
