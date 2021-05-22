namespace WfrpChars.Data
{
    public class HighElf : ISpecies
    {
        public int WeaponSkill => Dice.D10(2, 30);

        public int BallisticSkill => Dice.D10(2, 30);

        public int Strength => Dice.D10(2, 20);

        public int Toughness => Dice.D10(2, 20);

        public int Initiative => Dice.D10(2, 40);

        public int Agility => Dice.D10(2, 30);

        public int Dexterity => Dice.D10(2, 30);

        public int Intelligence => Dice.D10(2, 30);

        public int Willpower => Dice.D10(2, 30);

        public int Fellowship => Dice.D10(2, 20);
    }
}
