using System;


namespace WfrpChars.Data
{
    static class Dice
    {
        static Random random = new Random(DateTime.Now.Millisecond);

        public static int D10(int times)
        {
            var result = 0;
            for (var i = 1; i <= times; i++)
                result += random.Next(1, 11);
            return result;
        }

        public static int D10(int times, int plus)
        {
            var result = 0;
            for (var i = 1; i <= times; i++)
                result += random.Next(1, 11);
            return result + plus;
        }

        public static int Percent()
        {
            return random.Next(1, 101);
        }
    }
}