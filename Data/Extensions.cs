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

        public static int Default(int? i)
        {
            return i.GetValueOrDefault(0);
        }

        public static int Bonus(this int i)
        {
            return i / 10;
        }
    }
}
