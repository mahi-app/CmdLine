using System;

namespace CmdLine.Domain
{
   public class TodoListItem
   {
      public virtual Guid Id { get; set; }
      public virtual TodoList TodoList { get; set; }
      public virtual string Title { get; set; }
   }
}
