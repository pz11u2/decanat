using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model.impl
{
    class Discipline:IDiscipline
    {
        private Int32 id;
        private String nameDiscipline;
        private Char formOfEducation;
        private TimeScoupe countHours;
        private IGroup group;
        private Byte weekCount;
        private Byte term;
        private String thread;
        private String chiphrOrThreadCount;
        private IndividualTask individualTask;
        private Int32 individualWork;

        public Discipline(String nameDiscipline,
                          Char formOfEducation,
                          TimeScoupe countHours,
                          IGroup group,
                          Byte weekCount,
                          Byte term,
                          String thread,
                          String chiphrOrThreadCount,
                          IndividualTask individualTask,
                          Int32 individualWork) {
                              this.nameDiscipline = nameDiscipline;
                              this.formOfEducation = formOfEducation;
                              this.countHours = countHours;
                              this.group = group;
                              this.weekCount = weekCount;
                              this.term = term;
                              this.thread = thread;
                              this.chiphrOrThreadCount = chiphrOrThreadCount;
                              this.individualTask = individualTask;
                              this.individualWork = individualWork;
        }

        public String getNameDiscipline()
        {
            return this.nameDiscipline;
        }

        public Char getFormOfEducation()
        {
            return this.formOfEducation;
        }

        public TimeScoupe getCountHours()
        {
            return this.countHours;
        }

        public IGroup getGroup()
        {
            return this.group;
        }

        public Byte getWeeksCount()
        {
            return this.weekCount;
        }

        public Byte getTerm()
        {
            return this.term;
        }

        public String getThread()
        {
            return this.thread;
        }

        public String getChiphrOrThreadCount()
        {
            return this.chiphrOrThreadCount;
        }

        public IndividualTask getIndividualTasks()
        {
            return this.individualTask;
        }

        public Int32 getIndividualWork()
        {
            return this.individualWork;
        }
    }
}
