using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.model;
using NHibernate;
using DecanatLib.model.impl;

namespace DecanatLib.service.impl
{
    public class TeacherService:ITeacherService
    {

        public ITeacher getById(Int32 id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Teacher>(id);
        }
    }
}
