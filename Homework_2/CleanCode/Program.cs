using System;

namespace CleanCode
{
    class Program
    {
        private static DateTime GetBirthdateComponents()
        {
            Console.Write("Enter the day of your birth: ");
            int.TryParse(Console.ReadLine(), out int day);

            Console.Write("Enter the month of your birth: ");
            int.TryParse(Console.ReadLine(), out int month);

            Console.Write("Enter the year of your birth: ");
            int.TryParse(Console.ReadLine(), out int year);

            return day != 0 && month != 0 && year != 0 ? new DateTime(year, month, day) : default;
        }

        private static Genders? GetGender()
        {
            Console.Write("What is your gender? \n" +
                            "REMEMBER! You must enter either 'M' or 'F'. \n" +
                            " Any other input won't be accepted. \n" +
                            "Your gender is: ");
            var input = Console.ReadLine();

            Genders? gender;

            if (input.Equals("F") || input.Equals("f"))
                gender = Genders.F;
            else
            {
                if (input.Equals("M") || input.Equals("m"))
                    gender = Genders.M;
                else
                    gender = null;
            }

            return gender;
        }

        static void Main(string[] args)
        {
            var birthdate = GetBirthdateComponents();
            if (birthdate == default)
            {
                Console.WriteLine("Incorrect data. Program has been stopped. Press any key to exit");
                Console.ReadKey();
                return;
            }

            var gender = GetGender();
            var age = DateTime.Today.Year - birthdate.Year;
            const int femaleRetireAge = 63;
            const int maleRetireAge = 65;
            if (gender == null)
            {
                Console.WriteLine("Told you to enter a valid input");
            }
            else
            {
                if (gender == Genders.F && age < femaleRetireAge)
                {
                    Console.WriteLine($"Your age is: {age}");
                    Console.WriteLine($"You'll retire at the age of {femaleRetireAge}. That means {femaleRetireAge - age} years from now");
                    Console.ReadKey();
                    return;
                }

                if (gender == Genders.M && age < maleRetireAge)
                {
                    Console.WriteLine($"Your age is: {age}");
                    Console.WriteLine($"You'll retire at the age of {maleRetireAge}. That means {maleRetireAge - age} years from now");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("You are already retired");


            }

            Console.ReadKey();
        }
    }
}
