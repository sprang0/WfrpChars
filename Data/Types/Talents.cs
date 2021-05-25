using System.ComponentModel;

namespace WfrpChars.Data.Types
{
    enum TalentTypes
    {
        [Description("Accurate Shot")]
        AccurateShot,
        [Description("Acute Sense (Any)")]
        AcuteSenseAny,
        [Description("Acute Sense (Sight)")]
        AcuteSenseSight,
        [Description("Acute Sense (Taste)")]
        AcuteSenseTaste,
        [Description("Acute Sense (Taste or Touch)")]
        AcuteSenseTasteOrTouch,
        [Description("Aethyric Attunement")]
        AethyricAttunement,
        [Description("Alley Cat")]
        AlleyCat,
        Ambidextrous,
        [Description("Animal Affinity")]
        AnimalAffinity,
        [Description("Arcane Magic (Any Arcane Lore)")]
        ArcaneMagicAnyArcaneLore,
        [Description("Arcane Magic (Celestial)")]
        ArcaneMagicCelestial,
        [Description("Arcane Magic (Witchery)")]
        ArcaneMagicWitchery,
        Argumentative,
        Artistic,
        Attractive,
        
        [Description("Battle Rage")]
        BattleRage,
        [Description("Beat Blade")]
        BeatBlade,
        [Description("Beneath Notice")]
        BeneathNotice,
        [Description("Berserk Charge")]
        BerserkCharge,
        Blather,
        [Description("Bless (Any)")]
        BlessAny,
        Bookish,
        [Description("Break and Enter")]
        BreakAndEnter,
        Briber,

        Cardsharp,
        [Description("Careful Strike")]
        CarefulStrike,
        Carouser,
        Catfall,
        [Description("Cat-tonuged")]
        CatTongued,
        [Description("Combat Aware")]
        CombatAware,
        [Description("Combat Reflexes")]
        CombatReflexes,
        [Description("Combat Master")]
        CombatMaster,
        [Description("Commanding Presence")]
        CommandingPresence,
        Concoct,
        Contortionist,
        Coolheaded,
        [Description("Crack the Whip")]
        CrackTheWhip,
        [Description("Craftsman (Any)")]
        CraftsmanAny,
        [Description("Craftsman (Apothecary)")]
        CraftsmanApothecary,
        [Description("Craftsman (Boatbuilder)")]
        CraftsmanBoatbuilder,
        [Description("Craftsman (Engineer)")]
        CraftsmanEngineer,
        [Description("Craftsman (Explosives)")]
        CraftsmanExplosives,
        [Description("Craftsman (Herbalist)")]
        CraftsmanHerbalist,
        Criminal,
        
        [Description("Deadeye Shot")]
        DeadeyeShot,
        Dealmaker,
        [Description("Detect Artefact")]
        DetectArtefact,
        Diceman,
        [Description("Dirty Fighting")]
        DirtyFighting,
        Disarm,
        Distract,
        Drilled,
        [Description("Dual Wielder")]
        DualWielder,
        
        Embezzle,
        [Description("Enclosed Fighter")]
        EnclosedFighter,
        [Description("Etiquette (Any)")]
        EtiquetteAny,
        [Description("Etiquette (Criminals)")]
        EtiquetteCriminals,
        [Description("Etiquette (Cultists)")]
        EtiquetteCultists,
        [Description("Etiquette (Guider)")]
        EtiquetteGuilder,
        [Description("Etiquette (Nobles)")]
        EtiquetteNobles,
        [Description("Etiquette (Scholar)")]
        EtiquetteScholar,
        [Description("Etiquette (Servants)")]
        EtiquetteServants,
        [Description("Etiquette (Soldiers)")]
        EtiquetteSoldiers,

