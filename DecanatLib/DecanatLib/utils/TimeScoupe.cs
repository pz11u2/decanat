using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecanatLib.utils
{
    public class TimeScoupe//часы для предмета
    {
        //todo: конструкторы!
        public Double HourLecture { get; set; } //лекционные
        public Double HourLaboratory { get; set; }//лабораторные
        //*************************уточнить*************
        //практические
        public Double HourPractic { get; set; }
        //самостоятельное обучение
        public Double HourSelf{ get; set; }
        //**********************************************
        //часы, выделенные на экзамен
        public Double HourExam { get; set; }
        //часы консультации перед экзаменом
        public Double HourExamConsultation { get; set; }
        //часы на зачет
        public Double HourCredit { get; set; }
        //дипломные часы
        public Double HourDiploma { get; set; }
        //часы, выделенные на государственный экзамен
        public Double HourStateExam { get; set; }
        //часы, выделенные на производственную практику
        public Double HourProductionPractise { get; set; }
        //часы, выделенные на учебную практику
        public Double HourEducationPractise { get; set; }
        //часы, выделенные на текущие консультации
        public Double HourCurrentConsultation { get; set; }
        //часы, выделенные на индивидуальные занятия
        public Double HourIndividualClass { get; set; }
        //часы, выделенные на курсовую работу
        public Double HourCourseProject { get; set; }
        //часы, выделенные на проведение аспирантских экзаменов и рецензирование реф.
        public Double HourCandidateReview { get; set; }
        //часы, выделенные на руководство аспирантами
        public Double HourCandidateLeader { get; set; }
        //часы, выделенные на консультацию докторантов и на руководство над добывателями
        public Double HourDoctorateConsultation { get; set; }
        //часы, выделенные на руководство ФПК
        public Double HourFPKLearedship { get; set; }
        //часы, выделенные на работу приемной комиссии
        public Double HourCommission { get; set; }        
    }
}
