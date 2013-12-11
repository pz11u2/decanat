using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecanatLib.utils;

namespace DecanatLib.model
{
    interface IGroup
    {
        public Int32 CountStudents { get; set; }
        public String NameGpoup { get; set; }
        public  PositionGroup ValuePositionGroup { get; set; } //
        public String EducationForm{get;set;}
        public byte Course{get;set;}
    }
}
