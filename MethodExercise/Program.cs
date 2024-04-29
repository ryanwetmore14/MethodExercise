
using System;
using System.ComponentModel;
using System.Globalization;

namespace MethodExercise
{
    internal class Program
    {
         public static int Sum(int num1, int num2) 
         {
           var answer = num1 + num2;
            return answer;     
         }
            public static int Multiply(int num1, int num2, int num3)
        {

            var answer = num1 * num2 * num3;
            return answer;  
        }

            public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2 / num1;
            return answer;  

        }
            public static int Subtract(int num1, int num2)
        {
            var answer = (num1 - num2);
            return answer;  
        }



        static void Main(string[] args)
        {
           var amountOfCars = Sum(2, 6);
           var okay = Multiply(50, 120, 100);
           var blah = Divide(12, 6);
            var ball = Subtract(12, 6);

            Console.WriteLine("What is your first name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"{color} Is the best color to exist, What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Cool! now which cars do you enjoy the most!");
            string car = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}, here is your profile!");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite car: {car}");
            }     
       }     
}
