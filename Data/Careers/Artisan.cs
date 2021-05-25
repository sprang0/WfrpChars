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

        public override Dictionary<int, List<SkillTypes>> Skills => new()
        {
            { 1, new List<SkillTypes> { SkillTypes.Athletics, SkillTypes.Cool, SkillTypes.ConsumeAlcohol, SkillTypes.Dodge, SkillTypes.Endurance, SkillTypes.Evaluate, SkillTypes.StealthUrban, SkillTypes.TradeAny } },
            { 2, new List<SkillTypes> { SkillTypes.Charm, SkillTypes.Haggle, SkillTypes.LoreLocal, SkillTypes.Gossip, SkillTypes.LanguageGuilder, SkillTypes.Perception } },
            { 3, new List<SkillTypes> { SkillTypes.Intuition, SkillTypes.Leadership, SkillTypes.Research, SkillTypes.SecretSignsGuilder } },
            { 4, new List<SkillTypes> { SkillTypes.Bribery, SkillTypes.Intimidate } }
        };

        public override Dictionary<int, List<TalentTypes>> Talents => new()
        {
            { 1, new List<TalentTypes> { TalentTypes.Artistic, TalentTypes.CraftsmanAny, TalentTypes.StrongBack, TalentTypes.VeryStrong } },
            { 2, new List<TalentTypes> { TalentTypes.Dealmaker, TalentTypes.EtiquetteGuilder, TalentTypes.NimbleFingered, TalentTypes.Sturdy } },
            { 3, new List<TalentTypes> { TalentTypes.AcuteSenseTasteOrTouch, TalentTypes.MasterTradesmanAny, TalentTypes.ReadWrite, TalentTypes.Tinker } },
            { 4, new List<TalentTypes> { TalentTypes.Briber, TalentTypes.MagnumOpus, TalentTypes.PublicSpeaker, TalentTypes.Schemer } }
        };
    }
}
