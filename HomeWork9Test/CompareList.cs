using HomeWork8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9Test
{
    public class CompareList
    {
        public static bool CompareShapeList(List<Shape> shape1, List<Shape> shape2)
        {
            if (shape1.Count != shape2.Count) return false;

            int y = 0;
            for (int i = 0; i < shape1.Count(); i++)
            {
                if (!shape1[i].Name.Equals(shape2[y].Name))
                    return false;
                if (shape1[i].Area() != shape2[y].Area())
                    return false;
                if (shape1[i].Perimeter() != shape2[y].Perimeter())
                    return false;

                y++;
            }
            return true;
        }
    }
}
