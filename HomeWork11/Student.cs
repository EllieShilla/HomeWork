using System.Collections.Generic;
using static HomeWork11.Program;

namespace HomeWork11
{
    internal class Student
    {
        public event MyDel MarkChange;
        public string Name { get; set; }
        List<int> marks;

        public Student()
        {
            marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            marks.Add(mark);
            MarkChange(mark);
        }
    }
}
