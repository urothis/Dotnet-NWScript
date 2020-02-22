namespace NWN.Enums
{
    public enum DamageType
    {
        BLUDGEONING = 1,
        PIERCING = 2,
        SLASHING = 4,
        MAGICAL = 8,
        ACID = 16,
        COLD = 32,
        DIVINE = 64,
        ELECTRICAL = 128,
        FIRE = 256,
        NEGATIVE = 512,
        POSITIVE = 1024,
        SONIC = 2048,
        // The base weapon damage is the base damage delivered by the weapon before
        // any additional types of damage (e.g. fire) have been added.
        BASE_WEAPON = 4096
    }
}