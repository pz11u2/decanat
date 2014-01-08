using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model.impl
{
    class Teacher:ITeacher
    {
        private Int32 id;
        private String firstName;
        private String lastName;
        private String secondName;
        private Position positionTeacher;
        private Double rate;
        //[OneToMany]
        private List<IDiscipline> disciplines;
        private Double hourEducationalWork;

        public Teacher(String firstName,
            String lastName,
            String secondName,
            Position positionTeacher,
            Double rate,
            List<IDiscipline> disciplines,
            Double hourEducationalWork) {
                this.firstName = firstName;
                this.lastName = lastName;
                this.secondName = secondName;
                this.positionTeacher = positionTeacher;
                this.rate = rate;
                this.disciplines = disciplines;
                this.hourEducationalWork = hourEducationalWork;
        }
        
        public String getFirstName()
        {
            return this.firstName;
        }

        public String getLastName()
        {
            return this.lastName;
        }

        public String getSecondName()
        {
            return this.secondName;
        }

        public Position getPositionTeacher()
        {
            return this.positionTeacher;
        }

        public Double getRate()
        {
            return this.rate;
        }

        public List<IDiscipline> getDisciplines()
        {
            return this.disciplines;
        }

        public Double getHourEducationalWork()
        {
            return this.hourEducationalWork;
        }
    }
}
