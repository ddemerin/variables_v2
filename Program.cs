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
            if (user == "Alice" || user == "alice")
            {
                Console.WriteLine($"Welcome back to Wonderland, my sweet, sweet {user}!");
            }

            Console.WriteLine($"Greetings {user}!");

            Console.WriteLine("Pick a number. Throw a decimal in there if you want!");
            var operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Great! Now pick another number.");
            var operand2 = double.Parse(Console.ReadLine());

            var sum = operand1 + operand2;
            var difference = operand1 - operand2;
            var quotient = operand1 / operand2;
            var product = operand1 * operand2;
            var remainder = operand1 % operand2;

            Console.WriteLine($"{operand1} plus {operand2} equals {sum}");
            Console.WriteLine($"{operand1} minus {operand2} equals {difference}");
            Console.WriteLine($"{operand1} divided {operand2} equals {quotient}");
            Console.WriteLine($"{operand1} times {operand2} equals {product}");
            Console.WriteLine($"{operand1} and {operand2} have a remainder of {remainder}");
        }
    }
}
