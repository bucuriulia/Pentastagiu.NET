using System;

namespace StringBuilder
{
    public class StringRepo
    {

        public void Compare()
        {
            Console.Write("First string: ");
            var string1 = Console.ReadLine();

            Console.Write("Second string: ");
            var string2 = Console.ReadLine();

            if (string1.CompareTo(string2) == 0)
                Console.WriteLine("The two strings are equal \n");
            else
                Console.WriteLine("The two strings are not equal \n");
        }
        public void Insert()
        {

            Console.Write("The containing string: ");
            var mainString = Console.ReadLine();

            Console.Write("The string to be inserted: ");
            var insertedString = Console.ReadLine();

            Console.WriteLine("The index in which the string will be inserted: ");
            var index = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"The result is: {mainString.Insert(index, insertedString)} \n");
        }

        public void Split()
        {
            Console.Write("The string to be split: ");
            var container = Console.ReadLine();

            Console.Write("The parameter to be split after: ");
            var parameter = Console.ReadLine();

            var result = container.Split(new string[] { parameter }, StringSplitOptions.None);
            if (result.Length >= 2)
                Console.WriteLine($"The string has been split into {result.Length} pieces.");

            Console.WriteLine("The parameter has not been found in the string.");
        }

        public void Substring()
        {
            Console.WriteLine("The string: ");
            var str = Console.ReadLine();

            Console.WriteLine("The starting index: ");
            var startIndex = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(str.Substring(startIndex));
        }


        public void Length()
        {
            Console.WriteLine("The string: ");
            var inputString = Console.ReadLine();

            Console.WriteLine(inputString.Length);
        }

        public void Uppercase()
        {

            Console.WriteLine("The string: ");
            var inpStr = Console.ReadLine();

            Console.WriteLine(inpStr.ToUpper());
        }

        public void Lowercase()
        {
            Console.WriteLine("The string: ");
            var strr = Console.ReadLine();

            Console.WriteLine(strr.ToLower());
        }
    }
}
