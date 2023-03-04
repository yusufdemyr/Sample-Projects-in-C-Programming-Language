using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=9; i++)
            

            {
                Console.Write($"row {i}: ");
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            } 
        }
    }
}
