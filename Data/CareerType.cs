using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WfrpChars.Data
{
    enum CareerType
    {
        Advisor,
        Agitator,
        Apothecary,
        Artisan,
        Artist,
        Baliff,
        Bawd,
        Beggar,
        Boatman,
        [Description("Bounty Hunter")]
        BountyHunter,
        Cavalryman,
        Charlatan,
        Coachman,
        Duelist,
        Engineer,
        Entertainer,
        Envoy,
        Fence,
        Flagellant,
        [Description("Grave Robber")]
        GraveRobber,
        Guard,
        [Description("Hedge Witch")]
        HedgeWitch,
        Herbalist,
        Huffer,
        Investigator,
        Knight,
        Lawyer,
        Merchant,
        Messenger,
        Miner,
        Mystic,
        Noble,
        Nun,
        Outlaw,
        Pedlar,
        Physician,
        Priest,
        Protagonist,
        [Description("Rat Catcher")]
        RatCatcher,
        Racketeer,
        Riverwarden,
        Riverwoman,
        [Description("Road Warden")]
        RoadWarden,
        Scholar,
        Scout,
        Seaman,
        Servant,
        Slayer,
        Smuggler,
        Soldier,
        Spy,
        Stevedore,
        Thief,
        Townsman,
        Villager,
        Warden,
        [Description("Warrior Priest")]
        WarriorPriest,
        Watchman,
        Witch,
        [Description("Witch Hunter")]
        WitchHunter,
        Wizard,
        Wrecker
    }
}
