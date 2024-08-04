using System;

namespace Exception_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = GetRandomNumber();
                Console.WriteLine("Generated number: " + number);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
            }
            Console.ReadKey(); // This should be in the Main method to wait for a key press before closing the console.
        }

        public static int GetRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(50, 101);

            if (IsPrime(number))
            {
                throw new InvalidOperationException($"The number {number} is a prime number.");
            }

            return number;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
