using System;

namespace Classes_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();
            Car1.Make = "Tesla";
            Car1.Model = "ModelX";
            Car1.Year = 2019;

            Console.WriteLine($"{Car1.Make}");
            Console.WriteLine($"{Car1.Model}");
            Console.WriteLine($"{Car1.Year}");
                {

                }
            }
        }
    }
}
