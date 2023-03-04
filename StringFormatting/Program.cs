using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string apples = "Apples";
            //int appleQuantitiy = 8;
            //int applePrice = 100;

            //string oranges = "Oranges";
            //int orangeQuantitiy = 12;
            //int orangePrice = 80;

            //string column1Heading = "Fruit";
            //string column2Heading = "Quantity";
            //string column3Heading = "Price";

            //Console.WriteLine($"{column1Heading,-12} {column2Heading,8} {column3Heading,6}");
            //Console.WriteLine($"{apples,-12} {appleQuantitiy,-8} {applePrice / 100.0,6:C}");
            //Console.WriteLine($"{oranges,-12} {orangeQuantitiy,-8} {orangePrice / 100.0,6:C}");

            Console.WriteLine($"PI is {Math.PI}");
            Console.WriteLine($"PI is {Math.PI:F3}");
            Console.WriteLine($"PI is {Math.PI:F0}");
            Console.WriteLine($"PI is {Math.PI:F12}");
            Console.WriteLine($"PI is {Math.PI:F99}");
                
        }
    }
}
