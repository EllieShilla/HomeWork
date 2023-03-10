using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Numbers
    {
        private List<int> nums;
        int findNum = -10;
        int numsFotRemove = 20;

        public Numbers()
        {
            nums = new List<int>();
        }

        public void ShowList()
        {
            foreach (var num in nums)
                Console.Write(num + " ");
        }

        public void SetNumberList()
        {
            int count = 1;

            while (count < 11)
            {
                Console.Write($"Enter {count} number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                nums.Add(num);
                count++;
            }
        }

        public void FindAllIndex()
        {
            var indexesOfElement = nums.Select((elem, index) => new IndexOfElement { Element = elem, Index = index }).Where(i => i.Element == findNum).ToList();
            showAllIndex(indexesOfElement);
        }

        private void showAllIndex(List<IndexOfElement> indexesOfElement)
        {
            foreach (var item in indexesOfElement)
                Console.Write(item.Index + " ");
        }

        public void RemoveElementsWhichGraterThanSpecNum()
        {
            nums.RemoveAll(i => i > numsFotRemove);
        }

        public void InsertElem()
        {
            if (nums.Count >= 2)
                nums.Insert(2, 1);
            if (nums.Count >= 9)
                nums.Insert(8, -3);
            if (nums.Count >= 5)
                nums.Insert(5, -4);
        }

        public void SortList()
        {
            nums.Sort();
        }
    }
}
