using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        ///  <summary>
        ///  adds an item property to the specified item
        ///  Only temporary and permanent duration types are allowed.
        /// </summary>
        public static void AddItemProperty(DurationType nDurationType, NWN.ItemProperty ipProperty, uint oItem, float fDuration = 0.0f)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fDuration);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.StackPushItemProperty(ipProperty.Handle);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDurationType);
            NWN.Internal.NativeFunctions.CallBuiltIn(609);
        }

        /// <summary>
        ///  removes an item property from the specified item
        /// </summary>
        public static void RemoveItemProperty(uint oItem, NWN.ItemProperty ipProperty)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(ipProperty.Handle);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(610);
        }

        /// <summary>
        ///  if the item property is valid this will return true
        /// </summary>
        public static int GetIsItemPropertyValid(NWN.ItemProperty ipProperty)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(ipProperty.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(611);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Gets the first item property on an item
        /// </summary>
        public static NWN.ItemProperty GetFirstItemProperty(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(612);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Will keep retrieving the next and the next item property on an Item,
        ///  will return an invalid item property when the list is empty.
        /// </summary>
        public static NWN.ItemProperty GetNextItemProperty(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(613);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  will return the item property type (ie. holy avenger)
        /// </summary>
        public static int GetItemPropertyType(NWN.ItemProperty ip)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(ip.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(614);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  will return the duration type of the item property
        /// </summary>
        public static int GetItemPropertyDurationType(NWN.ItemProperty ip)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(ip.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(615);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns Item property ability bonus.  You need to specify an
        ///  ability constant(IP_CONST_ABILITY_*) and the bonus.  The bonus should
        ///  be a positive integer between 1 and 12.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAbilityBonus(ItemPropertyAbility nAbility, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAbility);
            NWN.Internal.NativeFunctions.CallBuiltIn(616);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property AC bonus.  You need to specify the bonus.
        ///  The bonus should be a positive integer between 1 and 20. The modifier
        ///  type depends on the item it is being applied to.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyACBonus(int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.CallBuiltIn(617);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property AC bonus vs. alignment group.  An example of
        ///  an alignment group is Chaotic, or Good.  You need to specify the
        ///  alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the AC bonus.
        ///  The AC bonus should be an integer between 1 and 20.  The modifier
        ///  type depends on the item it is being applied to.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyACBonusVsAlign(ItemPropertyAlignmentGroup nAlignGroup, int nACBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nACBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignGroup);
            NWN.Internal.NativeFunctions.CallBuiltIn(618);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property AC bonus vs. Damage type (ie. piercing).  You
        ///  need to specify the damage type constant(IP_CONST_DAMAGETYPE_*) and the
        ///  AC bonus.  The AC bonus should be an integer between 1 and 20.  The
        ///  modifier type depends on the item it is being applied to.
        ///  NOTE: Only the first 3 damage types may be used here, the 3 basic
        ///        physical types.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyACBonusVsDmgType(ItemPropertyDamageType nDamageType, int nACBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nACBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(619);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property AC bonus vs. Racial group.  You need to specify
        ///  the racial group constant(IP_CONST_RACIALTYPE_*) and the AC bonus.  The AC
        ///  bonus should be an integer between 1 and 20.  The modifier type depends
        ///  on the item it is being applied to.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyACBonusVsRace(ItemPropertyRacialType nRace, int nACBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nACBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nRace);
            NWN.Internal.NativeFunctions.CallBuiltIn(620);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property AC bonus vs. Specific alignment.  You need to
        ///  specify the specific alignment constant(IP_CONST_ALIGNMENT_*) and the AC
        ///  bonus.  The AC bonus should be an integer between 1 and 20.  The
        ///  modifier type depends on the item it is being applied to.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyACBonusVsSAlign(ItemPropertyAlignment nAlign, int nACBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nACBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlign);
            NWN.Internal.NativeFunctions.CallBuiltIn(621);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Enhancement bonus.  You need to specify the
        ///  enhancement bonus.  The Enhancement bonus should be an integer between
        ///  1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyEnhancementBonus(int nEnhancementBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nEnhancementBonus);
            NWN.Internal.NativeFunctions.CallBuiltIn(622);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Enhancement bonus vs. an Alignment group.  You
        ///  need to specify the alignment group constant(IP_CONST_ALIGNMENTGROUP_*)
        ///  and the enhancement bonus.  The Enhancement bonus should be an integer
        ///  between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyEnhancementBonusVsAlign(ItemPropertyAlignmentGroup nAlignGroup, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignGroup);
            NWN.Internal.NativeFunctions.CallBuiltIn(623);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Enhancement bonus vs. Racial group.  You need
        ///  to specify the racial group constant(IP_CONST_RACIALTYPE_*) and the
        ///  enhancement bonus.  The enhancement bonus should be an integer between
        ///  1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyEnhancementBonusVsRace(ItemPropertyRacialType nRace, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nRace);
            NWN.Internal.NativeFunctions.CallBuiltIn(624);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Enhancement bonus vs. a specific alignment.  You
        ///  need to specify the alignment constant(IP_CONST_ALIGNMENT_*) and the
        ///  enhancement bonus.  The enhancement bonus should be an integer between
        ///  1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyEnhancementBonusVsSAlign(ItemPropertyAlignment nAlign, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlign);
            NWN.Internal.NativeFunctions.CallBuiltIn(625);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Enhancment penalty.  You need to specify the
        ///  enhancement penalty.  The enhancement penalty should be a POSITIVE
        ///  integer between 1 and 5 (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyEnhancementPenalty(int nPenalty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.CallBuiltIn(626);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property weight reduction.  You need to specify the weight
        ///  reduction constant(IP_CONST_REDUCEDWEIGHT_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyWeightReduction(ItemPropertyReducedWeight nReduction)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nReduction);
            NWN.Internal.NativeFunctions.CallBuiltIn(627);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Bonus Feat.  You need to specify the the feat
        ///  constant(IP_CONST_FEAT_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyBonusFeat(ItemPropertyFeat nFeat)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nFeat);
            NWN.Internal.NativeFunctions.CallBuiltIn(628);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Bonus level spell (Bonus spell of level).  You must
        ///  specify the class constant(IP_CONST_CLASS_*) of the bonus spell(MUST BE a
        ///  spell casting class) and the level of the bonus spell.  The level of the
        ///  bonus spell should be an integer between 0 and 9.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyBonusLevelSpell(ItemPropertyClass nClass, ItemPropertySpellLevel nSpellLevel)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSpellLevel);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nClass);
            NWN.Internal.NativeFunctions.CallBuiltIn(629);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Cast spell.  You must specify the spell constant
        ///  (IP_CONST_CASTSPELL_*) and the number of uses constant(IP_CONST_CASTSPELL_NUMUSES_*).
        ///  NOTE: The number after the name of the spell in the constant is the level
        ///        at which the spell will be cast.  Sometimes there are multiple copies
        ///        of the same spell but they each are cast at a different level.  The higher
        ///        the level, the more cost will be added to the item.
        ///  NOTE: The list of spells that can be applied to an item will depend on the
        ///        item type.  For instance there are spells that can be applied to a wand
        ///        that cannot be applied to a potion.  Below is a list of the types and the
        ///        spells that are allowed to be placed on them.  If you try to put a cast
        ///        spell effect on an item that is not allowed to have that effect it will
        ///        not work.
        ///  NOTE: Even if spells have multiple versions of different levels they are only
        ///        listed below once.
        ///
        ///  WANDS:
        ///           Acid_Splash
        ///           Activate_Item
        ///           Aid
        ///           Amplify
        ///           Animate_Dead
        ///           AuraOfGlory
        ///           BalagarnsIronHorn
        ///           Bane
        ///           Banishment
        ///           Barkskin
        ///           Bestow_Curse
        ///           Bigbys_Clenched_Fist
        ///           Bigbys_Crushing_Hand
        ///           Bigbys_Forceful_Hand
        ///           Bigbys_Grasping_Hand
        ///           Bigbys_Interposing_Hand
        ///           Bless
        ///           Bless_Weapon
        ///           Blindness/Deafness
        ///           Blood_Frenzy
        ///           Bombardment
        ///           Bulls_Strength
        ///           Burning_Hands
        ///           Call_Lightning
        ///           Camoflage
        ///           Cats_Grace
        ///           Charm_Monster
        ///           Charm_Person
        ///           Charm_Person_or_Animal
        ///           Clairaudience/Clairvoyance
        ///           Clarity
        ///           Color_Spray
        ///           Confusion
        ///           Continual_Flame
        ///           Cure_Critical_Wounds
        ///           Cure_Light_Wounds
        ///           Cure_Minor_Wounds
        ///           Cure_Moderate_Wounds
        ///           Cure_Serious_Wounds
        ///           Darkness
        ///           Darkvision
        ///           Daze
        ///           Death_Ward
        ///           Dirge
        ///           Dismissal
        ///           Dispel_Magic
        ///           Displacement
        ///           Divine_Favor
        ///           Divine_Might
        ///           Divine_Power
        ///           Divine_Shield
        ///           Dominate_Animal
        ///           Dominate_Person
        ///           Doom
        ///           Dragon_Breath_Acid
        ///           Dragon_Breath_Cold
        ///           Dragon_Breath_Fear
        ///           Dragon_Breath_Fire
        ///           Dragon_Breath_Gas
        ///           Dragon_Breath_Lightning
        ///           Dragon_Breath_Paralyze
        ///           Dragon_Breath_Sleep
        ///           Dragon_Breath_Slow
        ///           Dragon_Breath_Weaken
        ///           Drown
        ///           Eagle_Spledor
        ///           Earthquake
        ///           Electric_Jolt
        ///           Elemental_Shield
        ///           Endurance
        ///           Endure_Elements
        ///           Enervation
        ///           Entangle
        ///           Entropic_Shield
        ///           Etherealness
        ///           Expeditious_Retreat
        ///           Fear
        ///           Find_Traps
        ///           Fireball
        ///           Firebrand
        ///           Flame_Arrow
        ///           Flame_Lash
        ///           Flame_Strike
        ///           Flare
        ///           Foxs_Cunning
        ///           Freedom_of_Movement
        ///           Ghostly_Visage
        ///           Ghoul_Touch
        ///           Grease
        ///           Greater_Magic_Fang
        ///           Greater_Magic_Weapon
        ///           Grenade_Acid
        ///           Grenade_Caltrops
        ///           Grenade_Chicken
        ///           Grenade_Choking
        ///           Grenade_Fire
        ///           Grenade_Holy
        ///           Grenade_Tangle
        ///           Grenade_Thunderstone
        ///           Gust_of_wind
        ///           Hammer_of_the_Gods
        ///           Haste
        ///           Hold_Animal
        ///           Hold_Monster
        ///           Hold_Person
        ///           Ice_Storm
        ///           Identify
        ///           Improved_Invisibility
        ///           Inferno
        ///           Inflict_Critical_Wounds
        ///           Inflict_Light_Wounds
        ///           Inflict_Minor_Wounds
        ///           Inflict_Moderate_Wounds
        ///           Inflict_Serious_Wounds
        ///           Invisibility
        ///           Invisibility_Purge
        ///           Invisibility_Sphere
        ///           Isaacs_Greater_Missile_Storm
        ///           Isaacs_Lesser_Missile_Storm
        ///           Knock
        ///           Lesser_Dispel
        ///           Lesser_Restoration
        ///           Lesser_Spell_Breach
        ///           Light
        ///           Lightning_Bolt
        ///           Mage_Armor
        ///           Magic_Circle_against_Alignment
        ///           Magic_Fang
        ///           Magic_Missile
        ///           Manipulate_Portal_Stone
        ///           Mass_Camoflage
        ///           Melfs_Acid_Arrow
        ///           Meteor_Swarm
        ///           Mind_Blank
        ///           Mind_Fog
        ///           Negative_Energy_Burst
        ///           Negative_Energy_Protection
        ///           Negative_Energy_Ray
        ///           Neutralize_Poison
        ///           One_With_The_Land
        ///           Owls_Insight
        ///           Owls_Wisdom
        ///           Phantasmal_Killer
        ///           Planar_Ally
        ///           Poison
        ///           Polymorph_Self
        ///           Prayer
        ///           Protection_from_Alignment
        ///           Protection_From_Elements
        ///           Quillfire
        ///           Ray_of_Enfeeblement
        ///           Ray_of_Frost
        ///           Remove_Blindness/Deafness
        ///           Remove_Curse
        ///           Remove_Disease
        ///           Remove_Fear
        ///           Remove_Paralysis
        ///           Resist_Elements
        ///           Resistance
        ///           Restoration
        ///           Sanctuary
        ///           Scare
        ///           Searing_Light
        ///           See_Invisibility
        ///           Shadow_Conjuration
        ///           Shield
        ///           Shield_of_Faith
        ///           Silence
        ///           Sleep
        ///           Slow
        ///           Sound_Burst
        ///           Spike_Growth
        ///           Stinking_Cloud
        ///           Stoneskin
        ///           Summon_Creature_I
        ///           Summon_Creature_I
        ///           Summon_Creature_II
        ///           Summon_Creature_III
        ///           Summon_Creature_IV
        ///           Sunburst
        ///           Tashas_Hideous_Laughter
        ///           True_Strike
        ///           Undeaths_Eternal_Foe
        ///           Unique_Power
        ///           Unique_Power_Self_Only
        ///           Vampiric_Touch
        ///           Virtue
        ///           Wall_of_Fire
        ///           Web
        ///           Wounding_Whispers
        ///
        ///  POTIONS:
        ///           Activate_Item
        ///           Aid
        ///           Amplify
        ///           AuraOfGlory
        ///           Bane
        ///           Barkskin
        ///           Barkskin
        ///           Barkskin
        ///           Bless
        ///           Bless_Weapon
        ///           Bless_Weapon
        ///           Blood_Frenzy
        ///           Bulls_Strength
        ///           Bulls_Strength
        ///           Bulls_Strength
        ///           Camoflage
        ///           Cats_Grace
        ///           Cats_Grace
        ///           Cats_Grace
        ///           Clairaudience/Clairvoyance
        ///           Clairaudience/Clairvoyance
        ///           Clairaudience/Clairvoyance
        ///           Clarity
        ///           Continual_Flame
        ///           Cure_Critical_Wounds
        ///           Cure_Critical_Wounds
        ///           Cure_Critical_Wounds
        ///           Cure_Light_Wounds
        ///           Cure_Light_Wounds
        ///           Cure_Minor_Wounds
        ///           Cure_Moderate_Wounds
        ///           Cure_Moderate_Wounds
        ///           Cure_Moderate_Wounds
        ///           Cure_Serious_Wounds
        ///           Cure_Serious_Wounds
        ///           Cure_Serious_Wounds
        ///           Darkness
        ///           Darkvision
        ///           Darkvision
        ///           Death_Ward
        ///           Dispel_Magic
        ///           Dispel_Magic
        ///           Displacement
        ///           Divine_Favor
        ///           Divine_Might
        ///           Divine_Power
        ///           Divine_Shield
        ///           Dragon_Breath_Acid
        ///           Dragon_Breath_Cold
        ///           Dragon_Breath_Fear
        ///           Dragon_Breath_Fire
        ///           Dragon_Breath_Gas
        ///           Dragon_Breath_Lightning
        ///           Dragon_Breath_Paralyze
        ///           Dragon_Breath_Sleep
        ///           Dragon_Breath_Slow
        ///           Dragon_Breath_Weaken
        ///           Eagle_Spledor
        ///           Eagle_Spledor
        ///           Eagle_Spledor
        ///           Elemental_Shield
        ///           Elemental_Shield
        ///           Endurance
        ///           Endurance
        ///           Endurance
        ///           Endure_Elements
        ///           Entropic_Shield
        ///           Ethereal_Visage
        ///           Ethereal_Visage
        ///           Etherealness
        ///           Expeditious_Retreat
        ///           Find_Traps
        ///           Foxs_Cunning
        ///           Foxs_Cunning
        ///           Foxs_Cunning
        ///           Freedom_of_Movement
        ///           Ghostly_Visage
        ///           Ghostly_Visage
        ///           Ghostly_Visage
        ///           Globe_of_Invulnerability
        ///           Greater_Bulls_Strength
        ///           Greater_Cats_Grace
        ///           Greater_Dispelling
        ///           Greater_Dispelling
        ///           Greater_Eagles_Splendor
        ///           Greater_Endurance
        ///           Greater_Foxs_Cunning
        ///           Greater_Magic_Weapon
        ///           Greater_Owls_Wisdom
        ///           Greater_Restoration
        ///           Greater_Spell_Mantle
        ///           Greater_Stoneskin
        ///           Grenade_Acid
        ///           Grenade_Caltrops
        ///           Grenade_Chicken
        ///           Grenade_Choking
        ///           Grenade_Fire
        ///           Grenade_Holy
        ///           Grenade_Tangle
        ///           Grenade_Thunderstone
        ///           Haste
        ///           Haste
        ///           Heal
        ///           Hold_Animal
        ///           Hold_Monster
        ///           Hold_Person
        ///           Identify
        ///           Invisibility
        ///           Lesser_Dispel
        ///           Lesser_Dispel
        ///           Lesser_Mind_Blank
        ///           Lesser_Restoration
        ///           Lesser_Spell_Mantle
        ///           Light
        ///           Light
        ///           Mage_Armor
        ///           Manipulate_Portal_Stone
        ///           Mass_Camoflage
        ///           Mind_Blank
        ///           Minor_Globe_of_Invulnerability
        ///           Minor_Globe_of_Invulnerability
        ///           Mordenkainens_Disjunction
        ///           Negative_Energy_Protection
        ///           Negative_Energy_Protection
        ///           Negative_Energy_Protection
        ///           Neutralize_Poison
        ///           One_With_The_Land
        ///           Owls_Insight
        ///           Owls_Wisdom
        ///           Owls_Wisdom
        ///           Owls_Wisdom
        ///           Polymorph_Self
        ///           Prayer
        ///           Premonition
        ///           Protection_From_Elements
        ///           Protection_From_Elements
        ///           Protection_from_Spells
        ///           Protection_from_Spells
        ///           Raise_Dead
        ///           Remove_Blindness/Deafness
        ///           Remove_Curse
        ///           Remove_Disease
        ///           Remove_Fear
        ///           Remove_Paralysis
        ///           Resist_Elements
        ///           Resist_Elements
        ///           Resistance
        ///           Resistance
        ///           Restoration
        ///           Resurrection
        ///           Rogues_Cunning
        ///           See_Invisibility
        ///           Shadow_Shield
        ///           Shapechange
        ///           Shield
        ///           Shield_of_Faith
        ///           Special_Alcohol_Beer
        ///           Special_Alcohol_Spirits
        ///           Special_Alcohol_Wine
        ///           Special_Herb_Belladonna
        ///           Special_Herb_Garlic
        ///           Spell_Mantle
        ///           Spell_Resistance
        ///           Spell_Resistance
        ///           Stoneskin
        ///           Tensers_Transformation
        ///           True_Seeing
        ///           True_Strike
        ///           Unique_Power
        ///           Unique_Power_Self_Only
        ///           Virtue
        ///
        ///  GENERAL USE (ie. everything else):
        ///           Just about every spell is useable by all the general use items so instead we
        ///           will only list the ones that are not allowed:
        ///           Special_Alcohol_Beer
        ///           Special_Alcohol_Spirits
        ///           Special_Alcohol_Wine
        ///
        /// </summary>
        public static NWN.ItemProperty ItemPropertyCastSpell(ItemPropertyCastSpell nSpell, ItemPropertyCastSpellNumUses nNumUses)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nNumUses);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSpell);
            NWN.Internal.NativeFunctions.CallBuiltIn(630);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage bonus.  You must specify the damage type constant
        ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageBonus(ItemPropertyDamageType nDamageType, ItemPropertyDamageBonus nDamage)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamage);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(631);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage bonus vs. Alignment groups.  You must specify the
        ///  alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the damage type constant
        ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageBonusVsAlign(ItemPropertyAlignmentGroup nAlignGroup, ItemPropertyDamageType nDamageType, ItemPropertyDamageBonus nDamage)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamage);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignGroup);
            NWN.Internal.NativeFunctions.CallBuiltIn(632);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage bonus vs. specific race.  You must specify the
        ///  racial group constant(IP_CONST_RACIALTYPE_*) and the damage type constant
        ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageBonusVsRace(ItemPropertyRacialType nRace, ItemPropertyDamageType nDamageType, ItemPropertyDamageBonus nDamage)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamage);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nRace);
            NWN.Internal.NativeFunctions.CallBuiltIn(633);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage bonus vs. specific alignment.  You must specify the
        ///  specific alignment constant(IP_CONST_ALIGNMENT_*) and the damage type constant
        ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageBonusVsSAlign(ItemPropertyAlignment nAlign, ItemPropertyDamageType nDamageType, ItemPropertyDamageBonus nDamage)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamage);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlign);
            NWN.Internal.NativeFunctions.CallBuiltIn(634);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage immunity.  You must specify the damage type constant
        ///  (IP_CONST_DAMAGETYPE_*) that you want to be immune to and the immune bonus percentage
        ///  constant(IP_CONST_DAMAGEIMMUNITY_*).
        ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageImmunity(ItemPropertyDamageType nDamageType, ItemPropertyDamageImmunity nImmuneBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nImmuneBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(635);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage penalty.  You must specify the damage penalty.
        ///  The damage penalty should be a uint, 1 - 5 only.
        ///  will reduce any value < 5 to 5.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamagePenalty(uint nPenalty)
        {
            if (nPenalty > 5) nPenalty = 5;
            NWN.Internal.NativeFunctions.StackPushInteger((int)nPenalty);
            NWN.Internal.NativeFunctions.CallBuiltIn(636);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage reduction.  You must specify the enhancment level
        ///  (IP_CONST_DAMAGEREDUCTION_*) that is required to get past the damage reduction
        ///  and the amount of HP of damage constant(IP_CONST_DAMAGESOAK_*) will be soaked
        ///  up if your weapon is not of high enough enhancement.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageReduction(ItemPropertyDamageReduction nEnhancement, ItemPropertyDamageSoak nHPSoak)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nHPSoak);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nEnhancement);
            NWN.Internal.NativeFunctions.CallBuiltIn(637);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage resistance.  You must specify the damage type
        ///  constant(IP_CONST_DAMAGETYPE_*) and the amount of HP of damage constant
        ///  (IP_CONST_DAMAGERESIST_*) that will be resisted against each round.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageResistance(ItemPropertyDamageType nDamageType, ItemPropertyDamageResist nHPResist)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nHPResist);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(638);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property damage vulnerability.  You must specify the damage type
        ///  constant(IP_CONST_DAMAGETYPE_*) that you want the user to be extra vulnerable to
        ///  and the percentage vulnerability constant(IP_CONST_DAMAGEVULNERABILITY_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDamageVulnerability(ItemPropertyDamageType nDamageType, ItemPropertyDamageVulnerability nVulnerability)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nVulnerability);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(639);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Return Item property Darkvision.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDarkvision()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(640);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Return Item property decrease ability score.  You must specify the ability
        ///  constant(IP_CONST_ABILITY_*) and the modifier constant.  The modifier must be
        ///  a POSITIVE integer between 1 and 10 (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDecreaseAbility(ItemPropertyAbility nAbility, int nModifier)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifier);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAbility);
            NWN.Internal.NativeFunctions.CallBuiltIn(641);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property decrease Armor Class.  You must specify the armor
        ///  modifier type constant(IP_CONST_ACMODIFIERTYPE_*) and the armor class penalty.
        ///  The penalty must be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDecreaseAC(ItemPropertyAcModifierType nModifierType, int nPenalty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nModifierType);
            NWN.Internal.NativeFunctions.CallBuiltIn(642);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property decrease skill.  You must specify the constant for the
        ///  skill to be decreased(SKILL_*) and the amount of the penalty.  The penalty
        ///  must be a POSITIVE integer between 1 and 10 (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyDecreaseSkill(Skill nSkill, int nPenalty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSkill);
            NWN.Internal.NativeFunctions.CallBuiltIn(643);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property container reduced weight.  This is used for special
        ///  containers that reduce the weight of the objects inside them.  You must
        ///  specify the container weight reduction type constant(IP_CONST_CONTAINERWEIGHTRED_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyContainerReducedWeight(ItemPropertyContainerWeightRed nContainerType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nContainerType);
            NWN.Internal.NativeFunctions.CallBuiltIn(644);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property extra melee damage type.  You must specify the extra
        ///  melee base damage type that you want applied.  It is a constant(IP_CONST_DAMAGETYPE_*).
        ///  NOTE: only the first 3 base types (piercing, slashing, & bludgeoning are applicable
        ///        here.
        ///  NOTE: It is also only applicable to melee weapons.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyExtraMeleeDamageType(ItemPropertyDamageType nDamageType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(645);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property extra ranged damage type.  You must specify the extra
        ///  melee base damage type that you want applied.  It is a constant(IP_CONST_DAMAGETYPE_*).
        ///  NOTE: only the first 3 base types (piercing, slashing, & bludgeoning are applicable
        ///        here.
        ///  NOTE: It is also only applicable to ranged weapons.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyExtraRangeDamageType(ItemPropertyDamageType nDamageType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(646);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property haste.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyHaste()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(647);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Holy Avenger.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyHolyAvenger()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(648);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property immunity to miscellaneous effects.  You must specify the
        ///  effect to which the user is immune, it is a constant(IP_CONST_IMMUNITYMISC_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyImmunityMisc(ItemPropertyImmunityMisc nImmunityType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nImmunityType);
            NWN.Internal.NativeFunctions.CallBuiltIn(649);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property improved evasion.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyImprovedEvasion()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(650);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property bonus spell resistance.  You must specify the bonus spell
        ///  resistance constant(IP_CONST_SPELLRESISTANCEBONUS_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyBonusSpellResistance(ItemPropertySpellResistanceBonus nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBonus);
            NWN.Internal.NativeFunctions.CallBuiltIn(651);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property saving throw bonus vs. a specific effect or damage type.
        ///  You must specify the save type constant(IP_CONST_SAVEVS_*) that the bonus is
        ///  applied to and the bonus that is be applied.  The bonus must be an integer
        ///  between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyBonusSavingThrowVsX(ItemPropertySaveVs nBonusType, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBonusType);
            NWN.Internal.NativeFunctions.CallBuiltIn(652);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property saving throw bonus to the base type (ie. will, reflex,
        ///  fortitude).  You must specify the base type constant(IP_CONST_SAVEBASETYPE_*)
        ///  to which the user gets the bonus and the bonus that he/she will get.  The
        ///  bonus must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyBonusSavingThrow(ItemPropertySaveBaseType nBaseSaveType, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBaseSaveType);
            NWN.Internal.NativeFunctions.CallBuiltIn(653);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property keen.  This means a critical threat range of 19-20 on a
        ///  weapon will be increased to 17-20 etc.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyKeen()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(654);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property light.  You must specify the intesity constant of the
        ///  light(IP_CONST_LIGHTBRIGHTNESS_*) and the color constant of the light
        ///  (IP_CONST_LIGHTCOLOR_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyLight(ItemPropertyLightBrightness nBrightness, ItemPropertyLightColor nColor)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nColor);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBrightness);
            NWN.Internal.NativeFunctions.CallBuiltIn(655);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Max range strength modification (ie. mighty).  You must
        ///  specify the maximum modifier for strength that is allowed on a ranged weapon.
        ///  The modifier must be a positive integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyMaxRangeStrengthMod(int nModifier)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifier);
            NWN.Internal.NativeFunctions.CallBuiltIn(656);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property no damage.  This means the weapon will do no damage in
        ///  combat.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyNoDamage()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(657);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property on hit -> do effect property.  You must specify the on
        ///  hit property constant(IP_CONST_ONHIT_*) and the save DC constant(IP_CONST_ONHIT_SAVEDC_*).
        ///  Some of the item properties require a special parameter as well.  If the
        ///  property does not require one you may leave out the last one.  The list of
        ///  the ones with 3 parameters and what they are are as follows:
        ///       ABILITYDRAIN      :nSpecial is the ability it is to drain.
        ///                          constant(IP_CONST_ABILITY_*)
        ///       BLINDNESS         :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       CONFUSION         :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       DAZE              :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       DEAFNESS          :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       DISEASE           :nSpecial is the type of desease that will effect the victim.
        ///                          constant(DISEASE_*)
        ///       DOOM              :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       FEAR              :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       HOLD              :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       ITEMPOISON        :nSpecial is the type of poison that will effect the victim.
        ///                          constant(IP_CONST_POISON_*)
        ///       SILENCE           :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       SLAYRACE          :nSpecial is the race that will be slain.
        ///                          constant(IP_CONST_RACIALTYPE_*)
        ///       SLAYALIGNMENTGROUP:nSpecial is the alignment group that will be slain(ie. chaotic).
        ///                          constant(IP_CONST_ALIGNMENTGROUP_*)
        ///       SLAYALIGNMENT     :nSpecial is the specific alignment that will be slain.
        ///                          constant(IP_CONST_ALIGNMENT_*)
        ///       SLEEP             :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       SLOW              :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        ///       STUN              :nSpecial is the duration/percentage of effecting victim.
        ///                          constant(IP_CONST_ONHIT_DURATION_*)
        /// </summary>
        public static NWN.ItemProperty ItemPropertyOnHitProps(int nProperty, int nSaveDC, int nSpecial = 0)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nSpecial);
            NWN.Internal.NativeFunctions.StackPushInteger(nSaveDC);
            NWN.Internal.NativeFunctions.StackPushInteger(nProperty);
            NWN.Internal.NativeFunctions.CallBuiltIn(658);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property reduced saving throw vs. an effect or damage type.  You must
        ///  specify the constant to which the penalty applies(IP_CONST_SAVEVS_*) and the
        ///  penalty to be applied.  The penalty must be a POSITIVE integer between 1 and 20
        ///  (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyReducedSavingThrowVsX(ItemPropertySaveVs nBaseSaveType, int nPenalty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBaseSaveType);
            NWN.Internal.NativeFunctions.CallBuiltIn(659);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property reduced saving to base type.  You must specify the base
        ///  type to which the penalty applies (ie. will, reflex, or fortitude) and the penalty
        ///  to be applied.  The constant for the base type starts with (IP_CONST_SAVEBASETYPE_*).
        ///  The penalty must be a POSITIVE integer between 1 and 20 (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyReducedSavingThrow(ItemPropertySaveBaseType nBonusType, int nPenalty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBonusType);
            NWN.Internal.NativeFunctions.CallBuiltIn(660);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property regeneration.  You must specify the regeneration amount.
        ///  The amount must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyRegeneration(int nRegenAmount)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nRegenAmount);
            NWN.Internal.NativeFunctions.CallBuiltIn(661);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property skill bonus.  You must specify the skill to which the user
        ///  will get a bonus(SKILL_*) and the amount of the bonus.  The bonus amount must
        ///  be an integer between 1 and 50.
        /// </summary>
        public static NWN.ItemProperty ItemPropertySkillBonus(Skill nSkill, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSkill);
            NWN.Internal.NativeFunctions.CallBuiltIn(662);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property spell immunity vs. specific spell.  You must specify the
        ///  spell to which the user will be immune(IP_CONST_IMMUNITYSPELL_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertySpellImmunitySpecific(ItemPropertyImmunitySpell nSpell)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSpell);
            NWN.Internal.NativeFunctions.CallBuiltIn(663);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property spell immunity vs. spell school.  You must specify the
        ///  school to which the user will be immune(IP_CONST_SPELLSCHOOL_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertySpellImmunitySchool(ItemPropertySpellSchool nSchool)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSchool);
            NWN.Internal.NativeFunctions.CallBuiltIn(664);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Thieves tools.  You must specify the modifier you wish
        ///  the tools to have.  The modifier must be an integer between 1 and 12.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyThievesTools(int nModifier)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifier);
            NWN.Internal.NativeFunctions.CallBuiltIn(665);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Attack bonus.  You must specify an attack bonus.  The bonus
        ///  must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAttackBonus(int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.CallBuiltIn(666);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Attack bonus vs. alignment group.  You must specify the
        ///  alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the attack bonus.  The
        ///  bonus must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAttackBonusVsAlign(ItemPropertyAlignmentGroup nAlignGroup, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignGroup);
            NWN.Internal.NativeFunctions.CallBuiltIn(667);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property attack bonus vs. racial group.  You must specify the
        ///  racial group constant(IP_CONST_RACIALTYPE_*) and the attack bonus.  The bonus
        ///  must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAttackBonusVsRace(ItemPropertyRacialType nRace, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nRace);
            NWN.Internal.NativeFunctions.CallBuiltIn(668);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property attack bonus vs. a specific alignment.  You must specify
        ///  the alignment you want the bonus to work against(IP_CONST_ALIGNMENT_*) and the
        ///  attack bonus.  The bonus must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAttackBonusVsSAlign(ItemPropertyAlignment nAlignment, int nBonus)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignment);
            NWN.Internal.NativeFunctions.CallBuiltIn(669);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property attack penalty.  You must specify the attack penalty.
        ///  The penalty must be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAttackPenalty(int nPenalty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.CallBuiltIn(670);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property unlimited ammo.  If you leave the parameter field blank
        ///  it will be just a normal bolt, arrow, or bullet.  However you may specify that
        ///  you want the ammunition to do special damage (ie. +1d6 Fire, or +1 enhancement
        ///  bonus).  For this parmeter you use the constants beginning with:
        ///       (IP_CONST_UNLIMITEDAMMO_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyUnlimitedAmmo(ItemPropertyUnlimited nAmmoDamage = ItemPropertyUnlimited.Basic)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAmmoDamage);
            NWN.Internal.NativeFunctions.CallBuiltIn(671);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property limit use by alignment group.  You must specify the
        ///  alignment group(s) that you want to be able to use this item(IP_CONST_ALIGNMENTGROUP_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyLimitUseByAlign(ItemPropertyAlignmentGroup nAlignGroup)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignGroup);
            NWN.Internal.NativeFunctions.CallBuiltIn(672);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property limit use by class.  You must specify the class(es) who
        ///  are able to use this item(IP_CONST_CLASS_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyLimitUseByClass(ItemPropertyClass nClass)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nClass);
            NWN.Internal.NativeFunctions.CallBuiltIn(673);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property limit use by race.  You must specify the race(s) who are
        ///  allowed to use this item(IP_CONST_RACIALTYPE_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyLimitUseByRace(ItemPropertyRacialType nRace)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nRace);
            NWN.Internal.NativeFunctions.CallBuiltIn(674);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property limit use by specific alignment.  You must specify the
        ///  alignment(s) of those allowed to use the item(IP_CONST_ALIGNMENT_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyLimitUseBySAlign(ItemPropertyAlignment nAlignment)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAlignment);
            NWN.Internal.NativeFunctions.CallBuiltIn(675);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  replace this function it does nothing.
        /// </summary>
        public static NWN.ItemProperty BadBadReplaceMeThisDoesNothing()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(676);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property vampiric regeneration.  You must specify the amount of
        ///  regeneration.  The regen amount must be an integer between 1 and 20.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyVampiricRegeneration(int nRegenAmount)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nRegenAmount);
            NWN.Internal.NativeFunctions.CallBuiltIn(677);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Trap.  You must specify the trap level constant
        ///  (IP_CONST_TRAPSTRENGTH_*) and the trap type constant(IP_CONST_TRAPTYPE_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyTrap(ItemPropertyTrapStrength nTrapLevel, ItemPropertyTrapType nTrapType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nTrapType);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nTrapLevel);
            NWN.Internal.NativeFunctions.CallBuiltIn(678);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property true seeing.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyTrueSeeing()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(679);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Monster on hit apply effect property.  You must specify
        ///  the property that you want applied on hit.  There are some properties that
        ///  require an additional special parameter to be specified.  The others that
        ///  don't require any additional parameter you may just put in the one.  The
        ///  special cases are as follows:
        ///       ABILITYDRAIN:nSpecial is the ability to drain.
        ///                    constant(IP_CONST_ABILITY_*)
        ///       DISEASE     :nSpecial is the disease that you want applied.
        ///                    constant(DISEASE_*)
        ///       LEVELDRAIN  :nSpecial is the number of levels that you want drained.
        ///                    integer between 1 and 5.
        ///       POISON      :nSpecial is the type of poison that will effect the victim.
        ///                    constant(IP_CONST_POISON_*)
        ///       WOUNDING    :nSpecial is the amount of wounding.
        ///                    integer between 1 and 5.
        ///  NOTE: Any that do not appear in the above list do not require the second
        ///        parameter.
        ///  NOTE: These can only be applied to monster NATURAL weapons (ie. bite, claw,
        ///        gore, and slam).  IT WILL NOT WORK ON NORMAL WEAPONS.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyOnMonsterHitProperties(int nProperty, int nSpecial = 0)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nSpecial);
            NWN.Internal.NativeFunctions.StackPushInteger(nProperty);
            NWN.Internal.NativeFunctions.CallBuiltIn(680);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property turn resistance.  You must specify the resistance bonus.
        ///  The bonus must be an integer between 1 and 50.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyTurnResistance(int nModifier)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifier);
            NWN.Internal.NativeFunctions.CallBuiltIn(681);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Massive Critical.  You must specify the extra damage
        ///  constant(IP_CONST_DAMAGEBONUS_*) of the criticals.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyMassiveCritical(ItemPropertyDamageBonus nDamage)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamage);
            NWN.Internal.NativeFunctions.CallBuiltIn(682);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property free action.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyFreeAction()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(683);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property monster damage.  You must specify the amount of damage
        ///  the monster's attack will do(IP_CONST_MONSTERDAMAGE_*).
        ///  NOTE: These can only be applied to monster NATURAL weapons (ie. bite, claw,
        ///        gore, and slam).  IT WILL NOT WORK ON NORMAL WEAPONS.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyMonsterDamage(ItemPropertyMonsterDamage nDamage)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamage);
            NWN.Internal.NativeFunctions.CallBuiltIn(684);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property immunity to spell level.  You must specify the level of
        ///  which that and below the user will be immune.  The level must be an integer
        ///  between 1 and 9.  By putting in a 3 it will mean the user is immune to all
        ///  3rd level and lower spells.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyImmunityToSpellLevel(int nLevel)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nLevel);
            NWN.Internal.NativeFunctions.CallBuiltIn(685);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property special walk.  If no parameters are specified it will
        ///  automatically use the zombie walk.  This will apply the special walk animation
        ///  to the user.
        /// </summary>
        public static NWN.ItemProperty ItemPropertySpecialWalk()
        {
            NWN.Internal.NativeFunctions.StackPushInteger(0);
            NWN.Internal.NativeFunctions.CallBuiltIn(686);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property healers kit.  You must specify the level of the kit.
        ///  The modifier must be an integer between 1 and 12.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyHealersKit(int nModifier)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifier);
            NWN.Internal.NativeFunctions.CallBuiltIn(687);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property weight increase.  You must specify the weight increase
        ///  constant(IP_CONST_WEIGHTINCREASE_*).
        /// </summary>
        public static NWN.ItemProperty ItemPropertyWeightIncrease(ItemPropertyWeightIncrease nWeight)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nWeight);
            NWN.Internal.NativeFunctions.CallBuiltIn(688);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns the string tag set for the provided item property.
        ///  - If no tag has been set, returns an empty string.
        /// </summary>
        public static string GetItemPropertyTag(NWN.ItemProperty nProperty)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(nProperty.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(854);
            return NWN.Internal.NativeFunctions.StackPopStringUTF8();
        }

        /// <summary>
        ///  Returns the Cost Table number of the item property. See the 2DA files for value definitions.
        /// </summary>
        public static int GetItemPropertyCostTable(NWN.ItemProperty iProp)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(iProp.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(769);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns the Cost Table value (index of the cost table) of the item property.
        ///  See the 2DA files for value definitions.
        /// </summary>
        public static int GetItemPropertyCostTableValue(NWN.ItemProperty iProp)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(iProp.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(770);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns the Param1 number of the item property. See the 2DA files for value definitions.
        /// </summary>
        public static int GetItemPropertyParam1(NWN.ItemProperty iProp)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(iProp.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(771);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns the Param1 value of the item property. See the 2DA files for value definitions.
        /// </summary>
        public static int GetItemPropertyParam1Value(NWN.ItemProperty iProp)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(iProp.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(772);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

                /// <summary>
        ///  Creates a new copy of an item, while making a single change to the appearance of the item.
        ///  Helmet models and simple items ignore iIndex.
        ///  iType                            iIndex                              iNewValue
        ///  ITEM_APPR_TYPE_SIMPLE_MODEL      [Ignored]                           Model #
        ///  ITEM_APPR_TYPE_WEAPON_COLOR      ITEM_APPR_WEAPON_COLOR_*            1-4
        ///  ITEM_APPR_TYPE_WEAPON_MODEL      ITEM_APPR_WEAPON_MODEL_*            Model #
        ///  ITEM_APPR_TYPE_ARMOR_MODEL       ITEM_APPR_ARMOR_MODEL_*             Model #
        ///  ITEM_APPR_TYPE_ARMOR_COLOR       ITEM_APPR_ARMOR_COLOR_* [0]         0-175 [1]
        ///
        ///  [0] Alternatively, where ITEM_APPR_TYPE_ARMOR_COLOR is specified, if per-part coloring is
        ///  desired, the following equation can be used for nIndex to achieve that:
        ///
        ///    ITEM_APPR_ARMOR_NUM_COLORS + (ITEM_APPR_ARMOR_MODEL_ * ITEM_APPR_ARMOR_NUM_COLORS) + ITEM_APPR_ARMOR_COLOR_
        ///
        ///  For example, to change the CLOTH1 channel of the torso, nIndex would be:
        ///
        ///    6 + (7 * 6) + 2 = 50
        ///
        ///  [1] When specifying per-part coloring, the value 255 is allowed and corresponds with the logical
        ///  function 'clear colour override', which clears the per-part override for that part.
        /// </summary>
        public static uint CopyItemAndModify(uint oItem, ItemAppearanceType nType, int nIndex, int nNewValue, bool bCopyVars = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(bCopyVars? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushInteger(nNewValue);
            NWN.Internal.NativeFunctions.StackPushInteger(nIndex);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nType);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(731);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Creates an item property that (when applied to a weapon item) causes a spell to be cast
        ///  when a successful strike is made, or (when applied to armor) is struck by an opponent.
        ///  - nSpell uses the IP_CONST_ONHIT_CASTSPELL_* constants
        /// </summary>
        public static NWN.ItemProperty ItemPropertyOnHitCastSpell(ItemPropertyOnHitCastSpell nSpell, int nLevel)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nLevel);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSpell);
            NWN.Internal.NativeFunctions.CallBuiltIn(733);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns the SubType number of the item property. See the 2DA files for value definitions.
        /// </summary>
        public static int GetItemPropertySubType(NWN.ItemProperty iProperty)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(iProperty.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(734);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Tags the item property with the provided string.
        ///  - Any tags currently set on the item property will be overwritten.
        /// </summary>
        public static NWN.ItemProperty TagItemProperty(NWN.ItemProperty nProperty, string sNewTag)
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sNewTag);
            NWN.Internal.NativeFunctions.StackPushItemProperty(nProperty.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(855);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns the total duration of the item property in seconds.
        ///  - Returns 0 if the duration type of the item property is not DURATION_TYPE_TEMPORARY.
        /// </summary>
        public static int GetItemPropertyDuration(NWN.ItemProperty nProperty)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(nProperty.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(856);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns the remaining duration of the item property in seconds.
        ///  - Returns 0 if the duration type of the item property is not DURATION_TYPE_TEMPORARY.
        /// </summary>
        public static int GetItemPropertyDurationRemaining(NWN.ItemProperty nProperty)
        {
            NWN.Internal.NativeFunctions.StackPushItemProperty(nProperty.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(857);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns Item property Material.  You need to specify the Material Type.
        ///  - nMasterialType: The Material Type should be a positive integer between 0 and 77 (see iprp_matcost.2da).
        ///  Note: The Material Type property will only affect the cost of the item if you modify the cost in the iprp_matcost.2da.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyMaterial(int nMaterialType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nMaterialType);
            NWN.Internal.NativeFunctions.CallBuiltIn(845);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns Item property Quality. You need to specify the Quality.
        ///  - nQuality:  The Quality of the item property to create (see iprp_qualcost.2da).
        ///               IP_CONST_QUALITY_*
        ///  Note: The quality property will only affect the cost of the item if you modify the cost in the iprp_qualcost.2da.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyQuality(ItemPropertyQuality nQuality)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nQuality);
            NWN.Internal.NativeFunctions.CallBuiltIn(846);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Returns a generic Additional Item property. You need to specify the Additional property.
        ///  - nProperty: The item property to create (see iprp_addcost.2da).
        ///               IP_CONST_ADDITIONAL_*
        ///  Note: The additional property only affects the cost of the item if you modify the cost in the iprp_addcost.2da.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyAdditional(ItemPropertyAdditional nAdditionalProperty)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAdditionalProperty);
            NWN.Internal.NativeFunctions.CallBuiltIn(847);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Creates an item property that offsets the effect on arcane spell failure
        ///  that a particular item has. Parameters come from the ITEM_PROP_ASF_* group.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyArcaneSpellFailure(ArcaneSpellFailure nModLevel)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nModLevel);
            NWN.Internal.NativeFunctions.CallBuiltIn(758);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }

        /// <summary>
        ///  Creates a visual effect (ITEM_VISUAL_*) that may be applied to
        ///  melee weapons only.
        /// </summary>
        public static NWN.ItemProperty ItemPropertyVisualEffect(ItemVisual nEffect)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nEffect);
            NWN.Internal.NativeFunctions.CallBuiltIn(739);
            return new NWN.ItemProperty(NWN.Internal.NativeFunctions.StackPopItemProperty());
        }
    }
}