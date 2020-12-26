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
         _theList = list;
         _theList.Id = Guid.NewGuid();
         return _theList.Id;
      }

      public TodoList GetById(Guid id)
      {
         return _theList;
      }

      private TodoList _theList;
      private readonly ISessionFactory _sessionFactory;
   }
}
