using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Spy : CareerBase
    {
        public Spy(int level) : base(level) { }

        public override string Name => "Spy";

        public override string Path => Level switch
        {
            1 => "Informer",
            2 => "Spy",
            3 => "Agent",
            4 => "Spymaster",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Brass;
        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.Charm, Types.Skills.Cool, Types.Skills.Gamble, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Perception, Types.Skills.StealthAny } },
            { 2, new List<Skills> { Types.Skills.Climb, Types.Skills.EntertainActing, Types.Skills.Intuition, Types.Skills.MeleeBasic, Types.Skills.SecretSignsAny, Types.Skills.SleightOfHand } },
            { 3, new List<Skills> { Types.Skills.AnimalCare, Types.Skills.AnimalTrainingPigeon, Types.Skills.LanguageAny, Types.Skills.Leadership } },
            { 4, new List<Skills> { Types.Skills.LoreAny, Types.Skills.Research } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Blather, Types.Talents.Carouser, Types.Talents.Gregarious, Types.Talents.Shadow } },
            { 2, new List<Talents> { Types.Talents.EtiquetteAny, Types.Talents.LipReading, Types.Talents.ReadWrite, Types.Talents.SecretIdentity } },
            { 3, new List<Talents> { Types.Talents.Attractive, Types.Talents.CatTongued, Types.Talents.MasterOfDisguise, Types.Talents.Mimic } },
            { 4, new List<Talents> { Types.Talents.Briber, Types.Talents.Schemer, Types.Talents.Suave, Types.Talents.TowerOfMemories } }
        };
    }
}