        [Description("Fast Hands")]
        FastHands,
        [Description("Fast Shot")]
        FastShot,
        [Description("Fearless (Animals)")]
        FearlessAnimals,
        [Description("Fearless (Any)")]
        FearlessAny,
        [Description("Fearless (Beastmen)")]
        FearlessBeastmen,
        [Description("Fearless (Bounties)")]
        FearlessBounties,
        [Description("Fearless (Criminals)")]
        FearlessCriminals,
        [Description("Fearless (Everything)")]
        FearlessEverything,
        [Description("Fearless (Heretics)")]
        FearlessHeretics,
        [Description("Fearless (Intruders)")]
        FearlessIntruders,
        [Description("Fearless (Monsters)")]
        FearlessMonsters,
        [Description("Fearless (Outlaws)")]
        FearlessOutlaws,
        [Description("Fearless (Rats)")]
        FearlessRats,
        [Description("Fearless (Riverwardens)")]
        FearlessRiverwardens,
        [Description("Fearless (Road Wardens)")]
        FearlessRoadWardens,
        [Description("Fearless (Skaven)")]
        FearlessSkaven,
        [Description("Fearless (Undead)")]
        FearlessUndead,
        [Description("Fearless (Watchmen)")]
        FearlessWatchmen,
        [Description("Fearless (Witches)")]
        FearlessWitches,
        [Description("Fearless (Wreckers)")]
        FearlessWreckers,
        Feint,
        [Description("Field Dressing")]
        FieldDressing,
        Fisherman,
        Flagellant,
        [Description("Flee!")]
        Flee,
        [Description("Fleet Footed")]
        FleetFooted,
        Frenzy,
        Frightening,
        [Description("Furious Assault")]
        FuriousAssault,
        
        Gregarious,
        Gunner,
        
        Hardy,
        [Description("Hatred (Any)")]
        HatredAny,
        [Description("Hatred (Heretics)")]
        HatredHeretics,
        [Description("Hatred (Outlaws)")]
        HatredOutlaws,
        [Description("Holy Hatred")]
        HolyHatred,
        [Description("Holy Visions")]
        HolyVisions,
        [Description("Hunter's Eye")]
        HuntersEye,

        [Description("Impassioned Zeal")]
        ImpassionedZeal,
        Implacable,
        [Description("In-fighter")]
        InFighter,
        Inspiring,
        [Description("Instinctive Diction")]
        InstinctiveDiction,
        [Description("Invoke (Any)")]
        InvokeAny,
        [Description("Iron Jaw")]
        IronJaw,
        [Description("Iron Will")]
        IronWill,

        [Description("Jump Up")]
        JumpUp,

        Kingpin,

        [Description("Lightning Reflexes")]
        LightningReflexes,
        Linguistics,
        [Description("Lip Reading")]
        LipReading,
        Luck,
        
        [Description("Magical Sense")]
        MagicalSense,
        [Description("Magic (Hedgecraft)")]
        MagicHedgecraft,
        [Description("Magnum Opus")]
        MagnumOpus,
        Marksman,
        [Description("Master Craftsman (Boatbuilder)")]
        MasterCraftsmanBoatbuilder,
        [Description("Master Craftsman (Herbalist)")]
        MasterCraftsmanHerbalist,
        [Description("Master of Disguise")]
        MasterOfDisguise,
        [Description("Master Orator")]
        MasterOrator,
        [Description("Master Tradesman (Any)")]
        MasterTradesmanAny,
        [Description("Master Tradesman (Apothecary)")]
        MasterTradesmanApothecary,
        [Description("Master Tradesman (Engineering)")]
        MasterTradesmanEngineering,
        [Description("Master Tradesman (Herbalist)")]
        MasterTradesmanHerbalist,
        [Description("Master Tradesman (Poisoner)")]
        MasterTradesmanPoisoner,
        Menacing,
        Mimic,

        [Description("Night Vision")]
        NightVision,
        [Description("Nimble Fingered")]
        NimbleFingered,
        [Description("Noble Blood")]
        NobleBlood,
        [Description("Nose for Trouble")]
        NoseForTrouble,
        Numismatics,
        
