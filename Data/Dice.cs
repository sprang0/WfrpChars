using System;

namespace WfrpChars.Data
{
    static class Dice
    {
        static readonly Random random = new(DateTime.Now.Millisecond);

        public static int D10(int times, int plus)
        {
            var result = 0;
            for (var i = 1; i <= times; i++)
                result += random.Next(1, 11);
            return result + plus;
        }

        public static int Between(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}