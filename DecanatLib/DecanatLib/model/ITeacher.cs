using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface ITeacher
    {
        public String FirstName{ get; set; }
        public String LastName { get; set; }
        public String SecondName { get; set; }
        public Position PositionTeacher{ get; set; }
        public Double Rate{ get; set; }//ставка 
        public List<IDiscipline> Disciplines{ get; set; }//перечень предметов которые может вести
        //public Double CountHours { get; set; }//колличество часов
    }
}
