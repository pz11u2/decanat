using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.model;
using NHibernate;
using DecanatLib.service;

namespace DecanatLib.model.impl
{
    public class TeacherService: ITeacher
    {
        public Teacher getById(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Teacher>(id);
        }

        // TODO:
        // сигнатура поведений для преподавателя

    }
}