        [Description("Old Salt")]
        OldSalt,
        Orientation,

        Panhandle,
        [Description("Perfect Pitch")]
        PerfectPitch,
        [Description("Petty Magic")]
        PettyMagic,
        Pharmacist,
        Pilot,
        [Description("Public Speaker")]
        PublicSpeaker,
        [Description("Pure Soul")]
        PureSoul,

        [Description("Rapid Reload")]
        RapidReload,
        [Description("Reaction Strike")]
        ReactionStrike,
        [Description("Read/Write")]        
        ReadWrite,
        Relentless,
        [Description("Resistance (Any)")]
        ResistanceAny,
        [Description("Resistance (Disease)")]
        ResistanceDisease,
        [Description("Resistance (Poison)")]
        ResistancePoison,
        Resolute,
        Reversal,
        Riposte,
        [Description("River Guide")]
        RiverGuide,
        Robust,
        Roughrider,
        Rover,

        [Description("Savant (Any)")]
        SavantAny,
        [Description("Savant (Apothecary)")]
        SavantApothecary,
        [Description("Savant (Engineering)")]
        SavantEngineering,
        [Description("Savant (Herbs)")]
        SavantHerbs,
        [Description("Savant (Law)")]
        SavantLaw,
        [Description("Savant (Local)")]
        SavantLocal,
        [Description("Savant (Medicine)")]
        SavantMedicine,
        [Description("Savant (Riverways)")]
        SavantRiverways,
        [Description("Savant (Theology)")]
        SavantTheology,
        Savvy,
        [Description("Scale Sheer Surface")]
        ScaleSheerSurface,
        Schemer,
        [Description("Sea Legs")]
        SeaLegs,
        [Description("Seasoned Traveler")]
        SeasonedTraveler,
        [Description("Second Sight")]
        SecondSight,
        [Description("Secret Identity")]
        SecretIdentity,
        Slayer,
        Shadow,
        Sharp,
        Sharpshooter,
        Shieldsman,
        [Description("Sixth Sense")]
        SixthSense,
        Sniper,
        Speedreader,
        Sprinter,
        [Description("Step Aside")]
        StepAside,
        [Description("Stone Soup")]
        StoneSoup,
        [Description("Stout-hearted")]
        StoutHearted,
        [Description("Strider (Any)")]
        StriderAny,
        [Description("Strider (Coastal)")]
        StriderCoastal,
        [Description("Strider (Marshes)")]
        StriderMarshes,
        [Description("Strider (Rocky)")]
        StriderRocky,
        [Description("Strider (Woodlands)")]
        StriderWoodlands,
        [Description("Strike Mighty Blow")]
        StrikeMightyBlow,
        [Description("Strike to Injure")]
        StrikeToInjure,
        [Description("Strike to Stun")]
        StrikeToStun,
        [Description("Strong Back")]
        StrongBack,
        [Description("Strong Legs")]
        StrongLegs,
        [Description("Strong-minded")]
        StrongMinded,
        [Description("Strong Swimmer")]
        StrongSwimmer,
        Sturdy,
        Suave,
        [Description("Super Numerate")]
        SuperNumerate,
        Supportive,
        [Description("Sure Shot")]
        SureShot,
        Surgery,
        
        Tenacious,
        Tinker,
        [Description("Tower of Memories")]
        TowerOfMemories,
        Trapper,
        [Description("Trick Riding")]
        TrickRiding,
        [Description("Tunnel Rat")]
        TunnelRat,

        Unshakeable,

        [Description("Very Resilient")]
        VeryResilient,
        [Description("Very Strong")]
        VeryStrong,

        Warleader,
        [Description("War Wizard")]
        WarWizard,
        [Description("Warrior Born")]
        WarriorBorn,
        Waterman,
        Wealthy,
        [Description("Well-prepared")]
        WellPrepared,
        [Description("Witch!")]
        Witch,
    }
}
