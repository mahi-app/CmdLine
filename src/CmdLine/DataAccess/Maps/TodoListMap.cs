using CmdLine.Domain;
using FluentNHibernate.Mapping;

namespace CmdLine.DataAccess.Maps
{
   public class TodoListMap : ClassMap<TodoList>
   {
      public TodoListMap()
      {
         Table("List");

         Id(x => x.Id);

         Map(x => x.Name);
      }
   }
}
