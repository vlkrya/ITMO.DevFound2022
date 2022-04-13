using System;

namespace ITMO.DevFound2022.FirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, remainder;
            Console.WriteLine("enter an integer value");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;
            if (remainder == 0)
                Console.WriteLine("{0} is Even", number);
            else
                Console.WriteLine("{0} is Odd", number);
            Console.WriteLine("Press any key to exit ");
            Console.ReadKey();
        }
    }
}