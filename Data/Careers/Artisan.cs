using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Artisan : CareerBase
    {
        public Artisan(int level) : base(level) { }

        public override string Name => "Artisan";

        public override string Path => Level switch
        {
            1 => "Apprentice Artisan",
            2 => "Artisan",
            3 => "Master Artisan",
            4 => "Guildmaster",
            _ => throw new Exception("No such Level")
        };

        public override int Strength => Bonus * Level;
        public override int Toughness => Bonus * Level;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Gold;
        public override int Willpower => Bonus * Silver;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Athletics, Types.Skills.Cool, Types.Skills.ConsumeAlcohol, Types.Skills.Dodge, Types.Skills.Endurance, Types.Skills.Evaluate, Types.Skills.StealthUrban, Types.Skills.TradeAny } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Haggle, Types.Skills.LoreLocal, Types.Skills.Gossip, Types.Skills.LanguageGuilder, Types.Skills.Perception } },
            { 3, new List<Skills> { Types.Skills.Intuition, Types.Skills.Leadership, Types.Skills.Research, Types.Skills.SecretSignsGuilder } },
            { 4, new List<Skills> { Types.Skills.Bribery, Types.Skills.Intimidate } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Artistic, Types.Talents.CraftsmanAny, Types.Talents.StrongBack, Types.Talents.VeryStrong } },
            { 2, new List<Talents> { Types.Talents.Dealmaker, Types.Talents.EtiquetteGuilder, Types.Talents.NimbleFingered, Types.Talents.Sturdy } },
            { 3, new List<Talents> { Types.Talents.AcuteSenseTasteOrTouch, Types.Talents.MasterTradesmanAny, Types.Talents.ReadWrite, Types.Talents.Tinker } },
            { 4, new List<Talents> { Types.Talents.Briber, Types.Talents.MagnumOpus, Types.Talents.PublicSpeaker, Types.Talents.Schemer } }
        };
    }
}
