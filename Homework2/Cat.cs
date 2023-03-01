using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public enum Food
    {
        Meat = 4,
        Milk = 1,
        Mouse = 3
    };

    public enum Fullness
    {
        Starving,
        Hungry,
        Satisfied,
        Full,
        Bloated
    };

    internal class Cat
    {
        private int fullnessLevel = 0;
        public int FullnessLevel
        {
            get { return fullnessLevel; }
        }
        public void EatSomething(Food food)
        {
            fullnessLevel += (int)food;
            Console.WriteLine("The cat ate the {0}", food);
            getSatietyLevel();
        }

        private void getSatietyLevel()
        {
            if (fullnessLevel < 3)
                Console.WriteLine("Cat is {0}", Fullness.Starving);
            else if (fullnessLevel >= 3 && fullnessLevel < 6)
                Console.WriteLine("Cat is {0}", Fullness.Hungry);
            else if (fullnessLevel >= 6 && fullnessLevel < 8)
                Console.WriteLine("Cat is {0}", Fullness.Satisfied);
            else if (fullnessLevel >= 8 && fullnessLevel < 10)
                Console.WriteLine("Cat is {0}", Fullness.Full);
            else
                Console.WriteLine("Cat is {0}", Fullness.Bloated);

        }
    }
}
