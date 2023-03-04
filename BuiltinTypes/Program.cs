using System;

namespace BuiltinTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int: minimum {int.MinValue}, maximum {int.MaxValue}");

            Console.WriteLine($"long: minimum {long.MinValue}, maximum {long.MaxValue}");

            Console.WriteLine($"float: minimum {float.MinValue}, maximum {float.MaxValue}");

            Console.WriteLine($"double: minimum {double.MinValue}, maximum {double.MaxValue}");

         

            var x = 234;
            Console.WriteLine(x.GetType());

            decimal z = 123.12654874897484654564156464654564456m;
            Console.WriteLine();
            Console.WriteLine($"decimal: minimum {decimal.MinValue}, maximum {decimal.MaxValue}");
            Console.WriteLine($"z is {z:F99}");


        }
    }
}
