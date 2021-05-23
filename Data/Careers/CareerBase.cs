using System;
using System.Collections.Generic;

namespace WfrpChars.Data.Careers
{
    abstract class CareerBase
    {
        public const int Bonus = 10;

        public CareerBase(int level)
        {
            Level = level;
        }

        public int Level { get; }
        public int Brass => Math.Max(Level - 1, 0);
        public int Silver => Math.Max(Level - 2, 0);
        public int Gold => Math.Max(Level - 3, 0);

        public abstract string Name { get; }
        public abstract string Path { get; }

        public virtual int WeaponSkill { get; }
        public virtual int BallisticSkill { get; }
        public virtual int Strength { get; }
        public virtual int Toughness { get; }
        public virtual int Initiative { get; }
        public virtual int Agility { get; }
        public virtual int Dexterity { get; }
        public virtual int Intelligence { get; }
        public virtual int Willpower { get; }
        public virtual int Fellowship { get; }

        public abstract Dictionary<int, List<SkillType>> Skills { get; }
        public abstract Dictionary<int, List<TalentType>> Talents { get; }
    }
}
