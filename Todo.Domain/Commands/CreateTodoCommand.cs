using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notification, ICommand
    {
        public CreateTodoCommand()
        {
        }

        public CreateTodoCommand(string title, DateTime date, string user)
        {
            Title = title;
            Date = date;
            User = user;
        }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string User { get; set; }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            AddNotifications(
                new Contract<CreateTodoCommand>()
                    .Requires()
                    .IsMinValue(3, Title, "Por favor descreva melhor essa tarefa!")
                    .IsMinValue(6, User, "Usuário inválido!")
                    .Notifications         
                );           
        }     
    }
}