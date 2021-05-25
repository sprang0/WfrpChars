using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Gossip, SkillTypes.MeleeBrawling, SkillTypes.Row, SkillTypes.Sail, SkillTypes.Swim } },
            { 2, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.EntertainStorytelling, SkillTypes.Haggle, SkillTypes.Intuition, SkillTypes.LoreRiverways, SkillTypes.Perception } },
            { 3, new List<SkillTypes> { SkillTypes.Climb, SkillTypes.EntertainSinging, SkillTypes.Heal, SkillTypes.TradeBoatbuilding } },
            { 4, new List<SkillTypes> { SkillTypes.Leadership, SkillTypes.Navigation } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.DirtyFighting, TalentTypes.Fisherman, TalentTypes.StrongBack, TalentTypes.StrongSwimmer } },
            { 2, new List<TalentTypes> { TalentTypes.EtiquetteGuilder, TalentTypes.SeasonedTraveler, TalentTypes.VeryStrong, TalentTypes.Waterman } },
            { 3, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.Embezzle, TalentTypes.NoseForTrouble, TalentTypes.StrikeMightyBlow } },
            { 4, new List<TalentTypes> { TalentTypes.Menacing, TalentTypes.Orientation, TalentTypes.Pilot, TalentTypes.PublicSpeaker } }
        };
    }
}
