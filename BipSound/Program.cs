using System;

namespace BipSound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\a");
            Console.Beep(2000, 100);
            Console.ReadLine();
            Console.WriteLine("\a");
            Console.Beep(2000, 100);
        }
    }
}
