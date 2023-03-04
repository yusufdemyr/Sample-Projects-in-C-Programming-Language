﻿using System;

namespace CarGame
{
    class Program
    {
        private const string Road = "|                             |";
        private const string CarSymbol = "V";

        // Control keys
        private const char Left = 'a';
        private const char Straight = 's';
        private const char Right = 'd';
        private const char Accelerate = 'w';
        private const char Brake = 'x';
        private const char Info = 'i';
        private const char Quit = 'q';

        static void Main(string[] args)
        {
            Console.Clear();

            char control;
            bool playing = true;
            int accelerationFactor = 1;
            int carPosition = 15;

            Car batmobile = new Car("The Batmobile");

            // Instructions
            Console.WriteLine("Welcome to the Console Grand Prix");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine($"Control your car by pressing '{Left}' to go left, and '{Right}' to go right.");
            Console.WriteLine($"'{Straight}' will go straight.");
            Console.WriteLine();
            Console.WriteLine("The faster your car's going, the further down the track it");
            Console.WriteLine("will travel in the chosen direction.  Watch out for the bends!");
            Console.WriteLine();
            Console.WriteLine("Choose the acceleration/deceleration factor by pressing a number key.");
            Console.WriteLine($"You can press a number key anytime before using '{Accelerate}' or '{Brake}'.");
            Console.WriteLine($"Pressing '{Accelerate}' will accelerate by that amount,");
            Console.WriteLine($"'{Brake}' will brake by that amount.");
            Console.WriteLine();
            Console.WriteLine("Your car starts off stationary, so you'll need to accelerate before you can move.");
            Console.WriteLine();
            Console.WriteLine($"Press '{Info}' to find out your current speed.");
            Console.WriteLine();
            Console.WriteLine($"'{Quit}' will quit.");

            do
            {
                control = char.ToLower(Console.ReadKey(true).KeyChar);
                if (char.IsDigit(control))
                {
                    accelerationFactor = control - '0';
                }
                else
                {
                    switch (control)
                    {
                        case Left:
                            // move left
                            for (int i = 0; i < batmobile.Speed; i++)
                            {
                                carPosition--;
                                DrawRoad(carPosition);
                            }
                            break;
                        case Straight:
                            for (int i = 0; i < batmobile.Speed; i++)
                            {
                                DrawRoad(carPosition);
                            }
                            break;
                        case Right:
                            for (int i = 0; i < batmobile.Speed; i++)
                            {
                                carPosition++;
                                DrawRoad(carPosition);
                            }
                            break;
                        case Accelerate:
                            batmobile.Accelerate(accelerationFactor);
                            break;
                        case Brake:
                            batmobile.Brake(accelerationFactor);
                            break;
                        case Info:
                            //batmobile.ShowSpeed();
                            break;
                        case Quit:
                            playing = false;
                            break;
                    }
                }
            } while (playing);
        }

        static void DrawRoad(int carPosition)
        {
            Console.WriteLine(Road.Insert(carPosition, CarSymbol));
        }
    }

    class Car
    {
        public int Speed { get; private set; } = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }

        public void Accelerate(int amount)
        {
            Speed += amount;  // Speed = Speed + amount;
            ShowSpeed();
        }

        public void Brake(int speedReduction)
        {
            Speed = (Speed < speedReduction) ? 0 : Speed - speedReduction;
            ShowSpeed();
        }

        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {Speed * 10} miles per hour.");
        }
    }
}
