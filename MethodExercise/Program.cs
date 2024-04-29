
using System;


namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"{color} Is the best color to exist, What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Cool! now which cars do you enjoy the most!");
            string car = Console.ReadLine();
        }
    }
}
