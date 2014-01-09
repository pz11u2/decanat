using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model.impl
{
    public class Discipline
    {
         //перечень предметов которые может вести препод
        public virtual String NameDiscipline{get;set;}
        //форма обучения
        public virtual Char FormOfEducation{get;set;}
        public virtual TimeScoupe CountHours{get;set;}
        public virtual Group Group{get;set;}
        //количество недель
        public virtual Byte WeekCount{get;set;}
        //семестр
        public virtual Byte Term{get;set;}
        //поток          
        public virtual String Thread{get;set;}
        // шифр специальности или кол-во потоков
        public virtual String ChiphrOrThreadCount{get;set;}
        // виды индивидуальных заданий
        public virtual IndividualTask IndividualTasks{get;set;}
        // часы на самостоятельную работу
        public virtual Int32 IndividualWork { get; set; }

        public Discipline(String nameDiscipline,
                          Char formOfEducation,
                          TimeScoupe countHours,
                          Group group,
                          Byte weekCount,
                          Byte term,
                          String thread,
                          String chiphrOrThreadCount,
                          IndividualTask individualTasks,
                          Int32 individualWork) {
                              NameDiscipline = nameDiscipline;
                              FormOfEducation = formOfEducation;
                              CountHours = countHours;
                              Group = group;
                              WeekCount = weekCount;
                              Term = term;
                              Thread = thread;
                              ChiphrOrThreadCount = chiphrOrThreadCount;
                              IndividualTasks = individualTasks;
                              IndividualWork = individualWork;
        }

       
    }
}
