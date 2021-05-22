﻿using WfrpChars.Data.Species;

namespace WfrpChars.Data
{
    static class Factory
    {
        public static ISpecies MakeSpecies(SpeciesType speciesType)
        {
            return speciesType switch
            {
                SpeciesType.Dwarf => new Dwarf(),
                SpeciesType.Halfling => new Halfling(),
                SpeciesType.HighElf => new HighElf(),
                SpeciesType.Human => new Human(),
                SpeciesType.WoodElf => new WoodElf(),
                _ => null,
            };
        }
    }
}
