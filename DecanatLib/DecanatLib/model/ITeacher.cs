using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface ITeacher
    {
        String getFirstName();
        String getLastName ();
        String getSecondName ();
        Position getPositionTeacher();
        // ставка 
        Double getRate();
        //перечень предметов которые может вести
        //OneToMany(featch = Lazy)
        List<IDiscipline> getDisciplines();
        //часы
        TimeScoupe getHours();
        //public Double CountHours {();}//колличество часов
        //организационно-воспитательная работа
        Double getHourEducationalWork();
    }
}
