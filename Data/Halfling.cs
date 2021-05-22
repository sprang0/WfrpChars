﻿namespace WfrpChars.Data
{
    class Halfling : ISpecies
    {
        int ISpecies.WeaponSkill => Dice.D10(2, 10);

        int ISpecies.BallisticSkill => Dice.D10(2, 30);

        int ISpecies.Strength => Dice.D10(2, 10);

        int ISpecies.Toughness => Dice.D10(2, 20);

        int ISpecies.Initiative => Dice.D10(2, 20);

        int ISpecies.Agility => Dice.D10(2, 20);

        int ISpecies.Dexterity => Dice.D10(2, 30);

        int ISpecies.Intelligence => Dice.D10(2, 20);

        int ISpecies.Willpower => Dice.D10(2, 30);

        int ISpecies.Fellowship => Dice.D10(2, 30);
    }
}
