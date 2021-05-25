using System.Collections.Generic;
using WfrpChars.Data.Species;
using System.Linq;
using WfrpChars.Data.Careers;
using WfrpChars.Data.Types;

namespace WfrpChars.Data
{
    class Character
    {
        public Character(ISpecies species)
        {
            Species = species;
            Careers = new List<CareerBase>();
            Skills = new List<SkillTypes>();
            Talents = new List<TalentTypes>();
            Characteristics = new Characteristics();
        }

        public void Generate()
        {
            SetCharacteristics();
            SetSkills();
            SetTalents();
        }

        void SetCharacteristics()
        {
            Characteristics = new Characteristics
            {
                WeaponSkill = Species.WeaponSkill,
                BallisticSkill = Species.BallisticSkill,
                Strength = Species.Strength,
                Toughness = Species.Toughness,
                Initiative = Species.Initiative,
                Agility = Species.Agility,
                Dexterity = Species.Dexterity,
                Intelligence = Species.Intelligence,
                Willpower = Species.Willpower,
                Fellowship = Species.Fellowship,
                Wounds = Species.Wounds,
                Movement = Species.Movement
            };

            foreach (var career in Careers)
            {
                Characteristics.WeaponSkill += career.WeaponSkill;
                Characteristics.BallisticSkill += career.BallisticSkill;
                Characteristics.Strength += career.Strength;
                Characteristics.Toughness += career.Toughness;
                Characteristics.Initiative += career.Initiative;
                Characteristics.Agility += career.Agility;
                Characteristics.Dexterity += career.Dexterity;
                Characteristics.Intelligence += career.Intelligence;
                Characteristics.Willpower += career.Willpower;
                Characteristics.Fellowship += career.Fellowship;
            }
        }

        void SetSkills()
        {
            Skills.Clear();
            foreach (var career in Careers)
            {
                // Level 1
                foreach (var skill in career.Skills[1])
                {
                    if (Skills.Contains(skill)) continue;
                    Skills.Add(skill);
                }
                // Levels 2-4
                for (var level = 2; level <= career.Level; level++)
                {
                    foreach (var skill in career.Skills[level].Pick2())
                    {
                        if (Skills.Contains(skill)) continue;
                        Skills.Add(skill);
                    }
                }
            }
        }

        void SetTalents()
        {
            Talents.Clear();
            foreach (var career in Careers)
            {
                for (var level = 1; level <= career.Level; level++)
                {
                    foreach (var talent in career.Talents[level].Pick2())
                    {
                        if (Talents.Contains(talent)) continue;
                        Talents.Add(talent);
                    }
                }
            }
        }

        public ISpecies Species { get; set; }

        public List<CareerBase> Careers { get; set; }

        public List<SkillTypes> Skills { get; set; }

        public string SkillList => string.Join(", ", Skills.Select(x => x.Description()).OrderBy(x => x));

        public List<TalentTypes> Talents { get; set; }

        public string TalentList => string.Join(", ", Talents.Select(x => x.Description()).OrderBy(x => x));

        public Characteristics Characteristics { get; set; }
    }
}
