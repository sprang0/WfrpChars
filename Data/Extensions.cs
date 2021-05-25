using System.Collections.Generic;
using System.ComponentModel;

namespace WfrpChars.Data
{
    static class Extensions
    {
        public static string Description<T>(this T source)
        {
            var fi = source.GetType().GetField(source.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }

        public static int Bonus(this int i)
        {
            return i / 10;
        }

        public static List<T> Pick2<T>(this List<T> list)
        {
            var pick1 = list[Dice.Between(0, list.Count - 1)];
            var pick2 = list[Dice.Between(0, list.Count - 1)];
            while (pick2.Description() == pick1.Description()) pick2 = list[Dice.Between(1, list.Count - 1)];
            return new List<T> { pick1, pick2 };
        }
    }
}
