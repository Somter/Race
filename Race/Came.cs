using System;
using System.Collections.Generic;
using System.Threading;

namespace Race
{
    class Game
    {
        List<Car> cars;
        bool raceInProgress;
        Car winnerCar;
        public List<Car> Cars => cars;
        public delegate void CarAction();
        public event CarAction StartRace;
        public event CarAction StepRace;
        public event EventHandler<string> FinishedDrive; 

        public Game()
        {
            cars = new List<Car>();
            raceInProgress = false;
        }

        public void AddCar(Car car)
        {
            car.Finished += OnCarFinished; 
            cars.Add(car);
        }

        public void Start()
        {
            Console.WriteLine("Гонка начнётся через 3 секунды!\n");

            StartRace?.Invoke(); 

            Thread.Sleep(3000); 

            raceInProgress = true;
            Timer timer = new Timer(RaceStep, null, 0, 500); 

            while (raceInProgress) { }

            timer.Dispose();

        }

        private void RaceStep(object state)
        {
            StepRace?.Invoke();

            Console.Clear();
            Console.WriteLine("Текущие позиции автомобилей:");

            foreach (var car in cars)
            {
                car.Description();
            }

            foreach (var car in cars)
            {
                car.Print();
            }
        }
        public void DrivePrepare()
        {
            Console.WriteLine("Стартовые позиции автомобилей:");
            foreach (var car in cars)
            {
                car.Description();
            }
            Console.WriteLine();
        }

        private void OnCarFinished(object sender, EventArgs e)
        {
            if (sender is Car car && raceInProgress)
            {
                raceInProgress = false;
                winnerCar = car;

                Console.Clear();
                FinishedDrive?.Invoke(this, $"Победитель: #{winnerCar.Number} - {winnerCar.Name}");
            }

        }
    }
}