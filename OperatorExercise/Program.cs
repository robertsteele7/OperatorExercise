using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var quotient = a / b;            
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("Enter radius of the Circle");           
            var radius = double.Parse(Console.ReadLine());
            var AreaOfCircle = Math.PI * radius * radius;
            Console.WriteLine("Area of the Circle with radius {0} is {1}", radius, AreaOfCircle);
            

        }
    }
}
