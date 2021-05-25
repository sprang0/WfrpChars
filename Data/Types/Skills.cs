using System.ComponentModel;

namespace WfrpChars.Data.Types
{
    enum Skills
    {
        [Description("Animal Care")]
        AnimalCare,
        [Description("Animal Training (Any)")]
        AnimalTrainingAny,
        [Description("Animal Training (Dog)")]
        AnimalTrainingDog,
        [Description("Animal Training (Horse)")]
        AnimalTrainingHorse,
        [Description("Animal Training (Pigeon)")]
        AnimalTrainingPigeon,
        [Description("Art (Any)")]
        ArtAny,
        [Description("Art (Calligraphy)")]
        ArtCalligraphy,
        [Description("Art (Icons)")]
        ArtIcons,
        [Description("Art (Writing)")]
        ArtWriting,
        Athletics,

        Bribery,
        
        Charm,
        [Description("Charm Animal")]
        CharmAnimal,
        Channelling,
        [Description("Channelling (Any Colour)")]
        ChannellingAnyColour,
        [Description("Channelling (Azyr)")]
        ChannellingAzyr,
        Climb,
        [Description("Consume Alcohol")]
        ConsumeAlcohol,
        Cool,
        
        Drive,
        Dodge,
        
        Endurance,
        [Description("Entertain (Acting)")]
        EntertainActing,
        [Description("Entertain (Any)")]
        EntertainAny,
        [Description("Entertain (Fortune Telling)")]
        EntertainFortuneTelling,
        [Description("Entertain (Lecture)")]
        EntertainLecture,
        [Description("Entertain (Prophecy)")]
        EntertainProphecy,
        [Description("Entertain (Rhetoric)")]
        EntertainRhetoric,
        [Description("Entertain (Singing)")]
        EntertainSinging,
        [Description("Entertain (Speeches)")]
        EntertainSpeeches,
        [Description("Entertain (Storytelling)")]
        EntertainStorytelling,
        [Description("Entertain (Taunt)")]
        EntertainTaunt,
        Evaluate,
        
        Gamble,
        Gossip,
        
        Haggle,
        Heal,
        
        Intimidate,
        Intuition,
        
        [Description("Language (Any)")]
        LanguageAny,
        [Description("Language (Battle)")]
        LanguageBattle,
        [Description("Language (Classical)")]
        LanguageClassical,
        [Description("Language (Estalian or Tilean)")]
        LanguageEstalianOrTilean,
        [Description("Language (Guider)")]
        LanguageGuilder,
        [Description("Language (Khazalid)")]
        LanguageKhazalid,
        [Description("Language (Magick)")]
        LanguageMagick,
        [Description("Language (Thief)")]
        LanguageThief,
        Leadership,
        [Description("Lore (Anatomy)")]
        LoreAnatomy,
        [Description("Lore (Any)")]
        LoreAny,
        [Description("Lore (Art)")]
        LoreArt,
        [Description("Lore (Astrology)")]
        LoreAstrology,
        [Description("Lore (Beasts)")]
        LoreBeasts,
        [Description("Lore (Chaos)")]
        LoreChaos,
        [Description("Lore (Chemistry)")]
        LoreChemistry,
        [Description("Lore (Dark Magic)")]
        LoreDarkMagic,
        [Description("Lore (Daemonology)")]
        LoreDaemonology,
        [Description("Lore (Dragons)")]
        LoreDragons,
        [Description("Lore (Empire)")]
        LoreEmpire,
        [Description("Lore (Engineer)")]
        LoreEngineer,
        [Description("Lore (Etiquette)")]
        LoreEtiquette,
        [Description("Lore (Folklore)")]
        LoreFolklore,
        [Description("Lore (Genealogy)")]
        LoreGenealogy,
        [Description("Lore (Geography)")]
        LoreGeography,
        [Description("Lore (Geology)")]
        LoreGeology,
        [Description("Lore (Giants)")]
        LoreGiants,
        [Description("Lore (Heraldry)")]
        LoreHeraldry,
        [Description("Lore (Herbs)")]
        LoreHerbs,
        [Description("Lore (History)")]
        LoreHistory,
        [Description("Lore (Law)")]
        LoreLaw,
        [Description("Lore (Local)")]
        LoreLocal,
        [Description("Lore (Magic)")]
        LoreMagic,
        [Description("Lore (Medicine)")]
        LoreMedicine,
        [Description("Lore (Noble)")]
        LoreNoble,
        [Description("Lore (Plants)")]
        LorePlants,
        [Description("Lore (Politics)")]
        LorePolitics,
        [Description("Lore (Poison)")]
        LorePoison,
        [Description("Lore (Prophecy)")]
        LoreProphecy,
        [Description("Lore (Riverways)")]
        LoreRiverways,
        [Description("Lore (Routes)")]
        LoreRoutes,
        [Description("Lore (Science)")]
        LoreScience,
        [Description("Lore (Sigmar)")]
        LoreSigmar,
        [Description("Lore (Spirits)")]
        LoreSpirits,
        [Description("Lore (Taxes)")]
        LoreTaxes,
        [Description("Lore (Theology)")]
        LoreTheology,
        [Description("Lore (Torture)")]
        LoreTorture,
        [Description("Lore (Trolls)")]
        LoreTrolls,
        [Description("Lore (Warfare)")]
        LoreWarfare,
        [Description("Lore (Witches)")]
        LoreWitches,
        [Description("Lore (Wrecks)")]
        LoreWrecks,
        
