using System;
using System.Collections.Generic;

namespace CmdLine.Domain
{
   public class TodoList
   {
      public virtual Guid Id { get; set; }
      public virtual string Name { get; set; }
      public virtual IList<TodoListItem> Items { get; set; } = new List<TodoListItem>();
   }
}
