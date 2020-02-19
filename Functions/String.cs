using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {

        /// <summary>
        ///  Get the length of sString
        ///  * Return value on error: -1
        /// </summary>
        public static int GetStringLength(string sString)
        {
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(59);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Convert sString into upper case
        ///  * Return value on error: ""
        /// </summary>
        public static string GetStringUpperCase(string sString)
        {
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(60);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Convert sString into lower case
        ///  * Return value on error: ""
        /// </summary>
        public static string GetStringLowerCase(string sString)
        {
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(61);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Get nCount characters from the right end of sString
        ///  * Return value on error: ""
        /// </summary>
        public static string GetStringRight(string sString, int nCount)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nCount);
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(62);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Get nCounter characters from the left end of sString
        ///  * Return value on error: ""
        /// </summary>
        public static string GetStringLeft(string sString, int nCount)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nCount);
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(63);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Insert sString into sDestination at nPosition
        ///  * Return value on error: ""
        /// </summary>
        public static string InsertString(string sDestination, string sString, int nPosition)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nPosition);
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.StackPushString(sDestination);
            NWN.Internal.NativeFunctions.CallBuiltIn(64);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Get nCount characters from sString, starting at nStart
        ///  * Return value on error: ""
        /// </summary>
        public static string GetSubString(string sString, int nStart, int nCount)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nCount);
            NWN.Internal.NativeFunctions.StackPushInteger(nStart);
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(65);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Find the position of sSubstring inside sString
        ///  - nStart: The character position to start searching at (from the left end of the string).
        ///  * Return value on error: -1
        /// </summary>
        public static int FindSubString(string sString, string sSubString, int nStart = 0)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nStart);
            NWN.Internal.NativeFunctions.StackPushString(sSubString);
            NWN.Internal.NativeFunctions.StackPushString(sString);
            NWN.Internal.NativeFunctions.CallBuiltIn(66);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  * Returns TRUE if sStringToTest matches sPattern.
        /// </summary>
        public static int TestStringAgainstPattern(string sPattern, string sStringToTest)
        {
            NWN.Internal.NativeFunctions.StackPushString(sStringToTest);
            NWN.Internal.NativeFunctions.StackPushString(sPattern);
            NWN.Internal.NativeFunctions.CallBuiltIn(177);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Get the appropriate matched string (this should only be used in
        ///  OnConversation scripts).
        ///  * Returns the appropriate matched string, otherwise returns ""
        /// </summary>
        public static string GetMatchedSubstring(int nString)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nString);
            NWN.Internal.NativeFunctions.CallBuiltIn(178);
            return NWN.Internal.NativeFunctions.StackPopString();
        }

        /// <summary>
        ///  Get the number of string parameters available.
        ///  * Returns -1 if no string matched (this could be because of a dialogue event)
        /// </summary>
        public static int GetMatchedSubstringsCount()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(179);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }
    }
}