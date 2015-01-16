using Design_Patterns_Jan_2015.Adapter;
using Design_Patterns_Jan_2015.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Jan_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.AddShape(new Circle());
            client.AddShape(new NewToOldAdapter(new Rectangle()));
            client.AddShape(new Polygon());

            client.DrawAll();

            Console.ReadLine();
        }
    }
}
