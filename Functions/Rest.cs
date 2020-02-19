using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  Instantly gives this creature the benefits of a rest (restored hitpoints, spells, feats, etc..)
        /// </summary>
        public static void ForceRest(uint oCreature)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.CallBuiltIn(775);
        }

        /// <summary>
        ///  * Returns TRUE if oCreature is resting.
        /// </summary>
        public static bool GetIsResting(uint oCreature = OBJECT_INVALID)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.CallBuiltIn(505);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  Get the last PC that has rested in the module.
        /// </summary>
        public static uint GetLastPCRested()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(506);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Determine the type (REST_EVENTTYPE_REST_*) of the last rest event (as
        ///  returned from the OnPCRested module event).
        /// </summary>
        public static RestType GetLastRestEventType()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(508);
            return (RestType)NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  The creature will rest if not in combat and no enemies are nearby.
        ///  - bCreatureToEnemyLineOfSightCheck: TRUE to allow the creature to rest if enemies
        ///                                      are nearby, but the creature can't see the enemy.
        ///                                      FALSE the creature will not rest if enemies are
        ///                                      nearby regardless of whether or not the creature
        ///                                      can see them, such as if an enemy is close by,
        ///                                      but is in a different room behind a closed door.
        /// </summary>
        public static void ActionRest(bool bCreatureToEnemyLineOfSightCheck = false)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(bCreatureToEnemyLineOfSightCheck? 0 : 1);
            NWN.Internal.NativeFunctions.CallBuiltIn(402);
        }
    }
}