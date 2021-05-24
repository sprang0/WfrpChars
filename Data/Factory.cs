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
                CareerType.Artisan => new Artisan(level),
                CareerType.Artist => new Artist(level),
                CareerType.Bailiff => new Bailiff(level),
                CareerType.Bawd => new Bawd(level),
                CareerType.Beggar => new Beggar(level),
                CareerType.Boatman => new Boatman(level),
                CareerType.BountyHunter => new BountyHunter(level),
                CareerType.Cavalryman => new Cavalryman(level),
                CareerType.Charlatan => new Charlatan(level),
                CareerType.Coachman => new Coachman(level),
                CareerType.Duellist => new Duellist(level),
                CareerType.Engineer => new Engineer(level),
                CareerType.Entertainer => new Entertainer(level),
                CareerType.Envoy => new Envoy(level),
                CareerType.Fence => new Fence(level),
                CareerType.Flagellant => new Flagellant(level),
                CareerType.GraveRobber => new GraveRobber(level),
                CareerType.Guard => new Guard(level),
                CareerType.HedgeWitch => new HedgeWitch(level),
                CareerType.Herbalist => new Herbalist(level),
                CareerType.Huffer => new Huffer(level),
                CareerType.Hunter => new Hunter(level),
                CareerType.Investigator => new Investigator(level),
                CareerType.Knight => new Knight(level),
                CareerType.Lawyer => new Lawyer(level),
                CareerType.Merchant => new Merchant(level),
                CareerType.Messenger => new Messenger(level),
                CareerType.Miner => new Miner(level),
                CareerType.Mystic => new Mystic(level),
                CareerType.Noble => new Noble(level),
                CareerType.Nun => new Nun(level),
                CareerType.Outlaw => new Outlaw(level),
                CareerType.Pedlar => new Pedlar(level),
                CareerType.Physician => new Physician(level),
                CareerType.PitFighter => new PitFighter(level),
                CareerType.Priest => new Priest(level),
                CareerType.Protagonist => new Protagonist(level),
                CareerType.RatCatcher => new RatCatcher(level),
                CareerType.Racketeer => new Racketeer(level),
                CareerType.Riverwarden => new Riverwarden(level),
                CareerType.Riverwoman => new Riverwoman(level),
                CareerType.RoadWarden => new RoadWarden(level),
                CareerType.Scholar => new Scholar(level),
                CareerType.Scout => new Scout(level),
                _ => throw new Exception("No such Career")
            };
        }
    }
}
