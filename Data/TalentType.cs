using System.ComponentModel;

namespace WfrpChars.Data
{
    enum TalentType
    {
        [Description("Accurate Shot")]
        AccurateShot,
        [Description("Accute Sense (Any)")]
        AccuteSenseAny,
        [Description("Accute Sense (Taste)")]
        AccuteSenseTaste,
        [Description("Accute Sense (Taste or Touch)")]
        AccuteSenseTasteOrTouch,
        [Description("Alley Cat")]
        AlleyCat,
        Ambidextrous,
        [Description("Animal Affinity")]
        AnimalAffinity,
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
        Bookish,
        [Description("Break and Enter")]
        BreakAndEnter,
        Briber,

        Cardsharp,
        [Description("Careful Strike")]
        CarefulStrike,
        Carouser,
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
        [Description("Craftsman (Engineer)")]
        CraftsmanEngineer,
        Criminal,
        
        [Description("Deadeye Shot")]
        DeadeyeShot,
        Dealmaker,
        Diceman,
        [Description("Dirty Fighting")]
        DirtyFighting,
        Disarm,
        Distract,
        [Description("Dual Wielder")]
        DualWielder,
        
        Embezzle,
        [Description("Etiquette (Any)")]
        EtiquetteAny,
        [Description("Etiquette (Criminals)")]
        EtiquetteCriminals,
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
        [Description("Fearless (Beastmen)")]
        FearlessBeastmen,
        [Description("Fearless (Bounties)")]
        FearlessBounties,
        [Description("Fearless (Heretics)")]
        FearlessHeretics,
        [Description("Fearless (Intruders)")]
        FearlessIntruders,
        [Description("Fearless (Outlaws)")]
        FearlessOutlaws,
        [Description("Fearless (Undead)")]
        FearlessUndead,
        [Description("Fearless (Watchmen)")]
        FearlessWatchmen,
        Feint,
        [Description("Field Dressing")]
        FieldDressing,
        Fisherman,
        Flagellant,
        [Description("Flee!")]
        Flee,
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

        [Description("Impassioned Zeal")]
        ImpassionedZeal,
        Implacable,
        Inspiring,
        [Description("Iron Will")]
        IronWill,
        
        [Description("Jump Up")]
        JumpUp,

        Kingpin,

        [Description("Lightning Reflexes")]
        LightningReflexes,
        Luck,
        
        [Description("Magnum Opus")]
        MagnumOpus,
        Marksman,
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
        
        Orientation,

        Panhandle,
        [Description("Perfect Pitch")]
        PerfectPitch,
        Pharmacist,
        Pilot,
        [Description("Public Speaker")]
        PublicSpeaker,

        [Description("Rapid Reload")]
        RapidReload,
        [Description("Reaction Strike")]
        ReactionStrike,
        [Description("Read/Write")]        
        ReadWrite,
        Relentless,
        [Description("Resistance (Disease)")]
        ResistanceDisease,
        [Description("Resistance (Poison)")]
        ResistancePoison,
        Reversal,
        Riposte,
        Robust,
        Roughrider,

        [Description("Savant (Apothecary)")]
        SavantApothecary,
        [Description("Savant (Engineering)")]
        SavantEngineering,
        Savvy,
        Schemer,
        [Description("Seasoned Traveler")]
        SeasonedTraveler,
        [Description("Secret Identity")]
        SecretIdentity,
        Shadow,
        Sharp,
        Sharpshooter,
        Shieldsman,
        [Description("Sixth Sense")]
        SixthSense,
        Sniper,
        Sprinter,
        [Description("Step Aside")]
        StepAside,
        [Description("Stone Soup")]
        StoneSoup,
        [Description("Stout-hearted")]
        StoutHearted,
        [Description("Strike Mighty Blow")]
        StrikeMightyBlow,
        [Description("Strike to Injure")]
        StrikeToInjure,
        [Description("Strike to Stun")]
        StrikeToStun,
        [Description("Strong Back")]
        StrongBack,
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
        
        Tenacious,
        Tinker,
        Trapper,
        [Description("Trick Riding")]
        TrickRiding,
        [Description("Tunnel Rat")]
        TunnelRat,

        Unshakable,

        [Description("Very Resilient")]
        VeryResilient,
        [Description("Very Strong")]
        VeryStrong,

        Warleader,
        Waterman,
    }
}
