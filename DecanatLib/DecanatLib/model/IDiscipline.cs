using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface IDiscipline
    {
        //перечень предметов которые может вести препод
        public String NameDiscipline { get; set; }
        public TimeScoupe CountHours { get; set; }
        

    }
}
