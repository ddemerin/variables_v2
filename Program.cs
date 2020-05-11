using System;

namespace variables_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfCupsOfCoffee = 4;
            var fullName = "Daniel Dean Demerin";
            var today = DateTime.Now;

            Console.WriteLine($"{fullName} has had {numbersOfCupsOfCoffee} cups of coffee on {today}");

            Console.WriteLine("What is your name?");
            var user = Console.ReadLine();

            Console.WriteLine($"Greetings {user}!");
        }
    }
}
