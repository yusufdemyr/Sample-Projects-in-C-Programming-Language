using System;

namespace Calc_Average
{
    class Calc_Average
    {
        static void Main(string[] args)
            
        {
            Bas:


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This program calculate average of numbers.");
            Console.WriteLine("Made by Yusuf Demir");
            Console.WriteLine("Please enter first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number : ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Plase enter fourth number : ");
            int fourthNumber = int.Parse(Console.ReadLine());

            int answer = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("Answer is " + answer);
            Console.WriteLine("Thanks you for using this program.");
            Console.WriteLine("Çıkmak için 'esc' tuşuna basınız tekrar işlem için 'esc' dışında bir şeye basabilirsiniz.");

            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Environment.Exit(0);

            }

            
            Console.ReadLine();
            Console.Clear();

            goto Bas;

        }
    }
}
