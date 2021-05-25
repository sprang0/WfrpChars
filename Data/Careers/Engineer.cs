using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Engineer : CareerBase
    {
        public Engineer(int level) : base(level) { }

        public override string Name => "Engineer";

        public override string Path => Level switch
        {
            1 => "Student Engineer",
            2 => "Engineer",
            3 => "Master Engineer",
            4 => "Chartered Engineer",
            _ => throw new Exception("No such Level")
        };

        public override int BallisticSkill => Bonus * Level;
        public override int Toughness => Bonus * Silver;
        public override int Initiative => Bonus * Brass;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Gold;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Cool, Types.Skills.Endurance, Types.Skills.LanguageClassical, Types.Skills.LoreEngineer, Types.Skills.Perception, Types.Skills.RangedBlackpowder, Types.Skills.TradeEngineer } },
            { 2, new List<Skills> { Types.Skills.Drive, Types.Skills.Dodge, Types.Skills.Navigation, Types.Skills.RangedEngineering, Types.Skills.Research, Types.Skills.LanguageGuilder } },
            { 3, new List<Skills> { Types.Skills.LanguageKhazalid, Types.Skills.Leadership, Types.Skills.RideHorse, Types.Skills.SecretSignsGuilder } },
            { 4, new List<Skills> { Types.Skills.LanguageAny, Types.Skills.LoreAny } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Artistic, Types.Talents.Gunner, Types.Talents.ReadWrite, Types.Talents.Tinker } },
            { 2, new List<Talents> { Types.Talents.CraftsmanEngineer, Types.Talents.EtiquetteGuilder, Types.Talents.Marksman, Types.Talents.Orientation } },
            { 3, new List<Talents> { Types.Talents.EtiquetteScholar, Types.Talents.MasterTradesmanEngineering, Types.Talents.Sniper, Types.Talents.SuperNumerate } },
            { 4, new List<Talents> { Types.Talents.MagnumOpus, Types.Talents.RapidReload, Types.Talents.SavantEngineering, Types.Talents.Unshakeable } }
        };
    }
}
