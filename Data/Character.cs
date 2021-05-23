using System.Collections.Generic;
using WfrpChars.Data.Species;
using WfrpChars.Data.Careers;
using System;
using System.Linq;

namespace WfrpChars.Data
{
    class Character
    {
        public Character(ISpecies species)
        {
            Species = species;
            Careers = new List<CareerBase>();
            Skills = new List<SkillType>();
            Characteristics = new Characteristics();
        }

        public void Generate()
        {
            SetCharacteristics();
            SetSkills();
        }

        private void SetSkills()
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

        private void SetCharacteristics()
        {
            Characteristics.WeaponSkill = Species.WeaponSkill;
            Characteristics.BallisticSkill = Species.BallisticSkill;
            Characteristics.Strength = Species.Strength;
            Characteristics.Toughness = Species.Toughness;
            Characteristics.Initiative = Species.Initiative;
            Characteristics.Agility = Species.Agility;
            Characteristics.Dexterity = Species.Dexterity;
            Characteristics.Intelligence = Species.Intelligence;
            Characteristics.Willpower = Species.Willpower;
            Characteristics.Fellowship = Species.Fellowship;
            Characteristics.Wounds = Species.Wounds;
            Characteristics.Movement = Species.Movement;

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

        public ISpecies Species { get; set; }

        public List<CareerBase> Careers { get; set; }

        public List<SkillType> Skills { get; set; }

        public string SkillList => string.Join(", ", Skills.Select(x => x.Description()).OrderBy(x => x));

        public Characteristics Characteristics { get; set; }
    }
}
