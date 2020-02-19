using System.Collections.Generic;
using System.Linq;
using NWN.Enums;

namespace NWN
{
    public class NWItem : NWObject
    {
        public NWItem(uint oid) : base(oid) {}

        public virtual NWObject Possessor => NWScript.GetItemPossessor(this).AsObject();

        public virtual BaseItem BaseItemType
        {
            get => (BaseItem)NWScript.GetBaseItemType(this);
            set => NWNX.Item.SetBaseItemType(this, value);
        }

        public virtual bool IsDroppable
        {
            get => NWScript.GetDroppableFlag(this);
            set => NWScript.SetDroppableFlag(this, value);
        }

        public virtual bool IsCursed
        {
            get => NWScript.GetItemCursedFlag(this);
            set => NWScript.SetItemCursedFlag(this, value);
        }

        public virtual bool IsStolen
        {
            get => NWScript.GetStolenFlag(this);
            set => NWScript.SetStolenFlag(this, value);
        }

        public virtual bool IsIdentified
        {
            get => NWScript.GetIdentified(this);
            set => NWScript.SetIdentified(this, value);
        }
        public virtual int AC => NWScript.GetItemACValue(this);
        public virtual int BaseAC => NWNX.Item.GetBaseArmorClass(this);

        public virtual int Charges
        {
            get => NWScript.GetItemCharges(this);
            set => NWScript.SetItemCharges(this, value);
        }

        public virtual int StackSize
        {
            get => NWScript.GetItemStackSize(this);
            set => NWScript.SetItemStackSize(this, value);
        }

        public virtual int Weight
        {
            get => NWScript.GetWeight(this);
            set => NWNX.Item.SetWeight(this, value);
        }
        public int BaseGoldPieceValue
        {
            get => NWNX.Item.GetBaseGoldPieceValue(this);
            set => NWNX.Item.SetBaseGoldPieceValue(this, value);
        }
        public int AddGoldPieceValue
        {
            get => NWNX.Item.GetAddGoldPieceValue(this);
            set => NWNX.Item.SetAddGoldPieceValue(this, value);
        }

        public virtual string UnidentifiedDescription
        {
            get => NWScript.GetDescription(this, false, false);
            set => NWScript.SetDescription(this, value, false);
        }

        public virtual IEnumerable<ItemProperty> ItemProperties
        {
            get
            {
                for (var ip = NWScript.GetFirstItemProperty(this);
                    NWScript.GetIsItemPropertyValid(ip) == 1;
                    ip = NWScript.GetNextItemProperty(this))
                {
                    yield return ip;
                }
            }
        }

        public virtual bool IsRanged => NWScript.GetWeaponRanged(this);
    }
}
