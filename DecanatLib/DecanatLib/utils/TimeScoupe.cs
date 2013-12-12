using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecanatLib.utils
{
    class TimeScoupe//часы для предмета
    {
        //todo: конструкторы!
        public Double HourLecture { get; set; } //лекционные
        public Double HourLaboratory { get; set; }//лабораторные
        public Double HourPractic { get; set; } //практические
        public Double HourSelf{ get; set; }//самостоятельное обучение
        public Double HourExam { get; set; }//часы, выделенные на экзамен
        public Double HourExamConsultation { get; set; }//часы консультации перед экзаменом
        public Double HourCredit { get; set; }//часы на зачет
        public Double HourDiploma { get; set; }//дипломные часы
        public Double HourStateExam { get; set; }//часы, выделенные на государственный экзамен
        public Double HourProductionPractise { get; set; }//часы, выделенные на производственную практику
        public Double HourEducationPractise { get; set; }//часы, выделенные на учебную практику
        public Double HourCurrentConsultation { get; set; }//часы, выделенные на текущие консультации
        public Double HourIndividualClass { get; set; }//часы, выделенные на индивидуальные занятия
        public Double HourCourseProject { get; set; }//часы, выделенные на курсовую работу
        public Double HourCandidateReview { get; set; }//часы, выделенные на проведение аспирантских экзаменов и рецензирование реф.
        public Double HourCandidateLeader { get; set; }//часы, выделенные на руководство аспирантами
        public Double HourDoctorateConsultation { get; set; }//часы, выделенные на консультацию докторантов и на руководство над добывателями
        public Double HourFPKLearedship { get; set; }//часы, выделенные на руководство ФПК
        public Double HourCommission { get; set; }//часы, выделенные на работу приемной комиссии
        public Double HourEducationalWork { get; set; }//организационно-воспитательная работа
    }
}
