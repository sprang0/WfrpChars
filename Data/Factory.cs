using System;
using WfrpChars.Data.Careers;
using WfrpChars.Data.Species;

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
                _ => throw new Exception("No such Species")
            };
        }

        public static CareerBase MakeCareer(CareerType careerType, int level)
        {
            return careerType switch
            {
                CareerType.Advisor => new Advisor(level),
                CareerType.Agitator => new Agitator(level),
                CareerType.Apothecary => new Apothecary(level),
                CareerType.Artist => new Artist(level),
                _ => throw new Exception("No such Career")
            };
        }
    }
}
