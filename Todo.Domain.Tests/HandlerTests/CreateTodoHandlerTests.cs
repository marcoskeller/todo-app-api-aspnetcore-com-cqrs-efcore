using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {

        [TestMethod]
        public void Dado_um_comano_invalido()
        {
            #region Arrange
            var command = new CreateTodoCommand("", DateTime.Now,"");
            var handler = new TodoHandler(new FakeTodoRepository());

            #endregion

            #region Act
            var result = (GenericCommandResult)handler.Handle(command);
            #endregion

            #region Assert
            Assert.AreEqual(result.Sucess, false);
            #endregion
        }

        [TestMethod]
        public void Dado_um_comano_valido()
        {
            #region Arrange
            var command = new CreateTodoCommand("Titulo da tarefa", DateTime.Now, "Marcos");
            var handler = new TodoHandler(new FakeTodoRepository());
            #endregion

            #region Act
            var result = (GenericCommandResult)handler.Handle(command);
            #endregion

            #region Assert
            Assert.AreEqual(result.Sucess, true);
            #endregion
        }
    }
}
