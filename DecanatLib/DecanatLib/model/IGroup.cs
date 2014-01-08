using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface IGroup
    {
        Int32 countStudents();        
        //Название группы (ПЗ-11у-1)
        String nameGpoup();
        PositionGroup valuePositionGroup();
        String educationForm();
        Byte course();
        // Специальность (5.080405)
        //String specialization();
        //год поступления
        //Int32 year();

        //ICollection<IDiscipline> getDisciplineToCurrentSemestr(); // select * from dis where dis.semestr==(semestr)
    }
}
