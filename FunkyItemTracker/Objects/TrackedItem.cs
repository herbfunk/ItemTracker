using Zeta.Game.Internals;
using Zeta.Game.Internals.Actors;

namespace FunkyItemTracker.Objects
{
	public class TrackedItem
	{
		public string InternalName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public ItemQuality Quality { get; set; }
		public int Gold { get; set; }
		public int SNO { get; set; }
		public int BalanceId { get; set; }
		public bool OneHanded { get; set; }
		public DyeType DyeType { get; set; }
		public ItemType Type { get; set; }
		public FollowerType FollowerType { get; set; }
		public bool IsUnidentified { get; set; }
		public bool IsPotion { get; set; }
		public int StackQuantity { get; set; }
		public int invRow { get; set; }
		public int invCol { get; set; }
		public bool IsVendorBought { get; set; }
		public ItemProperties ItemStats { get; set; }

		public TrackedItem(ACDItem item)
		{
			SNO=item.ActorSNO;
			BalanceId = item.GameBalanceId;
			InternalName = item.InternalName;
			Name = item.Name;
			Gold = item.Gold;
			Level = item.Level;
			StackQuantity = item.ItemStackQuantity;
			FollowerType = item.FollowerSpecialType;
			Quality = item.ItemQualityLevel;
			OneHanded = item.IsOneHand;
			IsUnidentified = item.IsUnidentified;
			Type = item.ItemType;
			DyeType = item.DyeType;
			IsPotion = item.IsPotion;
			invRow = item.InventoryRow;
			invCol = item.InventoryColumn;
			IsVendorBought = item.IsVendorBought;

			ItemStats thesestats = item.Stats;
			ItemStats = new ItemProperties(thesestats);
		}
		public TrackedItem()
		{
			SNO = -1;
			BalanceId = -1;
			InternalName = "Null";
			Name = "Null";
			Gold = -1;
			Level = -1;
			StackQuantity = -1;
			Type = ItemType.Unknown;
			DyeType = DyeType.None;
			invRow = -1;
			invCol = -1;
			ItemStats = new ItemProperties();
		}


	}



}