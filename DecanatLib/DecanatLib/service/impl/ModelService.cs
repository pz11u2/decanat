using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace DecanatLib.service.impl
{
    public class ModelService:IModelService
    {
        public void Add(Object obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(obj.GetType().Name, obj);
                transaction.Commit();
            }
        }
    }
}
