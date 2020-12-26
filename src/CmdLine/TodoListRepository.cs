using System;
using NHibernate;

namespace CmdLine
{
   public class TodoListRepository
   {
      public TodoListRepository(ISessionFactory sessionFactory)
      {
         _sessionFactory = sessionFactory;
      }
      public Guid Save(TodoList list)
      {
         using(var session = _sessionFactory.OpenSession())
         {
            var id = (Guid) session.Save(list);
            session.Flush();
            session.Close();
            return id;
         }
      }

      public TodoList GetById(Guid id)
      {
         using(var session = _sessionFactory.OpenSession())
         {
            var list = session.Get<TodoList>(id);
            return list;
         }
      }

      private readonly ISessionFactory _sessionFactory;
   }
}
