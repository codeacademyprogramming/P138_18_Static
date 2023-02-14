using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student
    {
        public static int Count;
        static Student()
        {
            Count = 100;
        }
        public Student()
        {
            Count++;
            No = Count;
        }
        public int No;
        public string FullName;
        public string GroupNo;
    }
}
