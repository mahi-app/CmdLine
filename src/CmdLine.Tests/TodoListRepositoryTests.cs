using NUnit.Framework;

namespace CmdLine.Tests
{
   public class TodoListRepositoryTests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      public void SaveRead()
      {
         var repository = new TodoListRepository();
         const string listName = "My Todo List";
         var todoList = new TodoList { Name = listName };
         var listId = repository.Save(todoList);
         var retrieved = repository.GetById(listId);
         Assert.AreEqual(listName, retrieved.Name);
      }
   }
}
