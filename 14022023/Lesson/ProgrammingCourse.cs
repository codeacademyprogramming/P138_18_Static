using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class ProgrammingCourse : ICourse
    {
        private Group[] _groups = new Group[0];
        public Group[] Groups {
            get => _groups;
        }
        

        public void AddGroup(Group group)
        {
            Array.Resize(ref _groups,_groups.Length+1);
            _groups[_groups.Length - 1] = group;
        }

        public Group GetGroupByNo(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.No == no)
                    return group;
            }

            return null;
        }


        public Group[] Search(string str)
        {
            Group[] wantedGroups = new Group[0];

            foreach (var item in _groups)
            {
                if (item.No.Contains(str))
                {
                    Array.Resize(ref wantedGroups, wantedGroups.Length + 1);
                    wantedGroups[wantedGroups.Length - 1] = item;
                }
            }

            return wantedGroups;
        }
    }
}
