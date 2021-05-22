using System.Collections.Generic;
using WfrpChars.Data.Species;

namespace WfrpChars.Data
{
    class Character
    {
        public Character(ISpecies species)
        {
            Species = species;
            Careers = new List<(ICareer career, int level)>();
            Characteristics = new Characteristics();
        }

        public void Generate()
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
        }

        public ISpecies Species { get; set; }

        public List<(ICareer career, int level)> Careers { get; set; }

        public Characteristics Characteristics { get; set; }
    }
}
