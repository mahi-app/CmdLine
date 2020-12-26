using CmdLine.DataAccess;
using NHibernate;
using NUnit.Framework;

namespace CmdLine.Tests
{
   public class TodoListRepositoryTests
   {
      [SetUp]
      public void Setup()
      {
          _sessionFactory = Database.CreateSessionFactory();
      }

      [Test]
      public void SaveRead()
      {
         var repository = new TodoListRepository(_sessionFactory);
         const string listName = "My Todo List";
         var todoList = new TodoList { Name = listName };
         var listId = repository.Save(todoList);
         var retrieved = repository.GetById(listId);
         Assert.AreEqual(listName, retrieved.Name);
      }

      private ISessionFactory _sessionFactory;
   }
}
