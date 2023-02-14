using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal interface ICourse
    {
        Group[] Groups { get; }
        void AddGroup(Group group);
        Group GetGroupByNo(string no);

        Group[] Search(string str);

    }
}
