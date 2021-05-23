using System;
using System.Collections.Generic;

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

        public override Dictionary<int, List<SkillType>> Skills => new()
        {
            { 1, new List<SkillType> { SkillType.Athletics, SkillType.Cool, SkillType.ConsumeAlcohol, SkillType.Dodge, SkillType.Endurance, SkillType.Evaluate, SkillType.StealthUrban, SkillType.TradeAny } },
            { 2, new List<SkillType> { SkillType.Charm, SkillType.Haggle, SkillType.LoreLocal, SkillType.Gossip, SkillType.LanguageGuilder, SkillType.Perception } },
            { 3, new List<SkillType> { SkillType.Intuition, SkillType.Leadership, SkillType.Research, SkillType.SecretSignsGuilder } },
            { 4, new List<SkillType> { SkillType.Bribery, SkillType.Intimidate } }
        };

        public override Dictionary<int, List<TalentType>> Talents => new()
        {
            { 1, new List<TalentType> { TalentType.Artistic, TalentType.CraftsmanAny, TalentType.StrongBack, TalentType.VeryStrong } },
            { 2, new List<TalentType> { TalentType.Dealmaker, TalentType.EtiquetteGuilder, TalentType.NimbleFingered, TalentType.Sturdy } },
            { 3, new List<TalentType> { TalentType.AccuteSenseTasteOrTouch, TalentType.MasterTradesmanAny, TalentType.ReadWrite, TalentType.Tinker } },
            { 4, new List<TalentType> { TalentType.Briber, TalentType.MagnumOpus, TalentType.PublicSpeaker, TalentType.Schemer } }
        };
    }
}
