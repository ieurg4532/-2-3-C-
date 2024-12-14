using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3__C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter:\n100, A\n200, B\n250, C\n");
            Console.Write("Enter variant: ");
            string variant = Console.ReadLine();

            double z;
            switch (variant)
            {
                case "100":
                case "A":
                    if (Math.Sin(x) < 0)
                    {
                        Console.WriteLine("Error: Sine is negative, square root cannot be calculated.");
                    }
                    else
                    {
                        z = Math.Sqrt(Math.Sin(x));
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
                case "200":
                case "B":
                    if (Math.Cos(x) == 0)
                    {
                        Console.WriteLine("Error: cosine is zero, division by zero is impossible.");
                    }
                    else
                    {
                        z = 1 / Math.Cos(x);
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
                case "250":
                case "C":
                    z = Math.Log(Math.Abs(Math.Tan(x)));
                    Console.WriteLine($"Result: {z}");
                    break;
            }
        }
    }
}