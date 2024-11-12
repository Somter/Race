using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class SportCar : Car
    {
        public SportCar(string name, double initialSpeed, int num) : base(name, initialSpeed, num) { }

        public override void Description()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.ForegroundColor = ConsoleColor.Red; 
            base.Print();
            Console.ResetColor();
        }
    }
}