        [Description("Melee (Any)")]
        MeleeAny,
        [Description("Melee (Basic)")]
        MeleeBasic,
        [Description("Melee (Brawling)")]
        MeleeBrawling,
        [Description("Melee (Cavalry)")]
        MeleeCavalry,
        [Description("Melee (Fencing)")]
        MeleeFencing,
        [Description("Melee (Flail)")]
        MeleeFlail,
        [Description("Melee (Flail or Two-handed)")]
        MeleeFlailOrTwoHanded,
        [Description("Melee (Parry)")]
        MeleeParry,
        [Description("Melee (Polearm)")]
        MeleePolearm,
        [Description("Melee (Two-handed)")]
        MeleeTwoHanded,
        
        Navigation,
        
        [Description("Outdoor Survival")]
        OutdoorSurvival,
        
        [Description("Perform (Acrobatics)")]
        PerformAcrobatics,
        [Description("Perform (Any)")]
        PerformAny,
        [Description("Perform (Dancing)")]
        PerformDancing,
        [Description("Perform (Fight)")]
        PerformFight,
        Perception,
        [Description("Pick Lock")]
        PickLock,
        [Description("Play (Any)")]
        PlayAny,
        [Description("Play (Drum or Fife)")]
        PlayDrumOrFife,
        Pray,

        [Description("Ranged (Any)")]
        RangedAny,
        [Description("Ranged (Blackpowder)")]
        RangedBlackpowder,
        [Description("Ranged (Bow)")]
        RangedBow,
        [Description("Ranged (Crossbow)")]
        RangedCrossbow,
        [Description("Ranged (Crossbow Pistol)")]
        RangedCrossbowPistol,
        [Description("Ranged (Engineering)")]
        RangedEngineering,
        [Description("Ranged (Entangling)")]
        RangedEntangling,
        [Description("Ranged (Sling)")]
        RangedSling,
        [Description("Ranged (Throwing)")]
        RangedThrowing,
        Research,
        [Description("Ride (Any)")]
        RideAny,
        [Description("Ride (Horse)")]
        RideHorse,
        Row,
        
        Sail,
        [Description("Secret Signs (Any)")]
        SecretSignsAny,
        [Description("Secret Signs (Guilder)")]
        SecretSignsGuilder,
        [Description("Secret Signs (Hunter)")]
        SecretSignsHunter,
        [Description("Secret Signs (Knightly Order)")]
        SecretSignsKnightlyOrder,
        [Description("Secret Signs (Miner)")]
        SecretSignsMiner,
        [Description("Secret Signs (Smuggler)")]
        SecretSignsSmuggler,
        [Description("Secret Signs (Thief)")]
        SecretSignsThief,
        [Description("Set Trap")]
        SetTrap,
        [Description("Sleight of Hand")]
        SleightOfHand,
        [Description("Stealth (Any)")]
        StealthAny,
        [Description("Stealth (Rural)")]
        StealthRural,
        [Description("Stealth (Rural or Urban)")]
        StealthRuralOrUrban,
        [Description("Stealth (Underground)")]
        StealthUnderground,
        [Description("Stealth (Urban)")]
        StealthUrban,
        [Description("Street Signs (Vagabond)")]
        StreetSignsVagabond,
        Swim,
        
        Track,
        [Description("Trade (Any)")]
        TradeAny,
        [Description("Trade (Apothecary)")]
        TradeApothecary,
        [Description("Trade (Art Supplies)")]
        TradeArtSupplies,
        [Description("Trade (Barber)")]
        TradeBarber,
        [Description("Trade (Boatbuilding)")]
        TradeBoatbuilding,
        [Description("Trade (Brewer)")]
        TradeBrewer,
        [Description("Trade (Carpenter)")]
        TradeCarpenter,
        [Description("Trade (Cartographer)")]
        TradeCartographer,
        [Description("Trade (Charms)")]
        TradeCharms,
        [Description("Trade (Engineer)")]
        TradeEngineer,
        [Description("Trade (Engraver)")]
        TradeEngraver,
        [Description("Trade (Explosives)")]
        TradeExplosives,
        [Description("Trade (Farrier)")]
        TradeFarrier,
        [Description("Trade (Gunsmith)")]
        TradeGunsmith,
        [Description("Trade (Herbalist)")]
        TradeHerbalist,
        [Description("Trade (Poisons)")]
        TradePoisons,
        [Description("Trade (Printing)")]
        TradePrinting,
        [Description("Trade (Tinker)")]
        TradeTinker,
        [Description("Trade (Vintner)")]
        TradeVintner,
    }
}
