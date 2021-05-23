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

        public static int Default(int? i)
        {
            return i.GetValueOrDefault(0);
        }

        public static int Bonus(this int i)
        {
            return i / 10;
        }

        public static List<SkillType> Pick2(this List<SkillType> skills)
        {
            var pick1 = skills[Dice.Between(0, skills.Count - 1)];
            var pick2 = skills[Dice.Between(0, skills.Count - 1)];
            while (pick2 == pick1) pick2 = skills[Dice.Between(1, skills.Count - 1)];
            return new List<SkillType> { pick1, pick2 };
        }
    }
}
