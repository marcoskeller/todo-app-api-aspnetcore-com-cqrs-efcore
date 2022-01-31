using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        [TestMethod]
        public void Dado_um_comano_invalido()
        {
            #region Arrange
            var command = new CreateTodoCommand("", DateTime.Now, "");
            #endregion

            #region Act
            command.Validate();
            #endregion

            #region Assert
            Assert.AreEqual(command.Valid, false);
            #endregion
        }

        [TestMethod]
        public void Dado_um_comano_valido()
        {
            #region Arrange
            var command = new CreateTodoCommand("Titulo da tarefa", DateTime.Now, "Marcos");
            #endregion

            #region Act
            command.Validate();
            #endregion

            #region Assert
            Assert.AreEqual(command.Valid, true);
            #endregion
        }
    }
}
