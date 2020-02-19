using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  Determine whether oObject is in conversation.
        /// </summary>
        public static bool IsInConversation(uint oObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(445);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }
    }
}