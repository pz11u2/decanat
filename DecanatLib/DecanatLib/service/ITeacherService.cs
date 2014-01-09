using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.model.impl;

namespace DecanatLib.service
{
    interface ITeacherService
    {
        Teacher getById(Int32 id);
    }
}
