using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("Tim's car");
            Car anotherCar = new Car("The Batmobile");

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake(4);

            anotherCar.Accelerate(16);
            anotherCar.Brake(17);
        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {

            name = carName;

        }
        public void Accelerate(int amount)
        {
            speed += amount;
            ShowSpeed();
           
        }
        public void Brake(int speedReduction)
        {
            Console.WriteLine($"{name} uses brake");
            speed -= speedReduction;
            
            if (speed < 0)
            {
                speed = 0;
                Console.WriteLine($"{name} stopped.");
            }
            
        }

        private void ShowSpeed()
        {
            Console.WriteLine($" {name} going {speed} miles per hour.");

        }


     }
}
