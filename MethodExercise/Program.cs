using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your name?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{myName} was outside playing with friends. Then they seen a big {color} {animal} and named it Fluffy.");
        }
    }
}
