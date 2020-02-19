namespace NWN
{
    public class NWPlaceable : NWStationary
    {
        public NWPlaceable(uint oid) : base(oid) {}

        public virtual bool IsUseable
        {
            get => NWScript.GetUseableFlag(this);
            set => NWScript.SetUseableFlag(this, value);
        }
        public virtual bool IsIlluminated
        {
            get => NWScript.GetPlaceableIllumination(this);
            set => NWScript.SetPlaceableIllumination(this, value);
        }
        public virtual NWCreature SittingCreature => NWScript.GetSittingCreature(this).AsCreature();

        public bool IsStatic
        {
            get => NWNX.Object.GetPlaceableIsStatic(this);
            set => NWNX.Object.SetPlaceableIsStatic(this, value);
        }
    }
}
