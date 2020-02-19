using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  * Returns TRUE if it is currently day.
        /// </summary>
        public static bool GetIsDay()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(405);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  * Returns TRUE if it is currently night.
        /// </summary>
        public static bool GetIsNight()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(406);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  * Returns TRUE if it is currently dawn.
        /// </summary>
        public static bool GetIsDawn()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(407);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  * Returns TRUE if it is currently dusk.
        /// </summary>
        public static bool GetIsDusk()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(408);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }


        /// <summary>
        ///  Convert nRounds into a number of seconds
        ///  A round is always 6.0 seconds
        /// </summary>
        public static float RoundsToSeconds(int nRounds)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nRounds);
            NWN.Internal.NativeFunctions.CallBuiltIn(121);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Convert nHours into a number of seconds
        ///  The result will depend on how many minutes there are per hour (game-time)
        /// </summary>
        public static float HoursToSeconds(int nHours)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nHours);
            NWN.Internal.NativeFunctions.CallBuiltIn(122);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Convert nTurns into a number of seconds
        ///  A turn is always 60.0 seconds
        /// </summary>
        public static float TurnsToSeconds(int nTurns)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nTurns);
            NWN.Internal.NativeFunctions.CallBuiltIn(123);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }
    }
}