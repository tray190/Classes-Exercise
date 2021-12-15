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

            Console.WriteLine($"Make: {Car1.Make}");
            Console.WriteLine($"Model: {Car1.Model}");
            Console.WriteLine($"Year: {Car1.Year }");
                {

                }
            
        }
    }
}
