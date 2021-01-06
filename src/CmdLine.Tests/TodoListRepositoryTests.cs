using CmdLine.DataAccess;
using CmdLine.DataAccess.Repositories;
using CmdLine.Domain;
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

      [Test]
      public void SaveRead_WithOneItem()
      {
         var repository = new TodoListRepository(_sessionFactory);
         const string listName = "My Todo List";
         var todoList = new TodoList { Name = listName };
         todoList.Items.Add(new TodoListItem { Title = "Buy Milk", TodoList = todoList });
         var listId = repository.Save(todoList);
         var retrieved = repository.GetById(listId);
         Assert.AreEqual(1, retrieved.Items.Count);
      }

      private ISessionFactory _sessionFactory;
   }
}
