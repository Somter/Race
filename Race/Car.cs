using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Car
{
    public event EventHandler Finished;
    public double Speed { get; protected set; }
    public string Name { get; private set; }
    public int Number { get; private set; }
    public double Position { get; protected set; } = 0;
    protected double FinishSpeed { get; set; } = 100.0;
    protected Random random = new Random();

    public Car(string name, double initialSpeed, int num)
    {
        Name = name;
        Speed = initialSpeed;
        Number = num;
    }

    public virtual void Description()
    {
        Console.WriteLine($"#{Number} - {Name}: Позиция {Position:F1}, Скорость: {Speed:F1}");
    }

    public void Drive()
    {
        //RandomSpeed();  
        Position += Speed * 0.1; 
        if (Position >= FinishSpeed)
        {
            Position = FinishSpeed; 
            OnFinished();
        }
    }
    public virtual void RandomSpeed() { }
    public virtual void OnFinished()
    {
        Finished?.Invoke(this, EventArgs.Empty);
    }

    public virtual void Print() 
    {
        int carPosition = (int)Position; 
        Console.Write(new string(' ', carPosition));
        Console.WriteLine($"      #{Number}");
        Console.Write(new string(' ', carPosition));
        Console.WriteLine("  ╱▔▔▔▔▔▔▔▔╲");
        Console.Write(new string(' ', carPosition));
        Console.WriteLine("╱▔┗┈┈┈┛┗┈┈┈┛▔▔▔╲");
        Console.Write(new string(' ', carPosition));
        Console.WriteLine("▏┈╱▔╲┈┈┈┈┈┈╱▔╲┈▕");
        Console.Write(new string(' ', carPosition));
        Console.WriteLine("▔▔╲▂╱▔▔▔▔▔▔╲▂╱▔▔");
    }
}