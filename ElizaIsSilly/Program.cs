using System;

namespace ElizaIsSilly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Doctor.Intro());

            var aInput = "";
            do
            {
                aInput = Console.ReadLine();
                string response = Doctor.response(aInput);
                Console.WriteLine(response);
            }

            while (!aInput.Equals("quit", StringComparison.OrdinalIgnoreCase));
        }
    }
}
