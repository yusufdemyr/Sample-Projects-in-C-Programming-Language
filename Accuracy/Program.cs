using System;

namespace Accuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double result1 = 0.1 * 7;
            double result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 ;

            Console.WriteLine($"1st is {result1:R}");
            Console.WriteLine($"2nd is {result2:R}");
            Console.ReadLine();

            double difference = result1 - result2;
            Console.WriteLine($"The difference is {difference:R}");
            Console.ReadLine();


            bool checkAnswer = result1 - result2 == 0;
            Console.WriteLine($"Is answer equals to 0 " + checkAnswer );
            Console.ReadLine();



        }
    }
}
