using Design_Patterns_Jan_2015.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Jan_2015.Adapter
{
    public class NewToOldAdapter : OldShape
    {
        private NewShape _newShape;
        public NewToOldAdapter(NewShape shape)
        {
            _newShape = shape;
        }
        public void drawShape(int x1, int y1, int x2, int y2)
        {
            int width = (int)(Math.Sqrt(Math.Pow(x1 - x2, 2)));
            int height = (int)(Math.Sqrt(Math.Pow(y1 - y2, 2)));
            _newShape.drawShape(x1, y1, width, height);
        }
    }
}
