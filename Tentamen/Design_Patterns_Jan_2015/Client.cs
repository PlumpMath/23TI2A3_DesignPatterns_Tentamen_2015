using Design_Patterns_Jan_2015.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Jan_2015
{
    public class Client
    {
        List<OldShape> _drawableShapes;
        public Client()
        {
            _drawableShapes = new List<OldShape>();
        }
        public void AddShape(OldShape shape)
        {
            _drawableShapes.Add(shape);
        }
        public void RemoveShape(OldShape shape)
        {
            _drawableShapes.Remove(shape);
        }
        public void DrawAll()
        {
            foreach (OldShape shape in _drawableShapes)
            {
                Console.WriteLine("\nDrawShape(10, 10, 30, 30)");
                shape.drawShape(10, 10, 30, 30);
            }
        }
    }
}
