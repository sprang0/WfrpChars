using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Beggar : CareerBase
    {
        public Beggar(int level) : base(level) { }

        public override string Name => "Beggar";

        public override string Path => Level switch
        {
            1 => "Pauper",
            2 => "Beggar",
            3 => "Master Beggar",
            4 => "Beggar King",
            _ => throw new Exception("No such Level")
        };

        public override int WeaponSkill => Bonus * Silver;
        public override int Toughness => Bonus * Level;
        public override int Initiative => Bonus * Gold;
        public override int Agility => Bonus * Level;
        public override int Willpower => Bonus * Brass;
        public override int Fellowship => Brass * Level;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Charm, Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Intuition, Types.Skills.StealthUrban } },
            { 2, new List<Skills> { Types.Skills.EntertainActing, Types.Skills.EntertainAny, Types.Skills.Gossip, Types.Skills.Haggle, Types.Skills.Perception, Types.Skills.SleightOfHand } },
            { 3, new List<Skills> { Types.Skills.CharmAnimal, Types.Skills.Leadership, Types.Skills.LoreLocal, Types.Skills.StreetSignsVagabond } },
            { 4, new List<Skills> { Types.Skills.Bribery, Types.Skills.Intimidate } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Panhandle, Types.Talents.ResistanceDisease, Types.Talents.StoneSoup, Types.Talents.VeryResilient } },
            { 2, new List<Talents> { Types.Talents.AlleyCat, Types.Talents.BeneathNotice, Types.Talents.Criminal, Types.Talents.EtiquetteCriminals } },
            { 3, new List<Talents> { Types.Talents.Blather, Types.Talents.DirtyFighting, Types.Talents.Hardy, Types.Talents.StepAside } },
            { 4, new List<Talents> { Types.Talents.CatTongued, Types.Talents.FearlessWatchmen, Types.Talents.Kingpin, Types.Talents.Suave } }
        };
    }
}
