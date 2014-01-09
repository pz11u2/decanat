using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.model;

namespace DecanatLib.service
{
    interface ITeacherService
    {
        ITeacher getById(Int32 id);
    }
}
