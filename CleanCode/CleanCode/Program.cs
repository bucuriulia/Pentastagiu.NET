using System;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the day of your birth: ");
            var day = Convert.ToInt16(Console.ReadLine());


            Console.Write("Enter the month of your birth: ");
            var month = Convert.ToInt16(Console.ReadLine());


            Console.Write("Enter the year of your birth: ");
            var year = Convert.ToInt16(Console.ReadLine());

            var birthdate = new DateTime(year, month, day); //.ToString("dd-MM-yyyy");
            Console.WriteLine(birthdate);

            Console.Write("What is your gender? \n" +
                "REMEMBER! You must enter either 'M' or 'F'. \n" +
                " Any other input won't be accepted. \n" +
                "Your gender is: ");
            var input = Console.ReadLine();
            Genders? gender;

            switch (input)
            {
                case "F":
                    gender = Genders.F;
                    break;
                case "M":
                    gender = Genders.M;
                    break;
                default:
                    gender = null;
                    break;
            }

            int age = DateTime.Today.Year - birthdate.Year;

            if(gender == null)
            {
                Console.WriteLine("Told you to enter a valid input");
            }
            else
            {
                if(gender == Genders.F)
                {
                    Console.WriteLine($"Your age is: {age}");
                    Console.WriteLine($"You'll retire at the age of 63. That means {63-age} years from now");
                }
                if (gender == Genders.M)
                {
                    Console.WriteLine($"Your age is: {age}");
                    Console.WriteLine($"You'll retire at the age of 65. That means {65 - age} years from now");
                }
            }

            Console.ReadKey();
        }
    }
}
