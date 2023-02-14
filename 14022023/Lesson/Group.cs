using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Group
    {
        public Group()
        {
            Count++;
            AvgPoint++;
        }
        public static int Count;
        private string _no;

        public string No
        {
            get => _no;
            set
            {
                if (CheckNo(value))
                    _no = value;
                else
                    throw new GroupNoFormatException("No deyeri duzgun deyil!");
            }
        }
        public byte AvgPoint;

        public void ShowInfo()
        {
            Console.WriteLine($"No: {No} - AvgPoint: {AvgPoint}");
        }

        public static bool CheckNo(string no)
        {
            if (no == null)
                return false;

            if (no.Length != 4)
                return false;

            if (char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
                return true;

            return false;
        }
    }
}
