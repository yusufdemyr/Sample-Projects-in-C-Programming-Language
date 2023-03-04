using System;

namespace BoolExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int apples = 18;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangePrice = 4.50m;


            Console.WriteLine(apples == oranges * 2);
            Console.WriteLine($"{apples} < {oranges} is {apples < oranges}");
            Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} <= {oranges} is {apples <= oranges}");
            Console.WriteLine($"{apples} >= {oranges} is {apples >= oranges}");
            Console.WriteLine($"{apples} != {oranges} is {apples != oranges}");
            Console.WriteLine($"{apples} is int is {apples is int}");

            Console.WriteLine($"Reducing apple cost : {(apples > oranges ) && (applePrice > orangePrice)}");
            Console.WriteLine($"Reducing apple cost : {(apples > oranges ) || (applePrice > orangePrice)}");

            bool moreApples;
            bool applesAreDearer;

            moreApples = (apples >  oranges);
            applesAreDearer = (applePrice   >   orangePrice);
            Console.WriteLine($"We have more apples : {moreApples}");
            Console.WriteLine($"Apples are dearer : {applesAreDearer}");

            Console.WriteLine($"Reducing apple cost : {moreApples && applesAreDearer}");
            Console.WriteLine($"Reducing apple cost : {moreApples || applesAreDearer}");


        }
    }
}
