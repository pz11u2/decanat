using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface IDiscipline
    {
		//TODO: убрать автосвойства из абстракций
        //перечень предметов которые может вести препод
        public String NameDiscipline { get; set; }
        public TimeScoupe CountHours { get; set; }
        public IGroup GroupName { get; set; }
        public Byte WeeksCount { get; set; } //количество недель
        public Byte Term { get; set; } //семестр
    }
}
