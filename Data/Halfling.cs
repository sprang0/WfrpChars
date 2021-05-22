namespace WfrpChars.Data
{
    class Halfling : ISpecies
    {
        public int WeaponSkill => Dice.D10(2, 10);

        public int BallisticSkill => Dice.D10(2, 30);

        private int strength;
        public int Strength { get { strength = Dice.D10(2, 10); return strength; } }

        private int toughness;
        public int Toughness { get { toughness = Dice.D10(2, 20); return toughness; } }

        public int Initiative => Dice.D10(2, 20);

        public int Agility => Dice.D10(2, 20);

        public int Dexterity => Dice.D10(2, 30);

        public int Intelligence => Dice.D10(2, 20);

        private int willpower;
        public int Willpower { get { willpower = Dice.D10(2, 30); return willpower; } }

        public int Fellowship => Dice.D10(2, 30);

        public int Wounds => 2 * toughness.Bonus() + willpower.Bonus();

        public int Movement => 3;
    }
}
