namespace WfrpChars.Data.Species
{
    interface ISpecies
    {
        int WeaponSkill { get; }
        int BallisticSkill { get; }
        int Strength { get; }
        int Toughness { get; }
        int Initiative { get; }
        int Agility { get; }
        int Dexterity { get; }
        int Intelligence { get; }
        int Willpower { get; }
        int Fellowship { get; }
        int Wounds { get; }
        int Movement { get; }

        int CalculateWounds(int strength, int toughness, int willpower);
    }
}
