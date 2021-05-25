using System;
using WfrpChars.Data.Species;
using WfrpChars.Data.Careers;

namespace WfrpChars.Data
{
    static class Factory
    {
        public static ISpecies MakeSpecies(Types.Species speciesType) => speciesType switch
        {
            Types.Species.Dwarf => new Dwarf(),
            Types.Species.Halfling => new Halfling(),
            Types.Species.HighElf => new HighElf(),
            Types.Species.Human => new Human(),
            Types.Species.WoodElf => new WoodElf(),
            _ => throw new Exception("No such Species")
        };

        public static CareerBase MakeCareer(Types.Careers careerType, int level) => careerType switch
        {
            Types.Careers.Advisor => new Advisor(level),
            Types.Careers.Agitator => new Agitator(level),
            Types.Careers.Apothecary => new Apothecary(level),
            Types.Careers.Artisan => new Artisan(level),
            Types.Careers.Artist => new Artist(level),
            Types.Careers.Bailiff => new Bailiff(level),
            Types.Careers.Bawd => new Bawd(level),
            Types.Careers.Beggar => new Beggar(level),
            Types.Careers.Boatman => new Boatman(level),
            Types.Careers.BountyHunter => new BountyHunter(level),
            Types.Careers.Cavalryman => new Cavalryman(level),
            Types.Careers.Charlatan => new Charlatan(level),
            Types.Careers.Coachman => new Coachman(level),
            Types.Careers.Duellist => new Duellist(level),
            Types.Careers.Engineer => new Engineer(level),
            Types.Careers.Entertainer => new Entertainer(level),
            Types.Careers.Envoy => new Envoy(level),
            Types.Careers.Fence => new Fence(level),
            Types.Careers.Flagellant => new Flagellant(level),
            Types.Careers.GraveRobber => new GraveRobber(level),
            Types.Careers.Guard => new Guard(level),
            Types.Careers.HedgeWitch => new HedgeWitch(level),
            Types.Careers.Herbalist => new Herbalist(level),
            Types.Careers.Huffer => new Huffer(level),
            Types.Careers.Hunter => new Hunter(level),
            Types.Careers.Investigator => new Investigator(level),
            Types.Careers.Knight => new Knight(level),
            Types.Careers.Lawyer => new Lawyer(level),
            Types.Careers.Merchant => new Merchant(level),
            Types.Careers.Messenger => new Messenger(level),
            Types.Careers.Miner => new Miner(level),
            Types.Careers.Mystic => new Mystic(level),
            Types.Careers.Noble => new Noble(level),
            Types.Careers.Nun => new Nun(level),
            Types.Careers.Outlaw => new Outlaw(level),
            Types.Careers.Pedlar => new Pedlar(level),
            Types.Careers.Physician => new Physician(level),
            Types.Careers.PitFighter => new PitFighter(level),
            Types.Careers.Priest => new Priest(level),
            Types.Careers.Protagonist => new Protagonist(level),
            Types.Careers.RatCatcher => new RatCatcher(level),
            Types.Careers.Racketeer => new Racketeer(level),
            Types.Careers.Riverwarden => new Riverwarden(level),
            Types.Careers.Riverwoman => new Riverwoman(level),
            Types.Careers.RoadWarden => new RoadWarden(level),
            Types.Careers.Scholar => new Scholar(level),
            Types.Careers.Scout => new Scout(level),
            Types.Careers.Seaman => new Seaman(level),
            Types.Careers.Servant => new Servant(level),
            Types.Careers.Slayer => new Slayer(level),
            Types.Careers.Smuggler => new Smuggler(level),
            Types.Careers.Soldier => new Soldier(level),
            Types.Careers.Spy => new Spy(level),
            Types.Careers.Stevedore => new Stevedore(level),
            Types.Careers.Thief => new Thief(level),
            Types.Careers.Townsman => new Townsman(level),
            Types.Careers.Villager => new Villager(level),
            Types.Careers.Warden => new Warden(level),
            Types.Careers.WarriorPriest => new WarriorPriest(level),
            Types.Careers.Watchman => new Watchman(level),
            Types.Careers.Witch => new Witch(level),
            Types.Careers.WitchHunter => new WitchHunter(level),
            Types.Careers.Wizard => new Wizard(level),
            Types.Careers.Wrecker => new Wrecker(level),
            _ => throw new Exception("No such Career")
        };
    }
}
