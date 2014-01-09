using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace DecanatLib.service
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Object obj;

        public static Object Obj
        {
            get { return obj; }
            set { obj = value; }
        }

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var config = new Configuration();
                    config.Configure();
                    config.AddAssembly(obj.GetType().Assembly);
                    _sessionFactory = config.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
