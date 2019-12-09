using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new StringRepo();

            Console.Write("0. Exit \n" +
                "1. Compare if 2 strings are equal. \n" +
                "2. Insert a string into another string at a specified position. \n" +
                "3. Split a string based on a parameter. \n" +
                "4. Return a substring. \n" +
                "5. Get the length of an input string. \n" +
                "6. Convert the string to upper case.\n" +
                "7. Convert the string to lower case. \n" +
                "Your option: ");
            var input = Convert.ToInt32(Console.ReadLine());

            while (input != 0)
            {
                switch (input)
                {
                    case 1:
                        repo.Compare();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        repo.Insert();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        repo.Split();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        repo.Substring();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        repo.Length();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        repo.Uppercase();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        repo.Lowercase();

                        Console.Write("Your option: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}
