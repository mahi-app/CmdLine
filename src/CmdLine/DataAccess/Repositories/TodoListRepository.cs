using System;
using CmdLine.Domain;
using NHibernate;

namespace CmdLine.DataAccess.Repositories
{
   public class TodoListRepository : RepositoryBase
   {
      public TodoListRepository(ISessionFactory sessionFactory) : base(sessionFactory)
      {
      }
      public Guid Save(TodoList list)
      {
         return InTx(session => (Guid)session.Save(list));
      }

      public TodoList GetById(Guid id)
      {
         return InTx(session => session.Get<TodoList>(id));
      }
   }
}
