using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class DeveloperShow
    {
        Programmer programmer;
        Programmer programmer2;
        Builder builder;
        List<IDeveloper> developers;

        public DeveloperShow()
        {
            programmer = new Programmer();
            programmer2 = new Programmer();
            builder = new Builder();
            developers = new List<IDeveloper>();
        }

        public void CreateProgrammerAndBuilder()
        {
            programmer.Tool = "programmer";
            programmer2.Tool = "programmer2";
            builder.Tool = "builder";
        }

        public void AddToIDeveloperList()
        {
            developers.Add(programmer);
            developers.Add(builder);
            developers.Add(programmer2);
        }

        public void ShowCreateAndDestroy()
        {
            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }
        }

        public void ShowDevelopers()
        {
            foreach (IDeveloper developer in developers)
            {
                Console.WriteLine(developer.Tool);
            }
        }

        public void SortDevelopers()
        {
            developers.Sort();
        }
    }
}
