using System;

namespace CmdLine.Domain
{
   public class TodoList
   {
      public virtual Guid Id { get; set; }
      public virtual string Name { get; set; }
   }
}
