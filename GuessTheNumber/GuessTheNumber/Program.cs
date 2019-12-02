using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var number = random.Next(0, 100);
            int numberOfTries = 0;
            Console.WriteLine("A random number has been generated. Can you guess it?");
            int input = 0;

            while (input != number)
            {
                Console.Write("Your guess: ");
                int.TryParse(Console.ReadLine(), out input);
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
            Console.ReadLine();
        }
    }
}
