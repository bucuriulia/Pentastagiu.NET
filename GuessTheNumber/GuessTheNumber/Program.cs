using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTries = 0;

            Random random = new Random();
            var number = random.Next(0, 100);
            Console.Write("A random number has been generated. Can you guess it? Your guess: ");
            int input;
            do
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input > number)
                    {
                        Console.Write("Too high! Try again. Your guess: ");
                        numberOfTries++;
                    }
                    else if (input < number)
                    {
                        Console.Write("Too low! Try again. Your guess: ");
                        numberOfTries++;
                    }
                    else
                    {
                        Console.WriteLine($"{input} is right! Congratulations. Number of attempts: {++numberOfTries}");
                    }
                }
                else
                {
                    Console.WriteLine("Your guess must be a number!");
                    numberOfTries++;
                }
            } while (input != number);

            Console.WriteLine("Press any key to end the program..");
            Console.ReadLine();
        }
    }
}
