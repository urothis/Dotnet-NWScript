using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  math operations
        ///  Maths operation: absolute value of fValue
        /// </summary>
        public static float fabs(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(67);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: cosine of fValue
        /// </summary>
        public static float cos(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(68);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: sine of fValue
        /// </summary>
        public static float sin(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(69);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: tan of fValue
        /// </summary>
        public static float tan(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(70);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: arccosine of fValue
        ///  * Returns zero if fValue > 1 or fValue < -1
        /// </summary>
        public static float acos(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(71);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: arcsine of fValue
        ///  * Returns zero if fValue >1 or fValue < -1
        /// </summary>
        public static float asin(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(72);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: arctan of fValue
        /// </summary>
        public static float atan(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(73);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: log of fValue
        ///  * Returns zero if fValue <= zero
        /// </summary>
        public static float log(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(74);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: fValue is raised to the power of fExponent
        ///  * Returns zero if fValue ==0 and fExponent <0
        /// </summary>
        public static float pow(float fValue, float fExponent)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fExponent);
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(75);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: square root of fValue
        ///  * Returns zero if fValue <0
        /// </summary>
        public static float sqrt(float fValue)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(76);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Maths operation: integer absolute value of nValue
        ///  * Return value on error: 0
        /// </summary>
        public static int abs(int nValue)
        {
            NWN.Internal.NativeFunctions.StackPushInteger(nValue);
            NWN.Internal.NativeFunctions.CallBuiltIn(77);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Normalize vVector
        /// </summary>
        public static NWN.Vector VectorNormalize(NWN.Vector? vVector)
        {
            NWN.Internal.NativeFunctions.StackPushVector(vVector.HasValue ? vVector.Value : new NWN.Vector());
            NWN.Internal.NativeFunctions.CallBuiltIn(137);
            return NWN.Internal.NativeFunctions.StackPopVector();
        }

        /// <summary>
        ///  Get the magnitude of vVector; this can be used to determine the
        ///  distance between two points.
        ///  * Return value on error: 0.0f
        /// </summary>
        public static float VectorMagnitude(NWN.Vector? vVector)
        {
            NWN.Internal.NativeFunctions.StackPushVector(vVector.HasValue ? vVector.Value : new NWN.Vector());
            NWN.Internal.NativeFunctions.CallBuiltIn(104);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Convert fFeet into a number of meters.
        /// </summary>
        public static float FeetToMeters(float fFeet)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fFeet);
            NWN.Internal.NativeFunctions.CallBuiltIn(218);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Convert fYards into a number of meters.
        /// </summary>
        public static float YardsToMeters(float fYards)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fYards);
            NWN.Internal.NativeFunctions.CallBuiltIn(219);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Get the distance from the caller to oObject in metres.
        ///  * Return value on error: -1.0f
        /// </summary>
        public static float GetDistanceToObject(uint oObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(41);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }

        /// <summary>
        ///  Returns whether or not there is a direct line of sight
        ///  between the two objects. (Not blocked by any geometry).
        ///
        ///  PLEASE NOTE: This is an expensive function and may
        ///               degrade performance if used frequently.
        /// </summary>
        public static int LineOfSightObject(uint oSource, uint oTarget)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.StackPushObject(oSource);
            NWN.Internal.NativeFunctions.CallBuiltIn(752);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Returns whether or not there is a direct line of sight
        ///  between the two vectors. (Not blocked by any geometry).
        ///
        ///  This function must be run on a valid object in the area
        ///  it will not work on the module or area.
        ///
        ///  PLEASE NOTE: This is an expensive function and may
        ///               degrade performance if used frequently.
        /// </summary>
        public static int LineOfSightVector(NWN.Vector? vSource, NWN.Vector? vTarget)
        {
            NWN.Internal.NativeFunctions.StackPushVector(vTarget.HasValue ? vTarget.Value : new NWN.Vector());
            NWN.Internal.NativeFunctions.StackPushVector(vSource.HasValue ? vSource.Value : new NWN.Vector());
            NWN.Internal.NativeFunctions.CallBuiltIn(753);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Convert fAngle to a vector
        /// </summary>
        public static NWN.Vector AngleToVector(float fAngle)
        {
            NWN.Internal.NativeFunctions.StackPushFloat(fAngle);
            NWN.Internal.NativeFunctions.CallBuiltIn(144);
            return NWN.Internal.NativeFunctions.StackPopVector();
        }

        /// <summary>
        ///  Convert vVector to an angle
        /// </summary>
        public static float VectorToAngle(NWN.Vector? vVector)
        {
            NWN.Internal.NativeFunctions.StackPushVector(vVector.HasValue ? vVector.Value : new NWN.Vector());
            NWN.Internal.NativeFunctions.CallBuiltIn(145);
            return NWN.Internal.NativeFunctions.StackPopFloat();
        }
    }
}