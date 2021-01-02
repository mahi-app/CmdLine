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
         return InTx(session =>
         {
            return (Guid)session.Save(list);
         });
      }

      public TodoList GetById(Guid id)
      {
         return InTx(session =>
         {
            return session.Get<TodoList>(id);
         });
      }

      protected T InTx<T>(Func<ISession, T> function)
      {
         using (var session = _sessionFactory.OpenSession())
         {
            using (var txn = session.BeginTransaction())
            {
               T result;
               try
               {
                  result = function.Invoke(session);
                  txn.Commit();
                  return result;
               }
               catch (Exception ex)
               {
                  // TODO: exception handling including retry logic
                  txn.Rollback();
                  throw;
               }
            }
         }
      }

      private readonly ISessionFactory _sessionFactory;
   }
}
