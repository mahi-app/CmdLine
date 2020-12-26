using System;

namespace CmdLine
{
   public class TodoListRepository
   {
      public Guid Save(TodoList list)
      {
         _theList = list;
         _theList.Id = Guid.NewGuid();
         return _theList.Id;
      }

      public TodoList GetById(Guid id)
      {
         return _theList;
      }

      private TodoList _theList;
   }
}
