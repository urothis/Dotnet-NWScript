namespace NWN.Enums
{
    public enum PvPSetting
    {
        NoPvP              = 0,
        PartyPvP           = 1,
        FullPvP            = 2,
        ServerDefault      = 3,
    }
    public enum WeatherEffectType
    {
        Rain = 0,
        Snow = 1,
        Lightning = 2,
    }
    public enum WeatherType
    {
        Invalid = -1,
        Clear = 0,
        Rain = 1,
        Snow = 2,
    }
    public enum DayNightCycleType
    {
        CycleDayNight = 0,
        AlwaysBright = 1,
        AlwaysDark = 2,
    }
    public enum AreaColorType
    {
        MoonAmbient = 0,
        MoonDiffuse = 1,
        SunAmbient  = 2,
        SunDiffuse  = 3,
    }
    public enum MovementRate
    {
        PC       = 0,
        Immobile = 1,
        VerySlow = 2,
        Slow     = 3,
        Normal   = 4,
        Fast     = 5,
        VeryFast = 6,
        Default  = 7,
        DMFast   = 8,
    }
    public enum MovementType
    {
        Stationary    = 0,
        Walk          = 1,
        Run           = 2,
        Sidestep      = 3,
        WalkBackwards = 4,
    }
    public enum BonusType
    {
        Attack        = 1,
        Damage        = 2,
        SavingThrow   = 3,
        Ability       = 4,
        Skill         = 5,
        TouchAttack   = 6,
    }
    public enum Gender
    {
        Male = 0,
        Female = 1,
        Both = 2,
        Other = 3,
        None = 4,
    }
    public enum CreatureSize
    {
        Invalid = 0,
        Tiny = 1,
        Small = 2,
        Medium = 3,
        Large = 4,
        Huge = 5,
    }

    public enum ACModifierType
    {
        DodgeBonus,
        NaturalBonus,
        EnchantmentBonus,
        ShieldEnchantmentBonus,
        DeflectionBonus,
        VSDamageTypeAll = 4103

    }

    public enum SpecialAttack
    {
        Invalid = 0,
        CalledShotLeg = 1,
        CalledShotArm = 2,
        Sap = 3,
        Disarm = 4,
        ImprovedDisarm = 5,
        Knockdown = 6,
        ImprovedKnockdown = 7,
        StunningFist = 8,
        FlurryOfBlows = 9,
        RapidShot = 10,
    }
    public enum CombatMode
    {
        Invalid             = 0,
        Parry               = 1,
        PowerAttack         = 2,
        ImprovedPowerAttack = 3,
        //CounterSpell
        FlurryOfBlows       = 4,
        RapidShot           = 5,
        Expertise           = 6,
        ImprovedExpertise   = 7,
        DefensiveCasting    = 8,
        DirtyFighting       = 9,
        DefensiveStance     = 10,
    }
    public enum AILevel
    {
        Default   = -1,
        VeryLow   = 0,
        Low       = 1,
        Medium    = 2,
        High      = 3,
        VeryHigh  = 4,
    }
    public enum AssociateCommand
    {
        StandGround = -2,
        AttackNearest = -3,
        HealMaster = -4,
        FollowMaster = -5,
        MasterFailedLockpick = -6,
        GuardMaster = -7,
        UnsummonFamiliar = -8,
        UnsummonAnimalCompanion = -9,
        UnsummonSummoned = -10,
        MasterUnderAttack = -11,
        ReleaseDomination = -12,
        UnpossessFamiliar = -13,
        MasterSawTrap = -14,
        MasterAttackedOther = -15,
        MasterGoingtobeAttacked = -16,
        LeaveParty = -17,
        PickLock = -18,
        Inventory = -19,
        DisarmTrap = -20,
        ToggleCasting = -21,
        ToggleStealth = -22,
        ToggleSearch = -23,
    }
    public enum Ability
    {
        Invalid       = -1,
        Strength      = 0,
        Dexterity     = 1,
        Constitution  = 2,
        Intelligence  = 3,
        Wisdom        = 4,
        Charisma      = 5,
    }
    [System.Flags]
    public enum ObjectType
    {
        Creature       = 1,
        Item           = 2,
        Trigger        = 4,
        Door           = 8,
        AreaOfEffect   = 16,
        Waypoint       = 32,
        Placeable      = 64,
        Store          = 128,
        Encounter      = 256,
        All            = 32767,
        Invalid        = 32767,
    }
    public enum ObjectTypeEngine
    {
        Invalid        = -1,
        GUI            = 1,
        Tile           = 2,
        Module         = 3,
        Area           = 4,
        Creature       = 5,
        Item           = 6,
        Trigger        = 7,
        Projectile     = 8,
        Placeable      = 9,
        Door           = 10,
        AreaOfEffect   = 11,
        Waypoint       = 12,
        Encounter      = 13,
        Store          = 14,
        Portal         = 15,
        Sound          = 16,
    }

    public enum SaveReturn
    {
        Failed,
        Succeded,
        Immune
    }

    public enum CastingMode
    {
        Disabled,
        Activated
    }

    public enum DetectMode
    {
        Passive,
        Active
    }

    public enum StealthMode
    {
        Disabled,
        Activated
    }

    public enum TouchAttackReturn
    {
        Miss,
        Hit,
        Critical
    }

    public enum RestType
    {
        Invalid,
        Started,
        Finished,
        Cancelled
    }

    public enum EventScript
    {
        Module_OnHeartbeat                    = 3000,
        Module_OnUserDefined                  = 3001,
        Module_OnModuleLoad                   = 3002,
        Module_OnModuleStart                  = 3003,
        Module_OnClientEnter                  = 3004,
        Module_OnClientExit                   = 3005,
        Module_OnActivateItem                 = 3006,
        Module_OnAcquireItem                  = 3007,
        Module_OnLoseItem                     = 3008,
        Module_OnPlayerDeath                  = 3009,
        Module_OnPlayerDying                  = 3010,
        Module_OnRespawnButtonPressed         = 3011,
        Module_OnPlayerRest                   = 3012,
        Module_OnPlayerLevelUp                = 3013,
        Module_OnPlayerCancelCutscene         = 3014,
        Module_OnEquipItem                    = 3015,
        Module_OnUnequipItem                  = 3016,
        Module_OnPlayerChat                   = 3017,
        Area_OnHeartbeat                      = 4000,
        Area_OnUserDefined                    = 4001,
        Area_OnEnter                          = 4002,
        Area_OnExit                           = 4003,
        AreaOfEffect_OnHeartbeat              = 11000,
        AreaOfEffect_OnUserDefined            = 11001,
        AreaOfEffect_OnObjectEnter            = 11002,
        AreaOfEffect_OnObjectExit             = 11003,
        Creature_OnHeartbeat                  = 5000,
        Creature_OnNotice                     = 5001,
        Creature_OnSpellCastAt                = 5002,
        Creature_OnMeleeAttacked              = 5003,
        Creature_OnDamaged                    = 5004,
        Creature_OnDisturbed                  = 5005,
        Creature_OnEndCombatRound             = 5006,
        Creature_OnDialogue                   = 5007,
        Creature_OnSpawnIn                    = 5008,
        Creature_OnRested                     = 5009,
        Creature_OnDeath                      = 5010,
        Creature_OnUserDefined                = 5011,
        Creature_OnBlockedByDoor              = 5012,
        Trigger_OnHeartbeat                   = 7000,
        Trigger_OnObjectEnter                 = 7001,
        Trigger_OnObjectExit                  = 7002,
        Trigger_OnUserDefined                 = 7003,
        Trigger_OnTrapTriggered               = 7004,
        Trigger_OnDisarmed                    = 7005,
        Trigger_OnClicked                     = 7006,
        Placeable_OnClosed                    = 9000,
        Placeable_OnDamaged                   = 9001,
        Placeable_OnDeath                     = 9002,
        Placeable_OnDisarm                    = 9003,
        Placeable_OnHeartbeat                 = 9004,
        Placeable_OnInventoryDisturbed        = 9005,
        Placeable_OnLock                      = 9006,
        Placeable_OnMeleeAttacked             = 9007,
        Placeable_OnOpen                      = 9008,
        Placeable_OnSpellCastAt               = 9009,
        Placeable_OnTrapTriggered             = 9010,
        Placeable_OnUnlock                    = 9011,
        Placeable_OnUsed                      = 9012,
        Placeable_OnUserDefined               = 9013,
        Placeable_OnDialogue                  = 9014,
        Placeable_OnLeftClick                 = 9015,
        Door_OnOpen                           = 10000,
        Door_OnClose                          = 10001,
        Door_OnDamage                         = 10002,
        Door_OnDeath                          = 10003,
        Door_OnDisarm                         = 10004,
        Door_OnHeartbeat                      = 10005,
        Door_OnLock                           = 10006,
        Door_OnMeleeAttacked                  = 10007,
        Door_OnSpellcastat                    = 10008,
        Door_OnTrapTriggered                  = 10009,
        Door_OnUnlock                         = 10010,
        Door_OnUserDefined                    = 10011,
        Door_OnClicked                        = 10012,
        Door_OnDialogue                       = 10013,
        Door_OnFailToOpen                     = 10014,
        Encounter_OnObjectEnter               = 13000,
        Encounter_OnObjectExit                = 13001,
        Encounter_OnHeartbeat                 = 13002,
        Encounter_OnEncounterExhausted        = 13003,
        Encounter_OnUserDefined               = 13004,
        Store_OnOpen                          = 14000,
        Store_OnClose                         = 14001,
    }

    public enum ArcaneSpellFailure
    {
        MINUS_50_PERCENT,
        MINUS_45_PERCENT,
        MINUS_40_PERCENT,
        MINUS_35_PERCENT,
        MINUS_30_PERCENT,
        MINUS_25_PERCENT,
        MINUS_20_PERCENT,
        MINUS_15_PERCENT,
        MINUS_10_PERCENT,
        MINUS_5_PERCENT,
        PLUS_5_PERCENT,
        PLUS_10_PERCENT,
        PLUS_15_PERCENT,
        PLUS_20_PERCENT,
        PLUS_25_PERCENT,
        PLUS_30_PERCENT,
        PLUS_35_PERCENT,
        PLUS_40_PERCENT,
        PLUS_45_PERCENT,
        PLUS_50_PERCENT
    }

public enum Package
    {
        Barbarian = 0,
        Bard = 1,
        Cleric = 2,
        Druid = 3,
        Fighter = 4,
        NWNMonk = 5,
        Paladin = 6,
        NWNRanger = 7,
        Rogue = 8,
        Sorcerer = 9,
        Wizardgeneralist = 10,
        Druid_Interloper = 11,
        Druid_Gray = 12,
        Druid_Death = 13,
        Druid_Hawkmaster = 14,
        Barbarian_Brute = 15,
        Barbarian_Slayer = 16,
        Barbarian_Savage = 17,
        Barbarian_Orcblood = 18,
        Cleric_Shaman = 19,
        Cleric_Deadwalker = 20,
        Cleric_Elementalist = 21,
        Cleric_Battle_Priest = 22,
        Fighter_Finesse = 23,
        Fighter_Pirate = 24,
        Fighter_Gladiator = 25,
        Fighter_Commander = 26,
        Wizard_Abjuration = 27,
        Wizard_Conjuration = 28,
        Wizard_Divination = 29,
        Wizard_Enchantment = 30,
        Wizard_Evocation = 31,
        Wizard_Illusion = 32,
        Wizard_Necromancy = 33,
        Wizard_Transmutation = 34,
        Sorcerer_Abjuration = 35,
        Sorcerer_Conjuration = 36,
        Sorcerer_Divination = 37,
        Sorcerer_Enchantment = 38,
        Sorcerer_Evocation = 39,
        Sorcerer_Illusion = 40,
        Sorcerer_Necromancy = 41,
        Sorcerer_Transmutation = 42,
        Bard_Blade = 43,
        Bard_Gallant = 44,
        Bard_Jester = 45,
        Bard_Loremaster = 46,
        Monk_Spirit = 47,
        Monk_Gifted = 48,
        Monk_Devout = 49,
        Monk_Peasant = 50,
        Paladin_Errant = 51,
        Paladin_Undead = 52,
        Paladin_Inquisitor = 53,
        Paladin_Champion = 54,
        Ranger_Marksman = 55,
        Ranger_Warden = 56,
        Ranger_Stalker = 57,
        Ranger_Giantkiller = 58,
        Rogue_Gypsy = 59,
        Rogue_Bandit = 60,
        Rogue_Scout = 61,
        Rogue_Swashbuckler = 62,
        Shadowdancer = 63,
        Harper = 64,
        Arcane_Archer = 65,
        Assassin = 66,
        Blackguard = 67,
        Npc_Sorcerer = 70,
        Npc_Rogue = 71,
        Npc_Bard = 72,
        Aberration = 73,
        Animal = 74,
        Construct = 75,
        Humanoid = 76,
        Monstrous = 77,
        Elemental = 78,
        Fey = 79,
        Dragon = 80,
        Undead = 81,
        Commoner = 82,
        Beast = 83,
        Giant = 84,
        Magicbeast = 85,
        Outsider = 86,
        Shapechanger = 87,
        Vermin = 88,
        Dwarven_Defender = 89,
        Barbarian_Blackguard = 90,
        Bard_Harper = 91,
        Cleric_Divine = 92,
        Druid_Shifter = 93,
        Fighter_Weaponmaster = 94,
        Monk_Assassin = 95,
        Paladin_Divine = 96,
        Ranger_Arcanearcher = 97,
        Rogue_Shadowdancer = 98,
        Sorcerer_Dragondisciple = 99,
        Wizard_Palemaster = 100,
        Npc_Wizassassin = 101,
        Npc_Ft_Weaponmaster = 102,
        Npc_Rg_Shadowdancer = 103,
        Npc_Cleric_Linu = 104,
        Npc_Barbarian_Daelan = 105,
        Npc_Bard_Fighter = 106,
        Npc_Paladin_Falling = 107,
        Shifter = 108,
        Divine_Champion = 109,
        Pale_Master = 110,
        Dragon_Disciple = 111,
        Weaponmaster = 112,
        Npc_Ft_Weaponmaster_Valen_2 = 113,
        Npc_Bard_Fighter_Sharwyn2 = 114,
        Npc_Wizassassin_Nathyrra = 115,
        Npc_Rg_Tomi_2 = 116,
        Npc_Bard_Deekin_2 = 117,
        Barbarian_Blackguard_2Ndclass = 118,
        Bard_Harper_2Ndclass = 119,
        Cleric_Divine_2Ndclass = 120,
        Druid_Shifter_2Ndclass = 121,
        Fighter_Weaponmaster_2Ndclass = 122,
        Monk_Assassin_2Ndclass = 123,
        Paladin_Divine_2Ndclass = 124,
        Ranger_Arcanearcher_2Ndclass = 125,
        Rogue_Shadowdancer_2Ndclass = 126,
        Sorcerer_Dragondisciple_2Ndclass = 127,
        Wizard_Palemaster_2Ndclass = 128,
        Npc_Aribeth_Paladin = 129,
        Npc_Aribeth_Blackguard = 130,
        PurpleDragonKnight = 131,
        Plant = 132,
        Warrior = 133,
        Monk = 134,
        Thief = 135,
        Ranger = 136,
        WhiteMage = 137,
        BlackMage = 138,
        Miner = 155,
        Botanist = 156,
        Carpenter = 157,
        Blacksmith = 158,
        Invalid = 255,
    }

    public class FadeSpeed
    {
        public const float Slowest = 0.003f;
        public const float Slow = 0.005f;
        public const float Medium = 0.01f;
        public const float Fast = 0.017f;
        public const float Fastest = 0.25f;
    }

    public enum AppearanceType
    {
        Invalid = -1,
        Allip = 186,
        Aranea = 157,
        Arch_Target = 200,
        Aribeth = 190,
        Asabi_Chieftain = 353,
        Asabi_Shaman = 354,
        Asabi_Warrior = 355,
        Badger = 8,
        Badger_Dire = 9,
        Balor = 38,
        Bartender = 234,
        Basilisk = 369,
        Bat = 10,
        Bat_Horror = 11,
        Bear_Black = 12,
        Bear_Brown = 13,
        Bear_Dire = 15,
        Bear_Kodiak = 204,
        Bear_Polar = 14,
        Beetle_Fire = 18,
        Beetle_Slicer = 17,
        Beetle_Stag = 19,
        Beetle_Stink = 20,
        Begger = 220,
        Blood_Sailer = 221,
        Boar = 21,
        Boar_Dire = 22,
        Bodak = 23,
        Bugbear_A = 29,
        Bugbear_B = 30,
        Bugbear_Chieftain_A = 25,
        Bugbear_Chieftain_B = 26,
        Bugbear_Shaman_A = 27,
        Bugbear_Shaman_B = 28,
        Bulette = 481,
        Cat_Cat_Dire = 95,
        Cat_Cougar = 203,
        Cat_Crag_Cat = 94,
        Cat_Jaguar = 98,
        Cat_Krenshar = 96,
        Cat_Leopard = 93,
        Cat_Lion = 97,
        Cat_Mpanther = 306,
        Cat_Panther = 202,
        Chicken = 31,
        Cockatrice = 368,
        Combat_Dummy = 201,
        Convict = 238,
        Cow = 34,
        Cult_Member = 212,
        Deer = 35,
        Deer_Stag = 37,
        Devil = 392,
        Dog = 176,
        Dog_Blinkdog = 174,
        Dog_Dire_Wolf = 175,
        Dog_Fenhound = 177,
        Dog_Hell_Hound = 179,
        Dog_Shadow_Mastif = 180,
        Dog_Winter_Wolf = 184,
        Dog_Wolf = 181,
        Dog_Worg = 185,
        Doom_Knight = 40,
        Dragon_Black = 41,
        Dragon_Blue = 47,
        Dragon_Brass = 42,
        Dragon_Bronze = 45,
        Dragon_Copper = 43,
        Dragon_Gold = 46,
        Dragon_Green = 48,
        Dragon_Red = 49,
        Dragon_Silver = 44,
        Dragon_White = 50,
        Drow_Cleric = 215,
        Drow_Fighter = 216,
        Druegar_Cleric = 218,
        Druegar_Fighter = 217,
        Dryad = 51,
        Dwarf = 0,
        Dwarf_Npc_Female = 248,
        Dwarf_Npc_Male = 249,
        Elemental_Air = 52,
        Elemental_Air_Elder = 53,
        Elemental_Earth = 56,
        Elemental_Earth_Elder = 57,
        Elemental_Fire = 60,
        Elemental_Fire_Elder = 61,
        Elemental_Water = 69,
        Elemental_Water_Elder = 68,
        Elf = 1,
        Elf_Npc_Female = 245,
        Elf_Npc_Male_01 = 246,
        Elf_Npc_Male_02 = 247,
        Ettercap = 166,
        Ettin = 72,
        Faerie_Dragon = 374,
        Fairy = 55,
        Falcon = 144,
        Female_01 = 222,
        Female_02 = 223,
        Female_03 = 224,
        Female_04 = 225,
        Formian_Myrmarch = 362,
        Formian_Queen = 363,
        Formian_Warrior = 361,
        Formian_Worker = 360,
        Gargoyle = 73,
        Ghast = 74,
        Ghoul = 76,
        Ghoul_Lord = 77,
        Giant_Fire = 80,
        Giant_Fire_Female = 351,
        Giant_Frost = 81,
        Giant_Frost_Female = 350,
        Giant_Hill = 78,
        Giant_Mountain = 79,
        Gnoll_Warrior = 388,
        Gnoll_Wiz = 389,
        Gnome = 2,
        Gnome_Npc_Female = 243,
        Gnome_Npc_Male = 244,
        Goblin_A = 86,
        Goblin_B = 87,
        Goblin_Chief_A = 82,
        Goblin_Chief_B = 83,
        Goblin_Shaman_A = 84,
        Goblin_Shaman_B = 85,
        Golem_Bone = 24,
        Golem_Clay = 91,
        Golem_Flesh = 88,
        Golem_Iron = 89,
        Golem_Stone = 92,
        Gorgon = 367,
        Gray_Ooze = 393,
        Grey_Render = 205,
        Gynosphinx = 365,
        Halfling = 3,
        Halfling_Npc_Female = 250,
        Halfling_Npc_Male = 251,
        Half_Elf = 4,
        Half_Orc = 5,
        Half_Orc_Npc_Female = 252,
        Half_Orc_Npc_Male_01 = 253,
        Half_Orc_Npc_Male_02 = 254,
        Helmed_Horror = 100,
        Heurodis_Lich = 370,
        Hobgoblin_Warrior = 390,
        Hobgoblin_Wizard = 391,
        Hook_Horror = 102,
        House_Guard = 219,
        Human = 6,
        Human_Npc_Female_01 = 255,
        Human_Npc_Female_02 = 256,
        Human_Npc_Female_03 = 257,
        Human_Npc_Female_04 = 258,
        Human_Npc_Female_05 = 259,
        Human_Npc_Female_06 = 260,
        Human_Npc_Female_07 = 261,
        Human_Npc_Female_08 = 262,
        Human_Npc_Female_09 = 263,
        Human_Npc_Female_10 = 264,
        Human_Npc_Female_11 = 265,
        Human_Npc_Female_12 = 266,
        Human_Npc_Male_01 = 267,
        Human_Npc_Male_02 = 268,
        Human_Npc_Male_03 = 269,
        Human_Npc_Male_04 = 270,
        Human_Npc_Male_05 = 271,
        Human_Npc_Male_06 = 272,
        Human_Npc_Male_07 = 273,
        Human_Npc_Male_08 = 274,
        Human_Npc_Male_09 = 275,
        Human_Npc_Male_10 = 276,
        Human_Npc_Male_11 = 277,
        Human_Npc_Male_12 = 278,
        Human_Npc_Male_13 = 279,
        Human_Npc_Male_14 = 280,
        Human_Npc_Male_15 = 281,
        Human_Npc_Male_16 = 282,
        Human_Npc_Male_17 = 283,
        Human_Npc_Male_18 = 284,
        Imp = 105,
        Inn_Keeper = 233,
        Intellect_Devourer = 117,
        Invisible_Human_Male = 298,
        Invisible_Stalker = 64,
        Kid_Female = 242,
        Kid_Male = 241,
        Kobold_A = 302,
        Kobold_B = 305,
        Kobold_Chief_A = 300,
        Kobold_Chief_B = 303,
        Kobold_Shaman_A = 301,
        Kobold_Shaman_B = 304,
        Lantern_Archon = 103,
        Lich = 39,
        Lizardfolk_A = 134,
        Lizardfolk_B = 135,
        Lizardfolk_Shaman_A = 132,
        Lizardfolk_Shaman_B = 133,
        Lizardfolk_Warrior_A = 130,
        Lizardfolk_Warrior_B = 131,
        Luskan_Guard = 211,
        Male_01 = 226,
        Male_02 = 227,
        Male_03 = 228,
        Male_04 = 229,
        Male_05 = 230,
        Manticore = 366,
        Medusa = 352,
        Mephit_Air = 106,
        Mephit_Dust = 107,
        Mephit_Earth = 108,
        Mephit_Fire = 109,
        Mephit_Ice = 110,
        Mephit_Magma = 114,
        Mephit_Ooze = 112,
        Mephit_Salt = 111,
        Mephit_Steam = 113,
        Mephit_Water = 115,
        Minogon = 119,
        Minotaur = 120,
        Minotaur_Chieftain = 121,
        Minotaur_Shaman = 122,
        Mohrg = 123,
        Mummy_Common = 58,
        Mummy_Fighter_2 = 59,
        Mummy_Greater = 124,
        Mummy_Warrior = 125,
        Nwn_Aarin = 188,
        Nwn_Aribeth_Evil = 189,
        Nwn_Haedraline = 191,
        Nwn_Maugrim = 193,
        Nwn_Morag = 192,
        Nwn_Nasher = 296,
        Nwn_Sedos = 297,
        Nw_Militia_Member = 210,
        Nymph = 126,
        Ochre_Jelly_Large = 394,
        Ochre_Jelly_Medium = 396,
        Ochre_Jelly_Small = 398,
        Ogre = 127,
        Ogreb = 207,
        Ogre_Chieftain = 128,
        Ogre_Chieftainb = 208,
        Ogre_Mage = 129,
        Ogre_Mageb = 209,
        Old_Man = 239,
        Old_Woman = 240,
        Orc_A = 140,
        Orc_B = 141,
        Orc_Chieftain_A = 136,
        Orc_Chieftain_B = 137,
        Orc_Shaman_A = 138,
        Orc_Shaman_B = 139,
        Ox = 142,
        Parrot = 7,
        Penguin = 206,
        Plague_Victim = 231,
        Prostitute_01 = 236,
        Prostitute_02 = 237,
        Pseudodragon = 375,
        Quasit = 104,
        Rakshasa_Bear_Male = 294,
        Rakshasa_Tiger_Female = 290,
        Rakshasa_Tiger_Male = 293,
        Rakshasa_Wolf_Male = 295,
        Rat = 386,
        Rat_Dire = 387,
        Raven = 145,
        Sahuagin = 65,
        Sahuagin_Leader = 66,
        Sahuagin_Cleric = 67,
        Seagull_Flying = 291,
        Seagull_Walking = 292,
        Shadow = 146,
        Shadow_Fiend = 147,
        Shark_Mako = 447,
        Shark_Hammerhead = 448,
        Shark_Goblin = 449,
        Shield_Guardian = 90,
        Shop_Keeper = 232,
        Skeletal_Devourer = 36,
        Skeleton_Chieftain = 182,
        Skeleton_Common = 63,
        Skeleton_Mage = 148,
        Skeleton_Priest = 62,
        Skeleton_Warrior = 150,
        Skeleton_Warrior_1 = 70,
        Skeleton_Warrior_2 = 71,
        Slaad_Blue = 151,
        Slaad_Death = 152,
        Slaad_Gray = 153,
        Slaad_Green = 154,
        Slaad_Red = 155,
        Spectre = 156,
        Sphinx = 364,
        Spider_Dire = 158,
        Spider_Giant = 159,
        Spider_Phase = 160,
        Spider_Sword = 161,
        Spider_Wraith = 162,
        Stinger = 356,
        Stinger_Chieftain = 358,
        Stinger_Mage = 359,
        Stinger_Warrior = 357,
        Succubus = 163,
        Troglodyte = 451,
        Troglodyte_Warrior = 452,
        Troglodyte_Cleric = 453,
        Troll = 167,
        Troll_Chieftain = 164,
        Troll_Shaman = 165,
        Umberhulk = 168,
        Uthgard_Elk_Tribe = 213,
        Uthgard_Tiger_Tribe = 214,
        Vampire_Female = 288,
        Vampire_Male = 289,
        Vrock = 101,
        Waitress = 235,
        War_Devourer = 54,
        Werecat = 99,
        Wererat = 170,
        Werewolf = 171,
        Wight = 172,
        Will_O_Wisp = 116,
        Wraith = 187,
        Wyrmling_Black = 378,
        Wyrmling_Blue = 377,
        Wyrmling_Brass = 381,
        Wyrmling_Bronze = 383,
        Wyrmling_Copper = 382,
        Wyrmling_Gold = 385,
        Wyrmling_Green = 379,
        Wyrmling_Red = 376,
        Wyrmling_Silver = 384,
        Wyrmling_White = 380,
        Yuan_Ti = 285,
        Yuan_Ti_Chieften = 286,
        Yuan_Ti_Wizard = 287,
        Zombie = 198,
        Zombie_Rotting = 195,
        Zombie_Tyrant_Fog = 199,
        Zombie_Warrior_1 = 196,
        Zombie_Warrior_2 = 197,
        Beholder = 401,
        Beholder_Mage = 402,
        Beholder_Eyeball = 403,
        Mephisto_Big = 404,
        Dracolich = 405,
        Drider = 406,
        Drider_Chief = 407,
        Drow_Slave = 408,
        Drow_Wizard = 409,
        Drow_Matron = 410,
        Duergar_Slave = 411,
        Duergar_Chief = 412,
        Mindflayer = 413,
        Mindflayer_2 = 414,
        Mindflayer_Alhoon = 415,
        Deep_Rothe = 416,
        Dragon_Shadow = 418,
        Harpy = 419,
        Golem_Mithral = 420,
        Golem_Adamantium = 421,
        Spider_Demon = 422,
        Svirf_Male = 423,
        Svirf_Female = 424,
        Dragon_Pris = 425,
        Slaad_Black = 426,
        Slaad_White = 427,
        Azer_Male = 428,
        Azer_Female = 429,
        Demi_Lich = 430,
        Object_Chair = 431,
        Object_Table = 432,
        Object_Candle = 433,
        Object_Chest = 434,
        Object_White = 435,
        Object_Blue = 436,
        Object_Cyan = 437,
        Object_Green = 438,
        Object_Yellow = 439,
        Object_Orange = 440,
        Object_Red = 441,
        Object_Purple = 442,
        Object_Flame_Small = 443,
        Object_Flame_Medium = 444,
        Object_Flame_Large = 445,
        Drider_Female = 446,
        Sea_Hag = 454,
        Golem_Demonflesh = 468,
        Animated_Chest = 469,
        Gelatinous_Cube = 470,
        Mephisto_Norm = 471,
        Beholder_Mother = 472,
        Object_Boat = 473,
        Dwarf_Golem = 474,
        Dwarf_Halforc = 475,
        Drow_Warrior_1 = 476,
        Drow_Warrior_2 = 477,
        Drow_Female_1 = 478,
        Drow_Female_2 = 479,
        Drow_Warrior_3 = 480,
    }

    public enum ArmorClassBonus
    {
        Dodge         = 0,
        Natural       = 1,
        Armor         = 2,
        Shield        = 3,
        Deflection    = 4,
    }

    public enum SavingThrow
    {
        All          = 0,
        None         = 0,
        Fortitude    = 1,
        Reflex       = 2,
        Will         = 3,
    }

    public enum SavingThrowType
    {
        All          = 0,
        None         = 0,
        MindSpells   = 1,
        Poison       = 2,
        Disease      = 3,
        Fear         = 4,
        Sonic        = 5,
        Acid         = 6,
        Fire         = 7,
        Electricity  = 8,
        Positive     = 9,
        Negative     = 10,
        Death        = 11,
        Cold         = 12,
        Divine       = 13,
        Trap         = 14,
        Spell        = 15,
        Good         = 16,
        Evil         = 17,
        Law          = 18,
        Chaos        = 19,
    }

    [System.Flags]
    public enum DamageType
    {
        None         = 0x0000,
        Bludgeoning  = 0x0001,
        Piercing     = 0x0002,
        Slashing     = 0x0004,
        Magical      = 0x0008,
        Acid         = 0x0010,
        Cold         = 0x0020,
        Divine       = 0x0040,
        Electrical   = 0x0080,
        Fire         = 0x0100,
        Negative     = 0x0200,
        Positive     = 0x0400,
        Sonic        = 0x0800,

        Physical     = Bludgeoning | Piercing | Slashing,
        Elemental    = Acid | Cold | Electrical | Fire | Sonic,
        Exotic       = Divine | Magical | Negative | Positive,

    }

    public enum ImmunityType
    {
        None                     = 0,
        MindSpells               = 1,
        Poison                   = 2,
        Disease                  = 3,
        Fear                     = 4,
        Trap                     = 5,
        Paralysis                = 6,
        Blindness                = 7,
        Deafness                 = 8,
        Slow                     = 9,
        Entangle                 = 10,
        Silence                  = 11,
        Stun                     = 12,
        Sleep                    = 13,
        Charm                    = 14,
        Dominate                 = 15,
        Confused                 = 16,
        Cursed                   = 17,
        Dazed                    = 18,
        AbilityDecrease          = 19,
        AttackDecrease           = 20,
        DamageDecrease           = 21,
        DamageImmunityDecrease   = 22,
        AcDecrease               = 23,
        MovementSpeedDecrease    = 24,
        SavingThrowDecrease      = 25,
        SpellResistanceDecrease  = 26,
        SkillDecrease            = 27,
        Knockdown                = 28,
        NegativeLevel            = 29,
        SneakAttack              = 30,
        CriticalHit              = 31,
        Death                    = 32,
    }

    public enum ToggleMode
    {
        Detect              = 0,
        Stealth             = 1,
        Parry               = 2,
        PowerAttack         = 3,
        ImprovedPowerAttack = 4,
        CounterSpell        = 5,
        FlurryOfBlows       = 6,
        RapidShot           = 7,
        Expertise           = 8,
        ImprovedExpertise   = 9,
        DefensiveCast       = 10,
        DirtyFighting       = 11,
        DefensiveStance     = 12,
    }

    public enum CombatModeEngine // Values used by the engine and NWNX
    {
        None                = 0,
        Parry               = 1,
        PowerAttack         = 2,
        ImprovedPowerAttack = 3,
        CounterSpell        = 4,
        FlurryOfBlows       = 5,
        RapidShot           = 6,
        Expertise           = 7,
        ImprovedExpertise   = 8,
        DefensiveCasting    = 9,
        DirtyFighting       = 10,
        DefensiveStance     = 11,
    }

    public enum Alignment
    {
        All                 = 0,
        Neutral             = 1,
        Lawful              = 2,
        Chaotic             = 3,
        Good                = 4,
        Evil                = 5,
    }

    public enum Direction
    {
        East = 0,
        North = 90,
        West = 180,
        South = 270,
        NorthEast = 45,
        NorthWest = 135,
        SouthEast = 315,
        SouthWest = 225,
    }

    public enum ChatChannelType
    {
        PlayerTalk = 1,
        PlayerShout = 2,
        PlayerWhisper = 3,
        PlayerTell = 4,
        ServerMessage = 5,
        PlayerParty = 6,
        PlayerDM = 14,
        DMTalk = 17,
        DMShout = 18,
        DMWhisper = 19,
        DMTell = 20,
        DMParty = 22,
        DMDM = 30
    }

    public enum TalkVolume
    {
        Talk = 0,
        Whisper = 1,
        Shout = 2,
        SilentTalk = 3,
        SilentShout = 4,
        Party = 5,
        Tell = 6
    }

    public enum MetaMagic
    {
        None = 0,
        Empower = 1,
        Extend = 2,
        Maximize = 4,
        Quicken = 8,
        Silent = 16,
        Any = 255
    }

    public enum Name
    {
        FirstGenericMale = -1,
        Animal = 0,
        Familiar = 1,
        FirstDwarfMale = 2,
        FirstDwarfFemale = 3,
        LastDwarf = 4,
        FirstElfMale = 5,
        FirstElfFemale = 6,
        LastElf = 7,
        FirstGnomeMale = 8,
        FirstGnomeFemale = 9,
        LastGnome = 10,
        FirstHalfelfMale = 11,
        FirstHalfElfFemale = 12,
        LastHalfElf = 13,
        FirstHalflingMale = 14,
        FirstHalflingFemale = 15,
        LastHalfling = 16,
        FirstHalfOrcMale = 17,
        FirstHalfOrcFemale = 18,
        LastHalfOrc = 19,
        FirstHumanMale = 20,
        FirstHumanFemale = 21,
        LastHuman = 22,
    }

    public enum Poison
    {
        Nightshade = 0,
        Small_Centipede_Poison = 1,
        Blade_Bane = 2,
        Greenblood_Oil = 3,
        Bloodroot = 4,
        Purple_Worm_Poison = 5,
        Large_Scorpion_Venom = 6,
        Wyvern_Poison = 7,
        Blue_Whinnis = 8,
        Giant_Wasp_Poison = 9,
        Shadow_Essence = 10,
        Black_Adder_Venom = 11,
        Deathblade = 12,
        Malyss_Root_Paste = 13,
        Nitharit = 14,
        Dragon_Bile = 15,
        Sassone_Leaf_Residue = 16,
        Terinav_Root = 17,
        Carrion_Crawler_Brain_Juice = 18,
        Black_Lotus_Extract = 19,
        Oil_Of_Taggit = 20,
        Id_Moss = 21,
        Striped_Toadstool = 22,
        Arsenic = 23,
        Lich_Dust = 24,
        Dark_Reaver_Powder = 25,
        Ungol_Dust = 26,
        Burnt_Othur_Fumes = 27,
        Chaos_Mist = 28,
        Bebilith_Venom = 29,
        Quasit_Venom = 30,
        Pit_Fiend_Ichor = 31,
        Ettercap_Venom = 32,
        Aranea_Venom = 33,
        Tiny_Spider_Venom = 34,
        Small_Spider_Venom = 35,
        Medium_Spider_Venom = 36,
        Large_Spider_Venom = 37,
        Huge_Spider_Venom = 38,
        Gargantuan_Spider_Venom = 39,
        Colossal_Spider_Venom = 40,
        Phase_Spider_Venom = 41,
        Wraith_Spider_Venom = 42,
        Iron_Golem = 43,
    }

    public enum CreatureType
    {
        RacialType = 0,
        PlayerCharacter = 1,
        Class = 2,
        Reputation = 3,
        IsAlive = 4,
        HasSpellEffect = 5,
        DoesNotHaveSpellEffect = 6,
        Perception = 7
    }

    public enum PersistentZone
    {
        Active = 0,
        Follow = 1
    }

    public enum Animation
    {
        Invalid = -1,
        Pause = 0,
        Pause2 = 1,
        Listen = 2,
        Meditate = 3,
        Worship = 4,
        Look_Far = 5,
        Sit_Chair = 6,
        Sit_Cross = 7,
        Talk_Normal = 8,
        Talk_Pleading = 9,
        Talk_Forceful = 10,
        Talk_Laughing = 11,
        Get_Low = 12,
        Get_Mid = 13,
        Pause_Tired = 14,
        Pause_Drunk = 15,
        Dead_Front = 16,
        Dead_Back = 17,
        Conjure1 = 18,
        Conjure2 = 19,
        Spasm = 20,
        Custom1 = 21,
        Custom2 = 22,
        Custom3 = 23,
        Custom4 = 24,
        Custom5 = 25,
        Custom6 = 26,
        Custom7 = 27,
        Custom8 = 28,
        Custom9 = 29,
        Custom10 = 30,
        Custom11 = 31,
        Custom12 = 32,
        Custom13 = 33,
        Custom14 = 34,
        Custom15 = 35,
        Custom16 = 36,
        Custom17 = 37,
        Custom18 = 38,
        Custom19 = 39,
        Custom20 = 40,
        Mount1 = 41,
        Dismount1 = 42,
        FireForget_Head_Turn_Left = 100,
        FireForget_Head_Turn_Right = 101,
        FireForget_Pause_Scratch_Head = 102,
        FireForget_Pause_Bored = 103,
        FireForget_Salute = 104,
        FireForget_Bow = 105,
        FireForget_Steal = 106,
        FireForget_Greeting = 107,
        FireForget_Taunt = 108,
        FireForget_Victory1 = 109,
        FireForget_Victory2 = 110,
        FireForget_Victory3 = 111,
        FireForget_Read = 112,
        FireForget_Drink = 113,
        FireForget_Dodge_Side = 114,
        FireForget_Dodge_Duck = 115,
        FireForget_Spasm = 116,
        PlaceableActivate = 200,
        PlaceableDeactivate = 201,
        PlaceableOpen = 202,
        PlaceableClose = 203,
        DoorClose = 204,
        DoorOpen1 = 205,
        DoorOpen2 = 206,
        DoorDestroy = 207
    }

    public enum DoorAction
    {
        Open = 0,
        Unlock = 1,
        Bash = 2,
        Ignore = 3,
        Knock = 4
    }

    public enum AreaDimension
    {
        Height,
        Width
    }

    public enum AreaNatural
    {
        Artificial,
        Natural
    }

    public enum CameraTransitionType
    {
        Snap = 0,
        Crawl = 2,
        VerySlow = 5,
        Slow = 20,
        Medium = 40,
        Fast = 70,
        VeryFast = 100
    }

    public enum MissChanceType
    {
        Normal,
        Ranged,
        Melee
    }

    public enum ItemVisual
    {
        ACID,
        COLD,
        ELECTRICAL,
        FIRE,
        SONIC,
        HOLY,
        EVIL
    }

    public enum AreaAboveGround
    {
        UnderGround,
        AboveGround
    }

    public enum Faction
    {
        Hostile,
        Commoner,
        Merchant,
        Defender
    }

    public enum ActionMode
    {
        Detect = 0,
        Stealth = 1,
        Parry = 2,
        PowerAttack = 3,
        ImprovedPowerAttack = 4,
        CounterSpell = 5,
        FlurryOfBlows = 6,
        RapidShot = 7,
        Expertise = 8,
        ImprovedExpertise = 9,
        DefensiveCast = 10,
        DirtyFighting = 11
    }

    public enum TrapBaseType
    {
        MinorSpike = 0,
        AverageSpike = 1,
        StrongSpike = 2,
        DeadlySpike = 3,
        MinorHoly = 4,
        AverageHoly = 5,
        StrongHoly = 6,
        DeadlyHoly = 7,
        MinorTangle = 8,
        AverageTangle = 9,
        StrongTangle = 10,
        DeadlyTangle = 11,
        MinorAcid = 12,
        AverageAcid = 13,
        StrongAcid = 14,
        DeadlyAcid = 15,
        MinorFire = 16,
        AverageFire = 17,
        StrongFire = 18,
        DeadlyFire = 19,
        MinorElectrical = 20,
        AverageElectrical = 21,
        StrongElectrical = 22,
        DeadlyElectrical = 23,
        MinorGas = 24,
        AverageGas = 25,
        StrongGas = 26,
        DeadlyGas = 27,
        MinorFrost = 28,
        AverageFrost = 29,
        StrongFrost = 30,
        DeadlyFrost = 31,
        MinorNegative = 32,
        AverageNegative = 33,
        StrongNegative = 34,
        DeadlyNegative = 35,
        MinorSonic = 36,
        AverageSonic = 37,
        StrongSonic = 38,
        DeadlySonic = 39,
        MinorAcidSplash = 40,
        AverageAcidSplash = 41,
        StrongAcidSplash = 42,
        DeadlyAcidSplash = 43,
        EpicElectrical = 44,
        EpicFire = 45,
        EpicFrost = 46,
        EpicSonic = 47,
    }

    public enum ItemApprArmorColor
    {
        Leather1 = 0,
        Leather2 = 1,
        Cloth1 = 2,
        Cloth2 = 3,
        Metal1 = 4,
        Metal2 = 5
    }

    public enum ItemApprArmorModel
    {
        RightFoot = 0,
        LeftFoot = 1,
        RightShin = 2,
        LeftShin = 3,
        LeftThigh = 4,
        RightThigh = 5,
        Pelvis = 6,
        Torso = 7,
        Belt = 8,
        Neck = 9,
        RightForearm = 10,
        LeftForearm = 11,
        RightBicep = 12,
        LeftBicep = 13,
        RightShoulder = 14,
        LeftShoulder = 15,
        RightHand = 16,
        LeftHand = 17,
        Robe = 18
    }

    public enum CreatureTailType
    {
        None,
        Lizard,
        Bone,
        Devil
    }

    public enum SpellSchool
    {
        General = 0,
        Abjuration = 1,
        Conjuration = 2,
        Divination = 3,
        Enchantment = 4,
        Evocation = 5,
        Illusion = 6,
        Necromancy = 7,
        Transmutation = 8,
    }

    public enum Weather
    {
        Invalid = -1,
        Clear = 0,
        Rain = 1,
        Snow = 2,
        Foggy = 3,
        UseAreaSettings = -1
    }

    public enum CreaturePart
    {
        RightFoot = 0,
        LeftFoot = 1,
        RightShin = 2,
        LeftShin = 3,
        LeftThigh = 4,
        RightThigh = 5,
        Pelvis = 6,
        Torso = 7,
        Belt = 8,
        Neck = 9,
        RightForearm = 10,
        LeftForearm = 11,
        RightBicep = 12,
        LeftBicep = 13,
        RightShoulder = 14,
        LeftShoulder = 15,
        RightHand = 16,
        LeftHand = 17,
        Head = 20,
    }

    public enum CreatureModelType
    {
        None = 0,
        Skin = 1,
        Tattoo = 2,
        Undead = 255
    }

    public enum CreatureWingType
    {
        None = 0,
        Demon = 1,
        Angel = 2,
        Bat = 3,
        Dragon = 4,
        Butterfly = 5,
        Bird = 6,
    }

    public enum TrapType
    {
        Spike = 1,
        Holy,
        Tangle = 3,
        BlobOfAcid = 4,
        Fire = 5,
        Electrical = 6,
        Gas = 7,
        Frost = 8,
        AcidSplash = 9,
        Sonic = 10,
        Negative = 11
    }

    public enum LightBrightness
    {
        Dim = 1,
        Low = 2,
        Normal = 3,
        Bright = 4
    }

    public enum SpellResistanceBonus
    {
        Ten,
        Twelve,
        Fourteen,
        Sixteen,
        Eighteen,
        Twenty,
        TwentyTwo,
        TwentyFour,
        TwentySix,
        TwentyEight,
        Thirty,
        ThirtyTwo
    }

    public enum ContainerWeighted
    {
        TwentyPercent = 1,
        FourtyPercent = 2,
        SixtyPercent = 3,
        EightyPercent = 4,
        HundredPercent = 5
    }



    public enum AlignmentGroup
    {
        All,
        Neutral,
        Lawful,
        Chaotic,
        Good,
        Evil,
    }

    public enum Classes
    {
        Invalid = 255,
        Barbarian = 0,
        Bard = 1,
        Cleric = 2,
        Druid = 3,
        Fighter = 4,
        Monk = 5,
        Paladin = 6,
        Ranger = 7,
        Rogue = 8,
        Sorcerer = 9,
        Wizard = 10,
        Abberation = 11,
        Animal = 12,
        Construct = 13,
        Humanoid = 14,
        Monstrous = 15,
        Elemental = 16,
        Fey = 17,
        Dragon = 18,
        Undead = 19,
        Commoner = 20,
        Beast = 21,
        Giant = 22,
        MagicalBeast = 23,

    }

    public enum AmmoType
    {
        Arrow,
        Bolt,
        Bullet
    }

    public enum UnlimitedAmmo
    {
        Basic = 1,
        OneDSixFire = 2,
        OneDSixCold = 3,
        OneDSixLight = 4,
        Plus1 = 11,
        Plus2 = 12,
        Plus3 = 13,
        Plus4 = 14,
        Plus5 = 15
    }

    public enum FootstepType
    {
        Invalid = -1,
        Normal = 0,
        Large = 1,
        Dragon = 2,
        Soft = 3,
        Hoof = 4,
        HoofLarge = 5,
        Beetle = 6,
        Spider = 7,
        Skeleton = 8,
        LeatherWing = 9,
        FeatherWing = 10,
        None = 12,
        Seagull = 13,
        Shark = 14,
        WaterNormal = 15,
        WaterLarge = 16,
        Horse = 17,
        Default = 65535,
    }

    public enum FogType
    {
        All,
        Sun,
        Moon
    }

    public enum FogColor
    {
        Red = 16711680,
        RedDark = 6684672,
        Green = 65280,
        GreenDark = 23112,
        Blue = 255,
        BlueDark = 102,
        Black = 0,
        White = 16777215,
        Grey = 10066329,
        Yellow = 16776960,
        YellowDark = 11184640,
        Cyan = 65535,
        Magenta = 16711935,
        Orange = 16750848,
        OrangeDark = 13395456,
        Brown = 10053120,
        BrownDark = 6697728
    }

    public enum PhenoType
    {
        Normal,
        Large,
        Big,
        Custom1,
        Custom2,
        Custom3,
        Custom4,
        Custom5,
        Custom6,
        Custom7,
        Custom8,
        Custom9,
        Custom10,
        Custom11,
        Custom12,
        Custom13,
        Custom14,
        Custom15,
        Custom16,
        Custom17,
        Custom18
    }

    public enum Skybox
    {
        None,
        GrassClear,
        GrassStorm,
        DesertClear,
        WinterClear,
        Icy
    }

    public enum ColorChannel
    {
        Skin,
        Hair,
        Tattoo1,
        Tattoo2
    }

    public enum ObjectVisualTransform
    {
        Scale = 10,
        RotateX = 21,
        RotateY = 22,
        RotateZ = 23,
        TranslateX = 31,
        TranslateY = 32,
        TranslateZ = 33,
        AnimationSpeed = 40
    }

    public enum GuiPanel
    {
        PlayerDeath = 0
    }

    public enum AssociateType
    {
        None = 0,
        Henchman = 1,
        AnimalCompanion = 2,
        Familiar = 3,
        Summoned = 4,
        Dominated = 5,
    }

    public enum TalentCategory
    {
        Harmful_Areaeffect_Discriminant = 1,
        Harmful_Ranged = 2,
        Harmful_Touch = 3,
        Beneficial_Healing_Areaeffect = 4,
        Beneficial_Healing_Touch = 5,
        Beneficial_Conditional_Areaeffect = 6,
        Beneficial_Conditional_Single = 7,
        Beneficial_Enhancement_Areaeffect = 8,
        Beneficial_Enhancement_Single = 9,
        Beneficial_Enhancement_Self = 10,
        Harmful_Areaeffect_Indiscriminant = 11,
        Beneficial_Protection_Self = 12,
        Beneficial_Protection_Single = 13,
        Beneficial_Protection_Areaeffect = 14,
        Beneficial_Obtain_Allies = 15,
        Persistent_Area_Of_Effect = 16,
        Beneficial_Healing_Potion = 17,
        Beneficial_Conditional_Potion = 18,
        Dragons_Breath = 19,
        Beneficial_Protection_Potion = 20,
        Beneficial_Enhancement_Potion = 21,
        Harmful_Melee = 22,
    }

    public enum EncounterDifficulty
    {
        VeryEasy = 0,
        Easy = 1,
        Normal = 2,
        Hard = 3,
        Impossible = 4
    }

    public enum SubSkill
    {
        None = 0,
        FlagTrap = 100,
        RecoverTrap = 101,
        ExamineTrap = 102,
    }

    public enum Disease
    {
        Blinding_Sickness = 0,
        Cackle_Fever = 1,
        Devil_Chills = 2,
        Demon_Fever = 3,
        Filth_Fever = 4,
        Mindfire = 5,
        Mummy_Rot = 6,
        Red_Ache = 7,
        Shakes = 8,
        Slimy_Doom = 9,
        Red_Slaad_Eggs = 10,
        Ghoul_Rot = 11,
        Zombie_Creep = 12,
        Dread_Blisters = 13,
        Burrow_Maggots = 14,
        Soldier_Shakes = 15,
        Vermin_Madness = 16,
    }

    public enum ProjectilePathType
    {
        Default,
        Homing,
        Ballistic,
        HighBallistic,
        Accelerating
    }

    public enum DamagePower
    {
        Normal,
        PlusOne,
        PlusTwo,
        PlusThree,
        PlusFour,
        PlusFive,
        Energy,
        PlusSix,
        PlusSeven,
        PlusEight,
        PlusNine,
        PlusTen,
        PlusEleven,
        PlusTwelve,
        PlusThirteen,
        PlusFourteen,
        PlusFifteen,
        PlusSixteen,
        PlusSeventeen,
        PlusEighteen,
        PlusNineteen,
        PlusTwenty
    }

    public enum AttackBonus
    {
        Misc,
        OnHand,
        OffHand
    }

    public enum Shape
    {
        SpellCylinder,
        Cone,
        Cube,
        SpellCone,
        Sphere
    }

    public enum AreaTransition
    {
        Random = 0,
        User_Defined = 1,
        City_01 = 2,
        City_02 = 3,
        City_03 = 4,
        City_04 = 5,
        City_05 = 6,
        Crypt_01 = 7,
        Crypt_02 = 8,
        Crypt_03 = 9,
        Crypt_04 = 10,
        Crypt_05 = 11,
        Dungeon_01 = 12,
        Dungeon_02 = 13,
        Dungeon_03 = 14,
        Dungeon_04 = 15,
        Dungeon_05 = 16,
        Dungeon_06 = 17,
        Dungeon_07 = 18,
        Dungeon_08 = 19,
        Mines_01 = 20,
        Mines_02 = 21,
        Mines_03 = 22,
        Mines_04 = 23,
        Mines_05 = 24,
        Mines_06 = 25,
        Mines_07 = 26,
        Mines_08 = 27,
        Mines_09 = 28,
        Sewer_01 = 29,
        Sewer_02 = 30,
        Sewer_03 = 31,
        Sewer_04 = 32,
        Sewer_05 = 33,
        Castle_01 = 34,
        Castle_02 = 35,
        Castle_03 = 36,
        Castle_04 = 37,
        Castle_05 = 38,
        Castle_06 = 39,
        Castle_07 = 40,
        Castle_08 = 41,
        Interior_01 = 42,
        Interior_02 = 43,
        Interior_03 = 44,
        Interior_04 = 45,
        Interior_05 = 46,
        Interior_06 = 47,
        Interior_07 = 48,
        Interior_08 = 49,
        Interior_09 = 50,
        Interior_10 = 51,
        Interior_11 = 52,
        Interior_12 = 53,
        Interior_13 = 54,
        Interior_14 = 55,
        Interior_15 = 56,
        Interior_16 = 57,
        Forest_01 = 58,
        Forest_02 = 59,
        Forest_03 = 60,
        Forest_04 = 61,
        Forest_05 = 62,
        Rural_01 = 63,
        Rural_02 = 64,
        Rural_03 = 65,
        Rural_04 = 66,
        Rural_05 = 67,
        Wrural_01 = 68,
        Wrural_02 = 69,
        Wrural_03 = 70,
        Wrural_04 = 71,
        Wrural_05 = 72,
        Desert_01 = 73,
        Desert_02 = 74,
        Desert_03 = 75,
        Desert_04 = 76,
        Desert_05 = 77,
        Ruins_01 = 78,
        Ruins_02 = 79,
        Ruins_03 = 80,
        Ruins_04 = 81,
        Ruins_05 = 82,
        Caravan_Winter = 83,
        Caravan_Desert = 84,
        Caravan_Rural = 85,
        Magical_01 = 86,
        Magical_02 = 87,
        Underdark_01 = 88,
        Underdark_02 = 89,
        Underdark_03 = 90,
        Underdark_04 = 91,
        Underdark_05 = 92,
        Underdark_06 = 93,
        Underdark_07 = 94,
        Beholder_01 = 95,
        Beholder_02 = 96,
        Drow_01 = 97,
        Drow_02 = 98,
        Illithid_01 = 99,
        Illithid_02 = 100,
        Wasteland_01 = 101,
        Wasteland_02 = 102,
        Wasteland_03 = 103,
        Drow_03 = 104,
        Drow_04 = 105,
        City = 2,
        Crypt = 7,
        Forest = 58,
        Rural = 63,
    }

    public enum DurationType
    {
        Invalid = -1,
        Instant = 0,
        Temporary = 1,
        Permanent = 2
    }

    public enum TalentType
    {
        Spell,
        Feat,
        Skill
    }

    public enum DisturbType
    {
        Added,
        Removed,
        Stolen
    }
}
