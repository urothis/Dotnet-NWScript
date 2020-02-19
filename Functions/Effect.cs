using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  Returns the string tag set for the provided effect.
        ///  - If no tag has been set, returns an empty string.
        /// </summary>
        public static string GetEffectTag(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(849);
            return NWN.Internal.NativeFunctions.StackPopStringUTF8();
        }

        /// <summary>
        ///  Tags the effect with the provided string.
        ///  - Any other tags in the link will be overwritten.
        /// </summary>
        public static NWN.Effect TagEffect(NWN.Effect eEffect, string sNewTag)
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sNewTag);
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(850);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Returns the caster level of the creature who created the effect.
        ///  - If not created by a creature, returns 0.
        ///  - If created by a spell-like ability, returns 0.
        /// </summary>
        public static int GetEffectCasterLevel(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(851);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns the total duration of the effect in seconds.
        ///  - Returns 0 if the duration type of the effect is not DURATION_TYPE_TEMPORARY.
        /// </summary>
        public static int GetEffectDuration(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(852);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns the remaining duration of the effect in seconds.
        ///  - Returns 0 if the duration type of the effect is not DURATION_TYPE_TEMPORARY.
        /// </summary>
        public static int GetEffectDurationRemaining(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(853);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns an effect that when applied will paralyze the target's legs, rendering
        ///  them unable to walk but otherwise unpenalized. This effect cannot be resisted.
        /// </summary>
        public static NWN.Effect EffectCutsceneImmobilize()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(767);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Creates a cutscene ghost effect, this will allow creatures
        ///  to pathfind through other creatures without bumping into them
        ///  for the duration of the effect.
        /// </summary>
        public static NWN.Effect EffectCutsceneGhost()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(757);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Returns TRUE if the item is cursed and cannot be dropped
        /// </summary>
        public static bool GetItemCursedFlag(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(744);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  When cursed, items cannot be dropped
        /// </summary>
        public static void SetItemCursedFlag(uint oItem, bool nCursed)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nCursed? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(745);
        }

        /// <summary>
        ///  Get the possessor of oItem
        ///  * Return value on error: OBJECT_INVALID
        /// </summary>
        public static uint GetItemPossessor(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(29);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Get the object possessed by oCreature with the tag sItemTag
        ///  * Return value on error: OBJECT_INVALID
        /// </summary>
        public static uint GetItemPossessedBy(uint oCreature, string sItemTag)
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sItemTag);
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.CallBuiltIn(30);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Create an item with the template sItemTemplate in oTarget's inventory.
        ///  - nStackSize: This is the stack size of the item to be created
        ///  - sNewTag: If this string is not empty, it will replace the default tag from the template
        ///  * Return value: The object that has been created.  On error, this returns
        ///    OBJECT_INVALID.
        ///  If the item created was merged into an existing stack of similar items,
        ///  the function will return the merged stack object. If the merged stack
        ///  overflowed, the function will return the overflowed stack that was created.
        /// </summary>
        public static uint CreateItemOnObject(string sTag, uint oTarget = OBJECT_INVALID, int nStackSize = 1, string sNewTag = "")
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sNewTag);
            NWN.Internal.NativeFunctions.StackPushInteger(nStackSize);
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sTag);
            NWN.Internal.NativeFunctions.CallBuiltIn(31);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Equip oItem into nInventorySlot.
        ///  - nInventorySlot: INVENTORY_SLOT_*
        ///  * No return value, but if an error occurs the log file will contain
        ///    "ActionEquipItem failed."
        ///
        ///  Note:
        ///        If the creature already has an item equipped in the slot specified, it will be
        ///        unequipped automatically by the call to ActionEquipItem.
        ///
        ///        In order for ActionEquipItem to succeed the creature must be able to equip the
        ///        item oItem normally. This means that:
        ///        1) The item is in the creature's inventory.
        ///        2) The item must already be identified (if magical).
        ///        3) The creature has the level required to equip the item (if magical and ILR is on).
        ///        4) The creature possesses the required feats to equip the item (such as weapon proficiencies).
        /// </summary>
        public static void ActionEquipItem(uint oItem, InventorySlot nInventorySlot)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nInventorySlot);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(32);
        }

        /// <summary>
        ///  Unequip oItem from whatever slot it is currently in.
        /// </summary>
        public static void ActionUnequipItem(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(33);
        }

        /// <summary>
        ///  Pick up oItem from the ground.
        ///  * No return value, but if an error occurs the log file will contain
        ///    "ActionPickUpItem failed."
        /// </summary>
        public static void ActionPickUpItem(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(34);
        }

        /// <summary>
        ///  Put down oItem on the ground.
        ///  * No return value, but if an error occurs the log file will contain
        ///    "ActionPutDownItem failed."
        /// </summary>
        public static void ActionPutDownItem(uint oItem)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(35);
        }

        /// <summary>
        ///  Give oItem to oGiveTo
        ///  If oItem is not a valid item, or oGiveTo is not a valid object, nothing will
        ///  happen.
        /// </summary>
        public static void ActionGiveItem(uint oItem, uint oGiveTo)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oGiveTo);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(135);
        }

        /// <summary>
        ///  Take oItem from oTakeFrom
        ///  If oItem is not a valid item, or oTakeFrom is not a valid object, nothing
        ///  will happen.
        /// </summary>
        public static void ActionTakeItem(uint oItem, uint oTakeFrom)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTakeFrom);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(136);
        }

        /// <summary>
        ///  Create a Death effect
        ///  - nSpectacularDeath: if this is TRUE, the creature to which this effect is
        ///    applied will die in an extraordinary fashion
        ///  - nDisplayFeedback
        /// </summary>
        public static NWN.Effect EffectDeath(bool nSpectacularDeath = false, bool nDisplayFeedback = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDisplayFeedback? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushInteger(nSpectacularDeath? 1 : 0);
            NWN.Internal.NativeFunctions.CallBuiltIn(133);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Knockdown effect
        ///  This effect knocks creatures off their feet, they will sit until the effect
        ///  is removed. This should be applied as a temporary effect with a 3 second
        ///  duration minimum (1 second to fall, 1 second sitting, 1 second to get up).
        /// </summary>
        public static NWN.Effect EffectKnockdown()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(134);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Curse effect.
        ///  - nStrMod: strength modifier
        ///  - nDexMod: dexterity modifier
        ///  - nConMod: constitution modifier
        ///  - nIntMod: intelligence modifier
        ///  - nWisMod: wisdom modifier
        ///  - nChaMod: charisma modifier
        /// </summary>
        public static NWN.Effect EffectCurse(int nStrMod = 1, int nDexMod = 1, int nConMod = 1, int nIntMod = 1, int nWisMod = 1, int nChaMod = 1)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nChaMod);
            NWN.Internal.NativeFunctions.StackPushInteger(nWisMod);
            NWN.Internal.NativeFunctions.StackPushInteger(nIntMod);
            NWN.Internal.NativeFunctions.StackPushInteger(nConMod);
            NWN.Internal.NativeFunctions.StackPushInteger(nDexMod);
            NWN.Internal.NativeFunctions.StackPushInteger(nStrMod);
            NWN.Internal.NativeFunctions.CallBuiltIn(138);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Entangle effect
        ///  When applied, this effect will restrict the creature's movement and apply a
        ///  (-2) to all attacks and a -4 to AC.
        /// </summary>
        public static NWN.Effect EffectEntangle()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(130);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Saving Throw Increase effect
        ///  - nSave: SAVING_THROW_* (not SAVING_THROW_TYPE_*)
        ///           SAVING_THROW_ALL
        ///           SAVING_THROW_FORT
        ///           SAVING_THROW_REFLEX
        ///           SAVING_THROW_WILL
        ///  - nValue: size of the Saving Throw increase
        ///  - nSaveType: SAVING_THROW_TYPE_* (e.g. SAVING_THROW_TYPE_ACID )
        /// </summary>
        public static NWN.Effect EffectSavingThrowIncrease(int nSave, int nValue, SavingThrowType nSaveType = SavingThrowType.All)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSaveType);
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.StackPushInteger(nSave);
            NWN.Internal.NativeFunctions.CallBuiltIn(117);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Attack Increase effect
        ///  - nBonus: size of attack bonus
        ///  - nModifierType: ATTACK_BONUS_*
        /// </summary>
        public static NWN.Effect EffectAttackIncrease(int nBonus, AttackBonus nModifierType = AttackBonus.Misc)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nModifierType);
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.CallBuiltIn(118);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage Reduction effect
        ///  - nAmount: amount of damage reduction
        ///  - nDamagePower: DAMAGE_POWER_*
        ///  - nLimit: How much damage the effect can absorb before disappearing.
        ///    Set to zero for infinite
        /// </summary>
        public static NWN.Effect EffectDamageReduction(int nAmount, DamagePower nDamagePower, int nLimit = 0)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nLimit);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamagePower);
            NWN.Internal.NativeFunctions.StackPushInteger(nAmount);
            NWN.Internal.NativeFunctions.CallBuiltIn(119);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage Increase effect
        ///  - nBonus: DAMAGE_BONUS_*
        ///  - nDamageType: DAMAGE_TYPE_*
        ///  NOTE! You *must* use the DAMAGE_BONUS_* constants! Using other values may
        ///        result in odd behaviour.
        /// </summary>
        public static NWN.Effect EffectDamageIncrease(int nBonus, DamageType nDamageType = DamageType.Magical)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger(nBonus);
            NWN.Internal.NativeFunctions.CallBuiltIn(120);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Set the subtype of eEffect to Magical and return eEffect.
        ///  (Effects default to magical if the subtype is not set)
        ///  Magical effects are removed by resting, and by dispel magic
        /// </summary>
        public static NWN.Effect MagicalEffect(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(112);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Set the subtype of eEffect to Supernatural and return eEffect.
        ///  (Effects default to magical if the subtype is not set)
        ///  Permanent supernatural effects are not removed by resting
        /// </summary>
        public static NWN.Effect SupernaturalEffect(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(113);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Set the subtype of eEffect to Extraordinary and return eEffect.
        ///  (Effects default to magical if the subtype is not set)
        ///  Extraordinary effects are removed by resting, but not by dispel magic
        /// </summary>
        public static NWN.Effect ExtraordinaryEffect(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(114);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an AC Increase effect
        ///  - nValue: size of AC increase
        ///  - nModifyType: AC_*_BONUS
        ///  - nDamageType: DAMAGE_TYPE_*
        ///    * Default value for nDamageType should only ever be used in this function prototype.
        /// </summary>
        public static NWN.Effect EffectACIncrease(int nValue, ACModifierType nModifyType = ACModifierType.DodgeBonus, DamageType nDamageType = DamageType.None)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nModifyType);
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(115);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Get the first in-game effect on oCreature.
        /// </summary>
        public static NWN.Effect GetFirstEffect(uint oCreature)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.CallBuiltIn(85);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Get the next in-game effect on oCreature.
        /// </summary>
        public static NWN.Effect GetNextEffect(uint oCreature)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.CallBuiltIn(86);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Remove eEffect from oCreature.
        ///  * No return value
        /// </summary>
        public static void RemoveEffect(uint oCreature, NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.CallBuiltIn(87);
        }

        /// <summary>
        ///  * Returns TRUE if eEffect is a valid effect. The effect must have been applied to
        ///  * an object or else it will return FALSE
        /// </summary>
        public static int GetIsEffectValid(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(88);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the duration type (DURATION_TYPE_*) of eEffect.
        ///  * Return value if eEffect is not valid: -1
        /// </summary>
        public static int GetEffectDurationType(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(89);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the subtype (SUBTYPE_*) of eEffect.
        ///  * Return value on error: 0
        /// </summary>
        public static int GetEffectSubType(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(90);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the object that created eEffect.
        ///  * Returns OBJECT_INVALID if eEffect is not a valid effect.
        /// </summary>
        public static uint GetEffectCreator(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(91);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Create a Heal effect. This should be applied as an instantaneous effect.
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nDamageToHeal < 0.
        /// </summary>
        public static NWN.Effect EffectHeal(int nDamageToHeal)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDamageToHeal);
            NWN.Internal.NativeFunctions.CallBuiltIn(78);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage effect
        ///  - nDamageAmount: amount of damage to be dealt. This should be applied as an
        ///    instantaneous effect.
        ///  - nDamageType: DAMAGE_TYPE_*
        ///  - nDamagePower: DAMAGE_POWER_*
        /// </summary>
        public static NWN.Effect EffectDamage(int nDamageAmount, DamageType nDamageType = DamageType.Magical, DamagePower nDamagePower = DamagePower.Normal)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamagePower);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger(nDamageAmount);
            NWN.Internal.NativeFunctions.CallBuiltIn(79);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Ability Increase effect
        ///  - bAbilityToIncrease: ABILITY_*
        /// </summary>
        public static NWN.Effect EffectAbilityIncrease(Ability nAbilityToIncrease, int nModifyBy)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifyBy);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAbilityToIncrease);
            NWN.Internal.NativeFunctions.CallBuiltIn(80);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage Resistance effect that removes the first nAmount points of
        ///  damage of type nDamageType, up to nLimit (or infinite if nLimit is 0)
        ///  - nDamageType: DAMAGE_TYPE_*
        ///  - nAmount
        ///  - nLimit
        /// </summary>
        public static NWN.Effect EffectDamageResistance(DamageType nDamageType, int nAmount, int nLimit = 0)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nLimit);
            NWN.Internal.NativeFunctions.StackPushInteger(nAmount);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(81);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Resurrection effect. This should be applied as an instantaneous effect.
        /// </summary>
        public static NWN.Effect EffectResurrection()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(82);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Summon Creature effect.  The creature is created and placed into the
        ///  caller's party/faction.
        ///  - sCreatureResref: Identifies the creature to be summoned
        ///  - nVisualEffectId: VFX_*
        ///  - fDelaySeconds: There can be delay between the visual effect being played, and the
        ///    creature being added to the area
        ///  - nUseAppearAnimation: should this creature play it's "appear" animation when it is
        ///    summoned. If zero, it will just fade in somewhere near the target.  If the value is 1
        ///    it will use the appear animation, and if it's 2 it will use appear2 (which doesn't exist for most creatures)
        /// </summary>
        public static NWN.Effect EffectSummonCreature(string sCreatureResref, Vfx nVisualEffectId = Vfx.None, float fDelaySeconds = 0.0f, bool nUseAppearAnimation = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nUseAppearAnimation? 0 : 1);
            NWN.Internal.NativeFunctions.StackPushFloat(fDelaySeconds);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nVisualEffectId);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sCreatureResref);
            NWN.Internal.NativeFunctions.CallBuiltIn(83);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Returns an effect of type EFFECT_TYPE_ETHEREAL which works just like EffectSanctuary
        ///  except that the observers get no saving throw
        /// </summary>
        public static NWN.Effect EffectEthereal()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(711);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Creates an effect that inhibits spells
        ///  - nPercent - percentage of failure
        ///  - nSpellSchool - the school of spells affected.
        /// </summary>
        public static NWN.Effect EffectSpellFailure(int nPercent = 100, SpellSchool nSpellSchool = SpellSchool.General)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSpellSchool);
            NWN.Internal.NativeFunctions.StackPushInteger(nPercent);
            NWN.Internal.NativeFunctions.CallBuiltIn(690);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Returns an effect that is guaranteed to dominate a creature
        ///  Like EffectDominated but cannot be resisted
        /// </summary>
        public static NWN.Effect EffectCutsceneDominated()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(604);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  returns an effect that will petrify the target
        ///  * currently applies EffectParalyze and the stoneskin visual effect.
        /// </summary>
        public static NWN.Effect EffectPetrify()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(583);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  returns an effect that is guaranteed to paralyze a creature.
        ///  this effect is identical to EffectParalyze except that it cannot be resisted.
        /// </summary>
        public static NWN.Effect EffectCutsceneParalyze()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(585);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Turn Resistance Decrease effect.
        ///  - nHitDice: a positive number representing the number of hit dice for the
        /// /  decrease
        /// </summary>
        public static NWN.Effect EffectTurnResistanceDecrease(int nHitDice)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nHitDice);
            NWN.Internal.NativeFunctions.CallBuiltIn(552);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Turn Resistance Increase effect.
        ///  - nHitDice: a positive number representing the number of hit dice for the
        ///    increase
        /// </summary>
        public static NWN.Effect EffectTurnResistanceIncrease(int nHitDice)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nHitDice);
            NWN.Internal.NativeFunctions.CallBuiltIn(553);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Swarm effect.
        ///  - nLooping: If this is TRUE, for the duration of the effect when one creature
        ///    created by this effect dies, the next one in the list will be created.  If
        ///    the last creature in the list dies, we loop back to the beginning and
        ///    sCreatureTemplate1 will be created, and so on...
        ///  - sCreatureTemplate1
        ///  - sCreatureTemplate2
        ///  - sCreatureTemplate3
        ///  - sCreatureTemplate4
        /// </summary>
        public static NWN.Effect EffectSwarm(int nLooping, string sCreatureTemplate1, string sCreatureTemplate2 = "", string sCreatureTemplate3 = "", string sCreatureTemplate4 = "")
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sCreatureTemplate4);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sCreatureTemplate3);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sCreatureTemplate2);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sCreatureTemplate1);
            NWN.Internal.NativeFunctions.StackPushInteger(nLooping);
            NWN.Internal.NativeFunctions.CallBuiltIn(510);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Disappear/Appear effect.
        ///  The object will "fly away" for the duration of the effect and will reappear
        ///  at lLocation.
        ///  - nAnimation determines which appear and disappear animations to use. Most creatures
        ///  only have animation 1, although a few have 2 (like beholders)
        /// </summary>
        public static NWN.Effect EffectDisappearAppear(NWN.Location lLocation, int nAnimation = 1)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nAnimation);
            NWN.Internal.NativeFunctions.StackPushLocation(lLocation.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(480);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Disappear effect to make the object "fly away" and then destroy
        ///  itself.
        ///  - nAnimation determines which appear and disappear animations to use. Most creatures
        ///  only have animation 1, although a few have 2 (like beholders)
        /// </summary>
        public static NWN.Effect EffectDisappear(int nAnimation = 1)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nAnimation);
            NWN.Internal.NativeFunctions.CallBuiltIn(481);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Appear effect to make the object "fly in".
        ///  - nAnimation determines which appear and disappear animations to use. Most creatures
        ///  only have animation 1, although a few have 2 (like beholders)
        /// </summary>
        public static NWN.Effect EffectAppear(int nAnimation = 1)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nAnimation);
            NWN.Internal.NativeFunctions.CallBuiltIn(482);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Modify Attacks effect to add attacks.
        ///  - nAttacks: maximum is 5, even with the effect stacked
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nAttacks > 5.
        /// </summary>
        public static NWN.Effect EffectModifyAttacks(int nAttacks)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nAttacks);
            NWN.Internal.NativeFunctions.CallBuiltIn(485);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage Shield effect which does (nDamageAmount + nRandomAmount)
        ///  damage to any melee attacker on a successful attack of damage type nDamageType.
        ///  - nDamageAmount: an integer value
        ///  - nRandomAmount: DAMAGE_BONUS_*
        ///  - nDamageType: DAMAGE_TYPE_*
        ///  NOTE! You *must* use the DAMAGE_BONUS_* constants! Using other values may
        ///        result in odd behaviour.
        /// </summary>
        public static NWN.Effect EffectDamageShield(int nDamageAmount, int nRandomAmount, int nDamageType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger(nRandomAmount);
            NWN.Internal.NativeFunctions.StackPushInteger(nDamageAmount);
            NWN.Internal.NativeFunctions.CallBuiltIn(487);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Miss Chance effect.
        ///  - nPercentage: 1-100 inclusive
        ///  - nMissChanceType: MISS_CHANCE_TYPE_*
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nPercentage < 1 or
        ///    nPercentage > 100.
        /// </summary>
        public static NWN.Effect EffectMissChance(int nPercentage, MissChanceType nMissChanceType = MissChanceType.Normal)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nMissChanceType);
            NWN.Internal.NativeFunctions.StackPushInteger(nPercentage);
            NWN.Internal.NativeFunctions.CallBuiltIn(477);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Spell Level Absorption effect.
        ///  - nMaxSpellLevelAbsorbed: maximum spell level that will be absorbed by the
        ///    effect
        ///  - nTotalSpellLevelsAbsorbed: maximum number of spell levels that will be
        ///    absorbed by the effect
        ///  - nSpellSchool: SPELL_SCHOOL_*
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if:
        ///    nMaxSpellLevelAbsorbed is not between -1 and 9 inclusive, or nSpellSchool
        ///    is invalid.
        /// </summary>
        public static NWN.Effect EffectSpellLevelAbsorption(int nMaxSpellLevelAbsorbed, int nTotalSpellLevelsAbsorbed = 0, SpellSchool nSpellSchool = SpellSchool.General)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSpellSchool);
            NWN.Internal.NativeFunctions.StackPushInteger(nTotalSpellLevelsAbsorbed);
            NWN.Internal.NativeFunctions.StackPushInteger(nMaxSpellLevelAbsorbed);
            NWN.Internal.NativeFunctions.CallBuiltIn(472);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Dispel Magic Best effect.
        ///  If no parameter is specified, USE_CREATURE_LEVEL will be used. This will
        ///  cause the dispel effect to use the level of the creature that created the
        ///  effect.
        /// </summary>
        public static NWN.Effect EffectDispelMagicBest(int nCasterLevel = USE_CREATURE_LEVEL)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nCasterLevel);
            NWN.Internal.NativeFunctions.CallBuiltIn(473);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Invisibility effect.
        ///  - nInvisibilityType: INVISIBILITY_TYPE_*
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nInvisibilityType
        ///    is invalid.
        /// </summary>
        public static NWN.Effect EffectInvisibility(int nInvisibilityType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nInvisibilityType);
            NWN.Internal.NativeFunctions.CallBuiltIn(457);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Concealment effect.
        ///  - nPercentage: 1-100 inclusive
        ///  - nMissChanceType: MISS_CHANCE_TYPE_*
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nPercentage < 1 or
        ///    nPercentage > 100.
        /// </summary>
        public static NWN.Effect EffectConcealment(int nPercentage, MissChanceType nMissType = MissChanceType.Normal)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nMissType);
            NWN.Internal.NativeFunctions.StackPushInteger(nPercentage);
            NWN.Internal.NativeFunctions.CallBuiltIn(458);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Darkness effect.
        /// </summary>
        public static NWN.Effect EffectDarkness()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(459);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Dispel Magic All effect.
        ///  If no parameter is specified, USE_CREATURE_LEVEL will be used. This will
        ///  cause the dispel effect to use the level of the creature that created the
        ///  effect.
        /// </summary>
        public static NWN.Effect EffectDispelMagicAll(int nCasterLevel = USE_CREATURE_LEVEL)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nCasterLevel);
            NWN.Internal.NativeFunctions.CallBuiltIn(460);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Ultravision effect.
        /// </summary>
        public static NWN.Effect EffectUltravision()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(461);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Negative Level effect.
        ///  - nNumLevels: the number of negative levels to apply.
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nNumLevels > 100.
        /// </summary>
        public static NWN.Effect EffectNegativeLevel(int nNumLevels, bool bHPBonus = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(bHPBonus? 0 : 1);
            NWN.Internal.NativeFunctions.StackPushInteger(nNumLevels);
            NWN.Internal.NativeFunctions.CallBuiltIn(462);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Polymorph effect.
        /// </summary>
        public static NWN.Effect EffectPolymorph(int nPolymorphSelection, bool nLocked = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nLocked? 0 : 1);
            NWN.Internal.NativeFunctions.StackPushInteger(nPolymorphSelection);
            NWN.Internal.NativeFunctions.CallBuiltIn(463);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Sanctuary effect.
        ///  - nDifficultyClass: must be a non-zero, positive number
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nDifficultyClass <= 0.
        /// </summary>
        public static NWN.Effect EffectSanctuary(int nDifficultyClass)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDifficultyClass);
            NWN.Internal.NativeFunctions.CallBuiltIn(464);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a True Seeing effect.
        /// </summary>
        public static NWN.Effect EffectTrueSeeing()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(465);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a See Invisible effect.
        /// </summary>
        public static NWN.Effect EffectSeeInvisible()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(466);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Time Stop effect.
        /// </summary>
        public static NWN.Effect EffectTimeStop()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(467);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Blindness effect.
        /// </summary>
        public static NWN.Effect EffectBlindness()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(468);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Ability Decrease effect.
        ///  - nAbility: ABILITY_*
        ///  - nModifyBy: This is the amount by which to decrement the ability
        /// </summary>
        public static NWN.Effect EffectAbilityDecrease(int nAbility, int nModifyBy)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nModifyBy);
            NWN.Internal.NativeFunctions.StackPushInteger(nAbility);
            NWN.Internal.NativeFunctions.CallBuiltIn(446);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Attack Decrease effect.
        ///  - nPenalty
        ///  - nModifierType: ATTACK_BONUS_*
        /// </summary>
        public static NWN.Effect EffectAttackDecrease(int nPenalty, AttackBonus nModifierType = AttackBonus.Misc)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nModifierType);
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.CallBuiltIn(447);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage Decrease effect.
        ///  - nPenalty
        ///  - nDamageType: DAMAGE_TYPE_*
        /// </summary>
        public static NWN.Effect EffectDamageDecrease(int nPenalty, DamageType nDamageType = DamageType.Magical)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger(nPenalty);
            NWN.Internal.NativeFunctions.CallBuiltIn(448);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Damage Immunity Decrease effect.
        ///  - nDamageType: DAMAGE_TYPE_*
        ///  - nPercentImmunity
        /// </summary>
        public static NWN.Effect EffectDamageImmunityDecrease(int nDamageType, int nPercentImmunity)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPercentImmunity);
            NWN.Internal.NativeFunctions.StackPushInteger(nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(449);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an AC Decrease effect.
        ///  - nValue
        ///  - nModifyType: AC_*
        ///  - nDamageType: DAMAGE_TYPE_*
        ///    * Default value for nDamageType should only ever be used in this function prototype.
        /// </summary>
        public static NWN.Effect EffectACDecrease(int nValue, ACModifierType nModifyType = ACModifierType.DodgeBonus, DamageType nDamageType = DamageType.Magical)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nModifyType);
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(450);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Movement Speed Decrease effect.
        ///  - nPercentChange - range 0 through 99
        ///  eg.
        ///     0 = no change in speed
        ///    50 = 50% slower
        ///    99 = almost immobile
        /// </summary>
        public static NWN.Effect EffectMovementSpeedDecrease(int nPercentChange)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPercentChange);
            NWN.Internal.NativeFunctions.CallBuiltIn(451);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Saving Throw Decrease effect.
        ///  - nSave: SAVING_THROW_* (not SAVING_THROW_TYPE_*)
        ///           SAVING_THROW_ALL
        ///           SAVING_THROW_FORT
        ///           SAVING_THROW_REFLEX
        ///           SAVING_THROW_WILL
        ///  - nValue: size of the Saving Throw decrease
        ///  - nSaveType: SAVING_THROW_TYPE_* (e.g. SAVING_THROW_TYPE_ACID )
        /// </summary>
        public static NWN.Effect EffectSavingThrowDecrease(int nSave, int nValue, SavingThrowType nSaveType = SavingThrowType.All)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSaveType);
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.StackPushInteger(nSave);
            NWN.Internal.NativeFunctions.CallBuiltIn(452);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Skill Decrease effect.
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nSkill is invalid.
        /// </summary>
        public static NWN.Effect EffectSkillDecrease(int nSkill, int nValue)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.StackPushInteger(nSkill);
            NWN.Internal.NativeFunctions.CallBuiltIn(453);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Spell Resistance Decrease effect.
        /// </summary>
        public static NWN.Effect EffectSpellResistanceDecrease(int nValue)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(454);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Activate oItem.
        /// </summary>
        public static NWN.Event EventActivateItem(uint oItem, NWN.Location lTarget, uint oTarget = OBJECT_INVALID)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.StackPushLocation(lTarget.Handle);
            NWN.Internal.NativeFunctions.StackPushObject(oItem);
            NWN.Internal.NativeFunctions.CallBuiltIn(424);
            return new NWN.Event(NWN.Internal.NativeFunctions.StackPopEvent());
        }

        /// <summary>
        ///  Create a Hit Point Change When Dying effect.
        ///  - fHitPointChangePerRound: this can be positive or negative, but not zero.
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if fHitPointChangePerRound is 0.
        /// </summary>
        public static NWN.Effect EffectHitPointChangeWhenDying(float fHitPointChangePerRound)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fHitPointChangePerRound);
            NWN.Internal.NativeFunctions.CallBuiltIn(387);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Turned effect.
        ///  Turned effects are supernatural by default.
        /// </summary>
        public static NWN.Effect EffectTurned()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(379);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Set eEffect to be versus a specific alignment.
        ///  - eEffect
        ///  - nLawChaos: ALIGNMENT_LAWFUL/ALIGNMENT_CHAOTIC/ALIGNMENT_ALL
        ///  - nGoodEvil: ALIGNMENT_GOOD/ALIGNMENT_EVIL/ALIGNMENT_ALL
        /// </summary>
        public static NWN.Effect VersusAlignmentEffect(NWN.Effect eEffect, Alignment nLawChaos = Alignment.All, Alignment nGoodEvil = Alignment.All)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nGoodEvil);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nLawChaos);
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(355);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Set eEffect to be versus nRacialType.
        ///  - eEffect
        ///  - nRacialType: RACIAL_TYPE_*
        /// </summary>
        public static NWN.Effect VersusRacialTypeEffect(NWN.Effect eEffect, RacialType nRacialType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nRacialType);
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(356);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Set eEffect to be versus traps.
        /// </summary>
        public static NWN.Effect VersusTrapEffect(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(357);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Skill Increase effect.
        ///  - nSkill: SKILL_*
        ///  - nValue
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nSkill is invalid.
        /// </summary>
        public static NWN.Effect EffectSkillIncrease(Skill nSkill, int nValue)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nSkill);
            NWN.Internal.NativeFunctions.CallBuiltIn(351);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Temporary Hitpoints effect.
        ///  - nHitPoints: a positive integer
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nHitPoints < 0.
        /// </summary>
        public static NWN.Effect EffectTemporaryHitpoints(int nHitPoints)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nHitPoints);
            NWN.Internal.NativeFunctions.CallBuiltIn(314);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Creates a conversation event.
        ///  Note: This only creates the event. The event wont actually trigger until SignalEvent()
        ///  is called using this created conversation event as an argument.
        ///  For example:
        ///      SignalEvent(oCreature, EventConversation());
        ///  Once the event has been signaled. The script associated with the OnConversation event will
        ///  run on the creature oCreature.
        ///
        ///  To specify the OnConversation script that should run, view the Creature Properties on
        ///  the creature and click on the Scripts Tab. Then specify a script for the OnConversation event.
        /// </summary>
        public static NWN.Event EventConversation()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(295);
            return new NWN.Event(NWN.Internal.NativeFunctions.StackPopEvent());
        }

        /// <summary>
        ///  Creates a Damage Immunity Increase effect.
        ///  - nDamageType: DAMAGE_TYPE_*
        ///  - nPercentImmunity
        /// </summary>
        public static NWN.Effect EffectDamageImmunityIncrease(DamageType nDamageType, int nPercentImmunity)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPercentImmunity);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDamageType);
            NWN.Internal.NativeFunctions.CallBuiltIn(275);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create an Immunity effect.
        ///  - nImmunityType: IMMUNITY_TYPE_*
        /// </summary>
        public static NWN.Effect EffectImmunity(ImmunityType nImmunityType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nImmunityType);
            NWN.Internal.NativeFunctions.CallBuiltIn(273);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Haste effect.
        /// </summary>
        public static NWN.Effect EffectHaste()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(270);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Slow effect.
        /// </summary>
        public static NWN.Effect EffectSlow()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(271);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Poison effect.
        ///  - nPoisonType: POISON_*
        /// </summary>
        public static NWN.Effect EffectPoison(Poison nPoisonType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nPoisonType);
            NWN.Internal.NativeFunctions.CallBuiltIn(250);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Disease effect.
        ///  - nDiseaseType: DISEASE_*
        /// </summary>
        public static NWN.Effect EffectDisease(Disease nDiseaseType)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDiseaseType);
            NWN.Internal.NativeFunctions.CallBuiltIn(251);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Silence effect.
        /// </summary>
        public static NWN.Effect EffectSilence()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(252);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Spell Resistance Increase effect.
        ///  - nValue: size of spell resistance increase
        /// </summary>
        public static NWN.Effect EffectSpellResistanceIncrease(int nValue)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(212);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Beam effect.
        ///  - nBeamVisualEffect: VFX_BEAM_*
        ///  - oEffector: the beam is emitted from this creature
        ///  - nBodyPart: BODY_NODE_*
        ///  - bMissEffect: If this is TRUE, the beam will fire to a random vector near or
        ///    past the target
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nBeamVisualEffect is
        ///    not valid.
        /// </summary>
        public static NWN.Effect EffectBeam(Vfx nBeamVisualEffect, uint oEffector, int nBodyPart, bool bMissEffect = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(bMissEffect? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushInteger(nBodyPart);
            NWN.Internal.NativeFunctions.StackPushObject(oEffector);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nBeamVisualEffect);
            NWN.Internal.NativeFunctions.CallBuiltIn(207);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Link the two supplied effects, returning eChildEffect as a child of
        ///  eParentEffect.
        ///  Note: When applying linked effects if the target is immune to all valid
        ///  effects all other effects will be removed as well. This means that if you
        ///  apply a visual effect and a silence effect (in a link) and the target is
        ///  immune to the silence effect that the visual effect will get removed as well.
        ///  Visual Effects are not considered "valid" effects for the purposes of
        ///  determining if an effect will be removed or not and as such should never be
        ///  packaged *only* with other visual effects in a link.
        /// </summary>
        public static NWN.Effect EffectLinkEffects(NWN.Effect eChildEffect, NWN.Effect eParentEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eParentEffect.Handle);
            NWN.Internal.NativeFunctions.StackPushEffect(eChildEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(199);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  * Create a Visual Effect that can be applied to an object.
        ///  - nVisualEffectId
        ///  - nMissEffect: if this is TRUE, a random vector near or past the target will
        ///    be generated, on which to play the effect
        /// </summary>
        public static NWN.Effect EffectVisualEffect(Vfx nVisualEffectId, bool nMissEffect = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nMissEffect? 0 : 1);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nVisualEffectId);
            NWN.Internal.NativeFunctions.CallBuiltIn(180);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Apply eEffect to oTarget.
        /// </summary>
        public static void ApplyEffectToObject(DurationType nDurationType, NWN.Effect eEffect, uint oTarget, float fDuration = 0.0f)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fDuration);
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDurationType);
            NWN.Internal.NativeFunctions.CallBuiltIn(220);
        }

        /// <summary>
        ///  Get the effect type (EFFECT_TYPE_*) of eEffect.
        ///  * Return value if eEffect is invalid: EFFECT_INVALIDEFFECT
        /// </summary>
        public static int GetEffectType(NWN.Effect eEffect)
        {
            NWN.Internal.NativeFunctions.StackPushEffect(eEffect.Handle);
            NWN.Internal.NativeFunctions.CallBuiltIn(170);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Create an Area Of Effect effect in the area of the creature it is applied to.
        ///  If the scripts are not specified, default ones will be used.
        /// </summary>
        public static NWN.Effect EffectAreaOfEffect(AreaOfEffect nAreaEffect, string sOnEnterScript = "", string sHeartbeatScript = "", string sOnExitScript = "")
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sOnExitScript);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sHeartbeatScript);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sOnEnterScript);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nAreaEffect);
            NWN.Internal.NativeFunctions.CallBuiltIn(171);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Regenerate effect.
        ///  - nAmount: amount of damage to be regenerated per time interval
        ///  - fIntervalSeconds: length of interval in seconds
        /// </summary>
        public static NWN.Effect EffectRegenerate(int nAmount, float fIntervalSeconds)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fIntervalSeconds);
            NWN.Internal.NativeFunctions.StackPushInteger(nAmount);
            NWN.Internal.NativeFunctions.CallBuiltIn(164);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Movement Speed Increase effect.
        ///  - nPercentChange - range 0 through 99
        ///  eg.
        ///     0 = no change in speed
        ///    50 = 50% faster
        ///    99 = almost twice as fast
        /// </summary>
        public static NWN.Effect EffectMovementSpeedIncrease(int nPercentChange)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPercentChange);
            NWN.Internal.NativeFunctions.CallBuiltIn(165);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Charm effect
        /// </summary>
        public static NWN.Effect EffectCharmed()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(156);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Confuse effect
        /// </summary>
        public static NWN.Effect EffectConfused()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(157);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Frighten effect
        /// </summary>
        public static NWN.Effect EffectFrightened()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(158);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Dominate effect
        /// </summary>
        public static NWN.Effect EffectDominated()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(159);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Daze effect
        /// </summary>
        public static NWN.Effect EffectDazed()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(160);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Stun effect
        /// </summary>
        public static NWN.Effect EffectStunned()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(161);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Sleep effect
        /// </summary>
        public static NWN.Effect EffectSleep()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(154);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Paralyze effect
        /// </summary>
        public static NWN.Effect EffectParalyze()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(148);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Spell Immunity effect.
        ///  There is a known bug with this function. There *must* be a parameter specified
        ///  when this is called (even if the desired parameter is SPELL_ALL_SPELLS),
        ///  otherwise an effect of type EFFECT_TYPE_INVALIDEFFECT will be returned.
        ///  - nImmunityToSpell: SPELL_*
        ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nImmunityToSpell is
        ///    invalid.
        /// </summary>
        public static NWN.Effect EffectSpellImmunity(Spell nImmunityToSpell = Spell.AllSpells)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nImmunityToSpell);
            NWN.Internal.NativeFunctions.CallBuiltIn(149);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }

        /// <summary>
        ///  Create a Deaf effect
        /// </summary>
        public static NWN.Effect EffectDeaf()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(150);
            return new NWN.Effect(NWN.Internal.NativeFunctions.StackPopEffect());
        }
    }
}