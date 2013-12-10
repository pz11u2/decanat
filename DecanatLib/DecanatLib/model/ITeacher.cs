using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface ITeacher
    {
        private String first_name;
        private String last_name;
        private String second_name;
        private Position position;
        private Double price;//ставка 
        private List<IDiscipline> disciplines;//перечень предметов которые может вести
        private Double countHours;//колличество часов
    }
}
