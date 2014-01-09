using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model.impl
{
    public class Teacher
    {
        public virtual Guid Id { get; set; }
        public virtual String FirstName { get; set; }
        public virtual String SecondName { get; set; }
        public virtual String Patronymic { get; set; }
        public virtual Position PositionTeacher { get; set; }
        public virtual Double Rate { get; set; }
        public virtual TimeScoupe Hours { get; set; }
        public virtual List<Discipline> Disciplines { get; set; }
        public virtual Double HourEducationalWork { get; set; }

        public Teacher(String firstName,
            String secondName,
            String patronymic,
            Position positionTeacher,
            Double rate,
            List<Discipline> disciplines,
            Double hourEducationalWork) {
                FirstName = firstName;
                SecondName = secondName;
                Patronymic = patronymic;
                PositionTeacher = positionTeacher;
                Rate = rate;
                Disciplines = disciplines;
                HourEducationalWork = hourEducationalWork;
        }
    } 
}
