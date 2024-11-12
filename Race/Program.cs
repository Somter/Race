using Race;
using System;
using System.Runtime.ConstrainedExecution;
namespace Racce 
{ 
    class Program 
    {
        static void Main(string[] args)
        {
           
            Game game = new Game();

            game.FinishedDrive += (sender, winner) =>
            {
              
                Console.WriteLine($"\nГонка завершена! {winner}");
            };

            Car sportCar = new SportCar("Sport car", 0, 1);
            Car bus = new Bus("Bus", 0, 2);
            Car passengerCar = new PassengerCar("Passenger car", 0, 3);
            Car truck = new Truck("Truck", 0, 4);

            game.AddCar(sportCar);
            game.AddCar(bus);
            game.AddCar(passengerCar);
            game.AddCar(truck);

            game.StartRace += () => game.DrivePrepare();
            game.StepRace += () =>
            {
                foreach (var car in game.Cars)
                {
                    car.RandomSpeed();
                    car.Drive();
                }
            };

            game.Start();

        }
      
    }
}
    