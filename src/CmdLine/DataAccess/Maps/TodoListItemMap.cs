using CmdLine.Domain;
using FluentNHibernate.Mapping;

namespace CmdLine.DataAccess.Maps
{
   public class TodoListItemMap : ClassMap<TodoListItem>
   {
      public TodoListItemMap()
      {
         Id(x => x.Id);
         Map(x => x.Title);
         References(x => x.TodoList);
      }
   }
}
