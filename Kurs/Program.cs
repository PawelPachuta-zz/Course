using System;

namespace Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("MaxInt = " + maxInt);
            Console.WriteLine("MinInt = " + minInt);
            Console.WriteLine("MaxLong = " + maxLong);
            Console.WriteLine("MinLong = " + minLong);
        }

        /// <summary>
        /// Settings
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Statement is depended of age
        /// </summary>
        private static void Age()
        {
            Console.WriteLine("How old are you: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are mature. You can have a drink.");
            }
            else if (result == false)
            {
                Console.WriteLine("You put wrong age.");
            }
            else
            {
                Console.WriteLine("You need to wait a few years more.");
            }
        }

        /// <summary>
        /// Method is typing user's greeting
        /// </summary>
        private static void Greeting()
        {
            Console.WriteLine("Type your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
        }
    }
}
