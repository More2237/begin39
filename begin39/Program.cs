using System;

namespace Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            double sqrtd = Math.Sqrt(d);
            
            double x1 = b*b - 4*a * c;
            double x2 = b*b + 4*a * c;
            double result = Math.Min(x1, x2);
            double result2 = Math.Max(x1, x2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            
            
        }
    }
}