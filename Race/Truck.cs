using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Truck : Car
    {
        public Truck(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }
        public override void Description()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Description();
            Console.ResetColor();
        }

        public override void RandomSpeed()
        {
            Speed = random.Next(30, 100);
        }
        public override void Print()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Print();
            Console.ResetColor();
        }

    }
}
