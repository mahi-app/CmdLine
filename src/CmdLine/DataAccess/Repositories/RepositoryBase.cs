using System;
using NHibernate;

namespace CmdLine.DataAccess.Repositories
{
   public abstract class RepositoryBase
   {
      protected RepositoryBase(ISessionFactory sessionFactory)
      {
         _sessionFactory = sessionFactory;
      }
      protected T InTx<T>(Func<ISession, T> function)
      {
         using var session = _sessionFactory.OpenSession();
         using var txn = session.BeginTransaction();
         try
         {
            T result = function.Invoke(session);
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

      private readonly ISessionFactory _sessionFactory;
   }
}
