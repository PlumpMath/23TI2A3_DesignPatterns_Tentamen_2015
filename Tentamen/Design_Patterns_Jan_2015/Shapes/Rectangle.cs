using Design_Patterns_Jan_2015.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Jan_2015.Shapes
{
    public class Rectangle : NewShape
    {
        public void drawShape(int x, int y, int width, int height)
        {
            Console.WriteLine("Rectangle: Position = ({0},{1}) with width: {2} and height:{3}", x, y, width, height);
        }
    }
}
