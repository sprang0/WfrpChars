using System.ComponentModel;

namespace WfrpChars.Data
{
    enum SkillType
    {
        [Description("Art (Any)")]
        ArtAny,
        [Description("Art (Writing)")]
        ArtWriting,
        Athletics,
        Bribery,
        Charm,
        Climb,
        [Description("Consume Alcohol")]
        ConsumeAlcohol,
        Cool,
        Dodge,
        Endurance,
        [Description("Entertain (Storytelling)")]
        EntertainStorytelling,
        Evaluate,
        Gamble,
        Gossip,
        Haggle,
        Heal,
        Intimidate,
        Intuition,
        [Description("Language (Any)")]
        LanguageAny,
        [Description("Language (Classical)")]
        LanguageClassical,
        [Description("Language (Guider)")]
        LanguageGuilder,
        Leadership,
        [Description("Lore (Any)")]
        LoreAny,
        [Description("Lore (Art)")]
        LoreArt,
        [Description("Lore (Chemistry)")]
        LoreChemistry,
        [Description("Lore (Heraldry)")]
        LoreHeraldry,
        [Description("Lore (Local)")]
        LoreLocal,
        [Description("Lore (Medicine)")]
        LoreMedicine,
        [Description("Lore (Plants)")]
        LorePlants,
        [Description("Lore (Politics)")]
        LorePolitics,
        [Description("Lore (Science)")]
        LoreScience,
        [Description("Melee (Brawling)")]
        MeleeBrawling,
        Perception,
        Research,
        [Description("Ride (Horse)")]
        RideHorse,
        [Description("Secret Signs (Guilder)")]
        SecretSignsGuilder,
        [Description("Stealth (Urban)")]
        StealthUrban,
        [Description("Trade (Apothecary)")]
        TradeApothecary,
        [Description("Trade (Art Supplies)")]
        TradeArtSupplies,
        [Description("Trade (Poisoner)")]
        TradePoisoner,
        [Description("Trade (Printing)")]
        TradePrinting,
    }
}
