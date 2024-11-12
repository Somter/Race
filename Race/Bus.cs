using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Bus: Car
    {
        public Bus(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

        public override void Description()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Print();
            Console.ResetColor();
        }

    }
}
