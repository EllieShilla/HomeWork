using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Bird : IFlyable
    {
        private string name;
        private bool canFly;

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Bird name: {name}, fly: {canFly}");
        }
    }
}
