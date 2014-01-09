using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;
using DecanatLib.model.impl;

namespace DecanatLib.model
{
    public interface IDiscipline
    {
        Discipline getById(int id);
        // TODO:
        // семантика поведений для дисциплины
    }
}
