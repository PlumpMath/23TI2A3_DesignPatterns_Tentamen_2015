using Design_Patterns_Jan_2015.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Jan_2015.Shapes
{
    public class Circle : OldShape
    {
        public void drawShape(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Circle: Point 1({0}, {1}), Point 2({2}, {3})", x1, y1, x2, y2);
        }
    }
}
