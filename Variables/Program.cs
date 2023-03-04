using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This C# console application requires the user to solve a simple math question involving multiplying and subtracting a number, and provides the correct answer. The program allows the user to solve the question by generating random numbers, and provides the correct answer.*/
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(2, 10);
            int secondNumber = randomNumber.Next(2, 10);

            var substraction = randomNumber.Next(2, 10);

            int answer = firstNumber * secondNumber - substraction;
            
            string prompt = ". Dont type in the answer, just press ENTER when ready";

            Console.WriteLine("Think of a number between 1 and 10 " + prompt);
            Console.ReadKey();
            Console.WriteLine("Multiply your number by " + firstNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now Multiply the result by " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you orginally thought off " + prompt);
            Console.ReadKey();
            Console.WriteLine("Now substract " + substraction + prompt);
            Console.ReadKey();
            
            Console.WriteLine("The answer is " + answer);
            Console.ReadKey();
           
        }
    }
}
