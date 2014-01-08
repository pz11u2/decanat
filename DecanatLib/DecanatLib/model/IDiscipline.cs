using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface IDiscipline
    {		
        //перечень предметов которые может вести препод
        String getNameDiscipline();
        //форма обучения
        Char getFormOfEducation();
        TimeScoupe getCountHours();
        IGroup getGroup();
        //количество недель
        Byte getWeeksCount();
        //семестр
        Byte getTerm();
        //поток          
        String getThread();
        // шифр специальности или кол-во потоков
        String getChiphrOrThreadCount();
        // виды индивидуальных заданий
        IndividualTask getIndividualTasks();
        // часы на самостоятельную работу
        Int32 getIndividualWork();        
    }
}
