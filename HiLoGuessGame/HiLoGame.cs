using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLoGuessGame
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        static Random random = new Random();

        public static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;
        public static int GetPot()
        {
            return pot;
        }

        public static void Guess(bool isHigher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if (isHigher && nextNumber >= currentNumber || !isHigher && nextNumber <= currentNumber)
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }
        public static void Hint()
        {
            int halfMax = MAXIMUM / 2;
            if (halfMax <= currentNumber)
            {
                Console.WriteLine($"The number is at most{halfMax}");
            }
            else
            {
                Console.WriteLine($"The number is at least {halfMax}");
            }
            pot--;
        }
    }
}