

using System;

namespace Task8
{
    internal class Developer : Staff
    {
        private string level;

        public Developer(string name, int salary, string level) : base(name, salary)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"Developer {base.Name} has level: {level}");
        }
    }
}
