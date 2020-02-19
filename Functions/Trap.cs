using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  Set the calendar to the specified date.
        ///  - nYear should be from 0 to 32000 inclusive
        ///  - nMonth should be from 1 to 12 inclusive
        ///  - nDay should be from 1 to 28 inclusive
        ///  1) Time can only be advanced forwards; attempting to set the time backwards
        ///     will result in no change to the calendar.
        ///  2) If values larger than the month or day are specified, they will be wrapped
        ///     around and the overflow will be used to advance the next field.
        ///     e.g. Specifying a year of 1350, month of 33 and day of 10 will result in
        ///     the calender being set to a year of 1352, a month of 9 and a day of 10.
        /// </summary>
        public static void SetCalendar(int nYear, int nMonth, int nDay)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDay);
            NWN.Internal.NativeFunctions.StackPushInteger(nMonth);
            NWN.Internal.NativeFunctions.StackPushInteger(nYear);
            NWN.Internal.NativeFunctions.CallBuiltIn(11);
        }

        /// <summary>
        ///  Set the time to the time specified.
        ///  - nHour should be from 0 to 23 inclusive
        ///  - nMinute should be from 0 to 59 inclusive
        ///  - nSecond should be from 0 to 59 inclusive
        ///  - nMillisecond should be from 0 to 999 inclusive
        ///  1) Time can only be advanced forwards; attempting to set the time backwards
        ///     will result in the day advancing and then the time being set to that
        ///     specified, e.g. if the current hour is 15 and then the hour is set to 3,
        ///     the day will be advanced by 1 and the hour will be set to 3.
        ///  2) If values larger than the max hour, minute, second or millisecond are
        ///     specified, they will be wrapped around and the overflow will be used to
        ///     advance the next field, e.g. specifying 62 hours, 250 minutes, 10 seconds
        ///     and 10 milliseconds will result in the calendar day being advanced by 2
        ///     and the time being set to 18 hours, 10 minutes, 10 milliseconds.
        /// </summary>
        public static void SetTime(int nHour, int nMinute, int nSecond, int nMillisecond)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nMillisecond);
            NWN.Internal.NativeFunctions.StackPushInteger(nSecond);
            NWN.Internal.NativeFunctions.StackPushInteger(nMinute);
            NWN.Internal.NativeFunctions.StackPushInteger(nHour);
            NWN.Internal.NativeFunctions.CallBuiltIn(12);
        }

        /// <summary>
        ///  Get the current calendar year.
        /// </summary>
        public static int GetCalendarYear()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(13);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the current calendar month.
        /// </summary>
        public static int GetCalendarMonth()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(14);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the current calendar day.
        /// </summary>
        public static int GetCalendarDay()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(15);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the current hour.
        /// </summary>
        public static int GetTimeHour()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(16);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the current minute
        /// </summary>
        public static int GetTimeMinute()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(17);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the current second
        /// </summary>
        public static int GetTimeSecond()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(18);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the current millisecond
        /// </summary>
        public static int GetTimeMillisecond()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(19);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Set whether or not the creature oDetector has detected the trapped object oTrap.
        ///  - oTrap: A trapped trigger, placeable or door object.
        ///  - oDetector: This is the creature that the detected status of the trap is being adjusted for.
        ///  - bDetected: A Boolean that sets whether the trapped object has been detected or not.
        /// </summary>
        public static int SetTrapDetectedBy(uint oTrap, uint oDetector, bool bDetected = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(bDetected? 0 : 1);
            NWN.Internal.NativeFunctions.StackPushObject(oDetector);
            NWN.Internal.NativeFunctions.StackPushObject(oTrap);
            NWN.Internal.NativeFunctions.CallBuiltIn(550);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Note: Only placeables, doors and triggers can be trapped.
        ///  * Returns TRUE if oObject is trapped.
        /// </summary>
        public static int GetIsTrapped(uint oObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(551);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns TRUE if oTrapObject is disarmable.
        /// </summary>
        public static bool GetTrapDisarmable(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(527);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns TRUE if oTrapObject is detectable.
        /// </summary>
        public static bool GetTrapDetectable(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(528);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  - oCreature
        ///  * Returns TRUE if oCreature has detected oTrapObject
        /// </summary>
        public static bool GetTrapDetectedBy(uint oTrapObject, uint oCreature)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oCreature);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(529);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns TRUE if oTrapObject has been flagged as visible to all creatures.
        /// </summary>
        public static bool GetTrapFlagged(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(530);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  Get the trap base type (TRAP_BASE_TYPE_*) of oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        /// </summary>
        public static int GetTrapBaseType(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(531);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns TRUE if oTrapObject is one-shot (i.e. it does not reset itself
        ///    after firing.
        /// </summary>
        public static bool GetTrapOneShot(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(532);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  Get the creator of oTrapObject, the creature that set the trap.
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns OBJECT_INVALID if oTrapObject was created in the toolset.
        /// </summary>
        public static uint GetTrapCreator(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(533);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Get the tag of the key that will disarm oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        /// </summary>
        public static string GetTrapKeyTag(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(534);
            return NWN.Internal.NativeFunctions.StackPopStringUTF8();
        }

        /// <summary>
        ///  Get the DC for disarming oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        /// </summary>
        public static int GetTrapDisarmDC(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(535);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the DC for detecting oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        /// </summary>
        public static int GetTrapDetectDC(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(536);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the trap nearest to oTarget.
        ///  Note : "trap objects" are actually any trigger, placeable or door that is
        ///  trapped in oTarget's area.
        ///  - oTarget
        ///  - nTrapDetected: if this is TRUE, the trap returned has to have been detected
        ///    by oTarget.
        /// </summary>
        public static uint GetNearestTrapToObject(uint oTarget = OBJECT_INVALID, bool nTrapDetected = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nTrapDetected? 0 : 1);
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.CallBuiltIn(488);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Get the last trap detected by oTarget.
        ///  * Return value on error: OBJECT_INVALID
        /// </summary>
        public static uint GetLastTrapDetected(uint oTarget = OBJECT_INVALID)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.CallBuiltIn(486);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns TRUE if oTrapObject is active
        /// </summary>
        public static bool GetTrapActive(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(821);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  Sets whether or not the trap is an active trap
        ///  - oTrapObject: a placeable, door or trigger
        ///  - nActive: TRUE/FALSE
        ///  Notes:
        ///  Setting a trap as inactive will not make the
        ///  trap disappear if it has already been detected.
        ///  Call SetTrapDetectedBy() to make a detected trap disappear.
        ///  To make an inactive trap not detectable call SetTrapDetectable()
        /// </summary>
        public static void SetTrapActive(uint oTrapObject, bool nActive = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nActive? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(822);
        }

        /// <summary>
        ///  - oTrapObject: a placeable, door or trigger
        ///  * Returns TRUE if oTrapObject can be recovered.
        /// </summary>
        public static bool GetTrapRecoverable(uint oTrapObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(815);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  Sets whether or not the trapped object can be recovered.
        ///  - oTrapObject: a placeable, door or trigger
        /// </summary>
        public static void SetTrapRecoverable(uint oTrapObject, bool nRecoverable = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nRecoverable? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(816);
        }

        /// <summary>
        ///  Sets whether or not the trapped object can be disarmed.
        ///  - oTrapObject: a placeable, door or trigger
        ///  - nDisarmable: TRUE/FALSE
        /// </summary>
        public static void SetTrapDisarmable(uint oTrapObject, bool nDisarmable = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDisarmable? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(803);
        }

        /// <summary>
        ///  Sets whether or not the trapped object can be detected.
        ///  - oTrapObject: a placeable, door or trigger
        ///  - nDetectable: TRUE/FALSE
        ///  Note: Setting a trapped object to not be detectable will
        ///  not make the trap disappear if it has already been detected.
        /// </summary>
        public static void SetTrapDetectable(uint oTrapObject, bool nDetectable = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDetectable? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(804);
        }

        /// <summary>
        ///  Sets whether or not the trap is a one-shot trap
        ///  (i.e. whether or not the trap resets itself after firing).
        ///  - oTrapObject: a placeable, door or trigger
        ///  - nOneShot: TRUE/FALSE
        /// </summary>
        public static void SetTrapOneShot(uint oTrapObject, bool nOneShot = true)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nOneShot? 1 : 0);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(805);
        }

        /// <summary>
        ///  Set the tag of the key that will disarm oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        /// </summary>
        public static void SetTrapKeyTag(uint oTrapObject, string sKeyTag)
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sKeyTag);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(806);
        }

        /// <summary>
        ///  Set the DC for disarming oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        ///  - nDisarmDC: must be between 0 and 250.
        /// </summary>
        public static void SetTrapDisarmDC(uint oTrapObject, int nDisarmDC)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDisarmDC);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(807);
        }

        /// <summary>
        ///  Set the DC for detecting oTrapObject.
        ///  - oTrapObject: a placeable, door or trigger
        ///  - nDetectDC: must be between 0 and 250.
        /// </summary>
        public static void SetTrapDetectDC(uint oTrapObject, int nDetectDC)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nDetectDC);
            NWN.Internal.NativeFunctions.StackPushObject(oTrapObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(808);
        }

        /// <summary>
        ///  Creates a square Trap object.
        ///  - nTrapType: The base type of trap (TRAP_BASE_TYPE_*)
        ///  - lLocation: The location and orientation that the trap will be created at.
        ///  - fSize: The size of the trap. Minimum size allowed is 1.0f.
        ///  - sTag: The tag of the trap being created.
        ///  - nFaction: The faction of the trap (STANDARD_FACTION_*).
        ///  - sOnDisarmScript: The OnDisarm script that will fire when the trap is disarmed.
        ///                     If "" no script will fire.
        ///  - sOnTrapTriggeredScript: The OnTrapTriggered script that will fire when the
        ///                            trap is triggered.
        ///                            If "" the default OnTrapTriggered script for the trap
        ///                            type specified will fire instead (as specified in the
        ///                            traps.2da).
        /// </summary>
        public static uint CreateTrapAtLocation(TrapBaseType nTrapType, NWN.Location lLocation, float fSize = 2.0f, string sTag = "", Faction nFaction = Faction.Hostile, string sOnDisarmScript = "", string sOnTrapTriggeredScript = "")
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sOnTrapTriggeredScript);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sOnDisarmScript);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nFaction);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sTag);
            NWN.Internal.NativeFunctions.StackPushFloat(fSize);
            NWN.Internal.NativeFunctions.StackPushLocation(lLocation.Handle);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nTrapType);
            NWN.Internal.NativeFunctions.CallBuiltIn(809);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  Creates a Trap on the object specified.
        ///  - nTrapType: The base type of trap (TRAP_BASE_TYPE_*)
        ///  - oObject: The object that the trap will be created on. Works only on Doors and Placeables.
        ///  - nFaction: The faction of the trap (STANDARD_FACTION_*).
        ///  - sOnDisarmScript: The OnDisarm script that will fire when the trap is disarmed.
        ///                     If "" no script will fire.
        ///  - sOnTrapTriggeredScript: The OnTrapTriggered script that will fire when the
        ///                            trap is triggered.
        ///                            If "" the default OnTrapTriggered script for the trap
        ///                            type specified will fire instead (as specified in the
        ///                            traps.2da).
        ///  Note: After creating a trap on an object, you can change the trap's properties
        ///        using the various SetTrap* scripting commands by passing in the object
        ///        that the trap was created on (i.e. oObject) to any subsequent SetTrap* commands.
        /// </summary>
        public static void CreateTrapOnObject(int nTrapType, uint oObject, Faction nFaction = Faction.Hostile, string sOnDisarmScript = "", string sOnTrapTriggeredScript = "")
        {
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sOnTrapTriggeredScript);
            NWN.Internal.NativeFunctions.StackPushStringUTF8(sOnDisarmScript);
            NWN.Internal.NativeFunctions.StackPushInteger((int)nFaction);
            NWN.Internal.NativeFunctions.StackPushObject(oObject);
            NWN.Internal.NativeFunctions.StackPushInteger(nTrapType);
            NWN.Internal.NativeFunctions.CallBuiltIn(810);
        }

        /// <summary>
        ///  Disable oTrap.
        ///  - oTrap: a placeable, door or trigger.
        /// </summary>
        public static void SetTrapDisabled(uint oTrap)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTrap);
            NWN.Internal.NativeFunctions.CallBuiltIn(555);
        }
    }
}