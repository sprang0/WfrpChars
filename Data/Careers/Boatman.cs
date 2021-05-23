using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data.Careers
{
    class Boatman : CareerBase
    {
        public Boatman(int level) : base(level) { }

        public override string Name => "Boatman";

        public override string Path => Level switch
        {
            1 => "Boat-hand",
            2 => "Boatman",
            3 => "Bargeswain",
            4 => "Barge Master",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Brass;
        public override int Agility => Bonus * Level;
        public override int Dexterity => Bonus * Silver;
        public override int Intelligence => Bonus * Gold;

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.Endurance, SkillType.Gossip, SkillType.MeleeBrawling, SkillType.Row, SkillType.Sail, SkillType.Swim } },
            { 2, new List<SkillType> { SkillType.Athletics, SkillType.EntertainStorytelling, SkillType.Haggle, SkillType.Intuition, SkillType.LoreRiverways, SkillType.Perception } },
            { 3, new List<SkillType> { SkillType.Climb, SkillType.EntertainSinging, SkillType.Heal, SkillType.TradeBoatbuilding } },
            { 4, new List<SkillType> { SkillType.Leadership, SkillType.Navigation } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.DirtyFighting, TalentType.Fisherman, TalentType.StrongBack, TalentType.StrongSwimmer } },
            { 2, new List<TalentType> { TalentType.EtiquetteGuilder, TalentType.SeasonedTraveler, TalentType.VeryStrong, TalentType.Waterman } },
            { 3, new List<TalentType> { TalentType.Dealmaker, TalentType.Embezzle, TalentType.NoseForTrouble, TalentType.StrikeMightyBlow } },
            { 4, new List<TalentType> { TalentType.Menacing, TalentType.Orientation, TalentType.Pilot, TalentType.PublicSpeaker } }
        };
    }
}
