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
         Guid id;
         using (var session = _sessionFactory.OpenSession())
         {
            using (var transaction = session.BeginTransaction())
            {
               try
               {
                  id = (Guid)session.Save(list);
                  transaction.Commit();
               }
               catch (Exception ex)
               {
                  transaction.Rollback();
                  throw;
               }
            }
            session.Close();
         }
         return id;
      }

      public TodoList GetById(Guid id)
      {
         TodoList list;
         using (var session = _sessionFactory.OpenSession())
         {
            using (var transaction = session.BeginTransaction())
            {
               try
               {
                  list = session.Get<TodoList>(id);
                  transaction.Commit();
               }
               catch (Exception ex)
               {
                  transaction.Rollback();
                  throw;
               }
            }
            session.Close();
         }
         return list;
      }

      private readonly ISessionFactory _sessionFactory;
   }
}
