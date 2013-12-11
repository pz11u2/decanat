using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecanatLib.utils
{
    class TimeScoupe//часы для предмета
    {
        //todo: конструкторы!
        public Int32 HourLecture { get; set; } //лекционные
        public Int32 HourLaboratory { get; set; }//лабораторные
        public Int32 HourPractic { get; set; } //практические
        public Int32 HourSelf{ get; set; }//самостоятельное обучение
    }
}
