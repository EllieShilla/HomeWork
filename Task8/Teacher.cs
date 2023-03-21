

using System;

namespace Task8
{
    internal class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine($"Teacher {base.Name} teches this subject: {subject}");
        }
    }
}
