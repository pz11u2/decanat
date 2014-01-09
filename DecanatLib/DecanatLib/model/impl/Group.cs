using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    public class Group
    {
        public Int32 CountStudents{get;set;}        
        //Название группы (ПЗ-11у-1)
        public virtual String NameGpoup{get;set;}
        public virtual PositionGroup ValuePositionGroup{get;set;}
        public virtual String EducationForm{get;set;}
        public virtual Byte Course{get;set;}
        // Специальность (5.080405)
        //String specialization{get;set;}
        //год поступления
        //Int32 year{get;set;}

        //ICollection<IDiscipline> getDisciplineToCurrentSemestr{get;set;} // select * from dis where dis.semestr==(semestr)

        public Group(Int32 countStudents,
                     String nameGroup, 
                     PositionGroup valuePositionGroup,
                     String educationForm,
                     Byte course )
        { 
            CountStudents = countStudents;
            NameGpoup = nameGroup;
            ValuePositionGroup = valuePositionGroup;
            EducationForm = educationForm;
            Course = course;
        }
    }
}
