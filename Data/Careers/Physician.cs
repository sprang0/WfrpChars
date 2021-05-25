using System;
using System.Collections.Generic;
using WfrpChars.Data.Types;

namespace WfrpChars.Data.Careers
{
    class Physician : CareerBase
    {
        public Physician(int level) : base(level) { }

        public override string Name => "Physician";

        public override string Path => Level switch
        {
            1 => "Physician's Apprentice",
            2 => "Physician",
            3 => "Doktor",
            4 => "Court Physician",
            _ => throw new Exception("No such Level")
        };

        public override int Initiative => Bonus * Silver;
        public override int Agility => Bonus * Gold;
        public override int Dexterity => Bonus * Level;
        public override int Intelligence => Bonus * Level;
        public override int Willpower => Bonus * Level;
        public override int Fellowship => Bonus * Brass;

        public override Dictionary<int, List<Skills>> Skills => new()
        {
            { 1, new List<Skills> { Types.Skills.Bribery, Types.Skills.Cool, Types.Skills.Drive, Types.Skills.Endurance, Types.Skills.Gossip, Types.Skills.Heal, Types.Skills.Perception, Types.Skills.SleightOfHand } },
            { 2, new List<Skills> { Types.Skills.Charm, Types.Skills.Haggle, Types.Skills.LanguageGuilder, Types.Skills.LoreAnatomy, Types.Skills.LoreMedicine, Types.Skills.TradeBarber } },
            { 3, new List<Skills> { Types.Skills.ConsumeAlcohol, Types.Skills.Intimidate, Types.Skills.Leadership, Types.Skills.Research } },
            { 4, new List<Skills> { Types.Skills.LoreNoble, Types.Skills.PerformDancing } }
        };

        public override Dictionary<int, List<Talents>> Talents => new()
        {
            { 1, new List<Talents> { Types.Talents.Bookish, Types.Talents.FieldDressing, Types.Talents.ReadWrite, Types.Talents.StrikeToStun } },
            { 2, new List<Talents> { Types.Talents.Coolheaded, Types.Talents.Criminal, Types.Talents.EtiquetteGuilder, Types.Talents.Surgery } },
            { 3, new List<Talents> { Types.Talents.EtiquetteScholar, Types.Talents.ResistanceDisease, Types.Talents.Savvy, Types.Talents.StrikeToInjure } },
            { 4, new List<Talents> { Types.Talents.EtiquetteNobles, Types.Talents.NimbleFingered, Types.Talents.SavantMedicine, Types.Talents.StrongMinded } }
        };
    }
}
