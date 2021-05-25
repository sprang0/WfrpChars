using System;
using WfrpChars.Data.Species;
using WfrpChars.Data.Careers;
using WfrpChars.Data.Types;

namespace WfrpChars.Data
{
    static class Factory
    {
        public static ISpecies MakeSpecies(Types.SpeciesTypes speciesType)
        {
            return speciesType switch
            {
                SpeciesTypes.Dwarf => new Dwarf(),
                SpeciesTypes.Halfling => new Halfling(),
                SpeciesTypes.HighElf => new HighElf(),
                SpeciesTypes.Human => new Human(),
                SpeciesTypes.WoodElf => new WoodElf(),
                _ => throw new Exception("No such Species")
            };
        }

        public static CareerBase MakeCareer(CareerTypes careerType, int level)
        {
            return careerType switch
            {
                CareerTypes.Advisor => new Advisor(level),
                CareerTypes.Agitator => new Agitator(level),
                CareerTypes.Apothecary => new Apothecary(level),
                CareerTypes.Artisan => new Artisan(level),
                CareerTypes.Artist => new Artist(level),
                CareerTypes.Bailiff => new Bailiff(level),
                CareerTypes.Bawd => new Bawd(level),
                CareerTypes.Beggar => new Beggar(level),
                CareerTypes.Boatman => new Boatman(level),
                CareerTypes.BountyHunter => new BountyHunter(level),
                CareerTypes.Cavalryman => new Cavalryman(level),
                CareerTypes.Charlatan => new Charlatan(level),
                CareerTypes.Coachman => new Coachman(level),
                CareerTypes.Duellist => new Duellist(level),
                CareerTypes.Engineer => new Engineer(level),
                CareerTypes.Entertainer => new Entertainer(level),
                CareerTypes.Envoy => new Envoy(level),
                CareerTypes.Fence => new Fence(level),
                CareerTypes.Flagellant => new Flagellant(level),
                CareerTypes.GraveRobber => new GraveRobber(level),
                CareerTypes.Guard => new Guard(level),
                CareerTypes.HedgeWitch => new HedgeWitch(level),
                CareerTypes.Herbalist => new Herbalist(level),
                CareerTypes.Huffer => new Huffer(level),
                CareerTypes.Hunter => new Hunter(level),
                CareerTypes.Investigator => new Investigator(level),
                CareerTypes.Knight => new Knight(level),
                CareerTypes.Lawyer => new Lawyer(level),
                CareerTypes.Merchant => new Merchant(level),
                CareerTypes.Messenger => new Messenger(level),
                CareerTypes.Miner => new Miner(level),
                CareerTypes.Mystic => new Mystic(level),
                CareerTypes.Noble => new Noble(level),
                CareerTypes.Nun => new Nun(level),
                CareerTypes.Outlaw => new Outlaw(level),
                CareerTypes.Pedlar => new Pedlar(level),
                CareerTypes.Physician => new Physician(level),
                CareerTypes.PitFighter => new PitFighter(level),
                CareerTypes.Priest => new Priest(level),
                CareerTypes.Protagonist => new Protagonist(level),
                CareerTypes.RatCatcher => new RatCatcher(level),
                CareerTypes.Racketeer => new Racketeer(level),
                CareerTypes.Riverwarden => new Riverwarden(level),
                CareerTypes.Riverwoman => new Riverwoman(level),
                CareerTypes.RoadWarden => new RoadWarden(level),
                CareerTypes.Scholar => new Scholar(level),
                CareerTypes.Scout => new Scout(level),
                CareerTypes.Seaman => new Seaman(level),
                CareerTypes.Servant => new Servant(level),
                CareerTypes.Slayer => new Slayer(level),
                CareerTypes.Smuggler => new Smuggler(level),
                CareerTypes.Soldier => new Soldier(level),
                CareerTypes.Spy => new Spy(level),
                CareerTypes.Stevedore => new Stevedore(level),
                CareerTypes.Thief => new Thief(level),
                CareerTypes.Townsman => new Townsman(level),
                CareerTypes.Villager => new Villager(level),
                CareerTypes.Warden => new Warden(level),
                CareerTypes.WarriorPriest => new WarriorPriest(level),
                CareerTypes.Watchman => new Watchman(level),
                CareerTypes.Witch => new Witch(level),
                CareerTypes.WitchHunter => new WitchHunter(level),
                CareerTypes.Wrecker => new Wrecker(level),
                _ => throw new Exception("No such Career")
            };
        }
    }
}
