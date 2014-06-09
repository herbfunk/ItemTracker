using System;
using System.Drawing;
using System.Linq;
using Zeta.Game;
using Zeta.Game.Internals;
using Zeta.Game.Internals.Actors;

namespace FunkyItemTracker.Objects
{
	public class TrackedItem
	{

		public string Name { get; set; }
		public string InternalName { get; set; }
		public int SNO { get; set; }
		public int BalanceId { get; set; }

		public bool IsArmor { get; set; }
		public bool IsCrafted { get; set; }
		public bool IsCraftingPage { get; set; }
		public bool IsCraftingReagent { get; set; }
		public bool IsElite { get; set; }
		public bool IsEquipped { get; set; }
		public bool IsGem { get; set; }
		public bool IsMiscItem { get; set; }
		public bool IsRare { get; set; }
		public bool IsTwoHand { get; set; }
		public bool IsTwoSquareItem { get; set; }
		public bool IsUnique { get; set; }
		public int RequiredLevel { get; set; }
		public int ItemLevelRequirementReduction { get; set; }
		public int MaxStackCount { get; set; }
		public int MaxDurability { get; set; }
		public int NumSockets { get; set; }
		public int NumSocketsFilled { get; set; }
		public int GemQuality { get; set; }
		public ItemBaseType BaseType { get; set; }





		public int Level { get; set; }

		public int Gold { get; set; }
		

		
		
		public bool OneHanded { get; set; }

		public ItemQuality Quality { get; set; }
		public DyeType DyeType { get; set; }
		public ItemType Type { get; set; }
		
		public FollowerType FollowerType { get; set; }


		public bool IsUnidentified { get; set; }
		public bool IsPotion { get; set; }
		public bool IsVendorBought { get; set; }
		public int StackQuantity { get; set; }
		public int invRow { get; set; }
		public int invCol { get; set; }
		public InventorySlot InventorySlot { get; set; }
		
		public ItemProperties ItemStats { get; set; }

		
		
		public TrackedItem(ACDItem item)
		{
			Name = item.Name;
			InternalName = item.InternalName;
			SNO = item.ActorSNO;
			BalanceId = item.GameBalanceId;
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
			InventorySlot = item.InventorySlot;
			IsArmor = item.IsArmor;
			IsCrafted = item.IsCrafted;
			IsCraftingPage = item.IsCraftingPage;
			IsCraftingReagent = item.IsCraftingReagent;
			IsElite = item.IsElite;
			IsEquipped = item.IsEquipped;
			IsGem = item.IsGem;
			IsMiscItem = item.IsMiscItem;
			IsRare = item.IsRare;
			IsTwoHand = item.IsTwoHand;
			IsTwoSquareItem = item.IsTwoSquareItem;
			IsUnique = item.IsUnique;
			RequiredLevel = item.RequiredLevel;
			ItemLevelRequirementReduction = item.ItemLevelRequirementReduction;
			MaxStackCount = item.MaxStackCount;
			MaxDurability = item.MaxDurability;
			NumSockets = item.NumSockets;
			GemQuality = item.GemQuality;
			BaseType = item.ItemBaseType;
			NumSocketsFilled = item.NumSocketsFilled;
			ItemStats thesestats = item.Stats;
			ItemStats = new ItemProperties(thesestats);
		}
		public TrackedItem()
		{


			InternalName = "Null";
			Name = "Null";
			SNO = -1;
			BalanceId = -1;
			Gold = -1;
			Level = -1;
			StackQuantity = -1;
			Type = ItemType.Unknown;
			DyeType = DyeType.None;
			invRow = -1;
			invCol = -1;
			IsArmor = false;
			IsCrafted = false;
			IsCraftingPage = false;
			IsCraftingReagent = false;
			IsElite = false;
			IsEquipped = false;
			IsGem = false;
			IsMiscItem = false;
			IsRare = false;
			IsTwoHand = false;
			IsTwoSquareItem = false;
			IsUnique = false;
			RequiredLevel = -1;
			ItemLevelRequirementReduction = -1;
			MaxStackCount = -1;
			MaxDurability = -1;
			NumSockets = -1;
			NumSocketsFilled = -1;
			GemQuality = -1;
			BaseType = ItemBaseType.None;
			InventorySlot = InventorySlot.None;
			ItemStats = new ItemProperties();
		}


		public string GetImageIcon()
		{
			switch (Type)
			{
				case ItemType.Unknown:
					break;
				case ItemType.Axe:
					if (OneHanded) return "axe.png";
					return "axe_2h.png";
				case ItemType.Sword:
					if (OneHanded) return "sword.png";
					return "sword_2h.png";
				case ItemType.Mace:
					if (OneHanded) return "mace.png";
					return "mace_2h.png";
				case ItemType.Dagger:
					return "dagger.png";
				case ItemType.Flail:
					if (OneHanded) return "flail.png";
					return "flail_2h.png";
				case ItemType.Bow:
					return "bow.png";
				case ItemType.Crossbow:
					return "crossbow.png";
				case ItemType.Staff:
					return "staff.png";
				case ItemType.Spear:
					return "spear.png";
				case ItemType.Shield:
					return "shield.png";
				case ItemType.CrusaderShield:
					return "crusadershield.png";
				case ItemType.Gloves:
					return "gloves.png";
				case ItemType.Boots:
					return "boots.png";
				case ItemType.Chest:
					return "chestarmor.png";
				case ItemType.Ring:
					return "ring.png";
				case ItemType.Amulet:
					return "amulet.png";
				case ItemType.Quiver:
					return "quiver.png";
				case ItemType.Shoulder:
					return "shoulders.png";
				case ItemType.Legs:
					return "pants.png";
				case ItemType.FistWeapon:
					return "fistweapon.png";
				case ItemType.Mojo:
					return "mojo.png";
				case ItemType.CeremonialDagger:
					return "ceremonialdagger.png";
				case ItemType.WizardHat:
					return "helm.png";
				case ItemType.Helm:
					return "helm.png";
				case ItemType.Belt:
					return "belt.png";
				case ItemType.Bracer:
					return "bracers.png";
				case ItemType.Orb:
					return "orb.png";
				case ItemType.MightyWeapon:
					if (OneHanded) return "mightyweapon.png";
					return "mightyweapon_2h.png";
				case ItemType.MightyBelt:
					return "belt.png";
				case ItemType.Polearm:
					return "polearm.png";
				case ItemType.Cloak:
					return "chestarmor.png";
				case ItemType.Wand:
					return "wand.png";
				case ItemType.SpiritStone:
					return "helm.png";
				case ItemType.Daibo:
					return "combatstaff.png";
				case ItemType.HandCrossbow:
					return "handxbow.png";
				case ItemType.VoodooMask:
					return "helm.png";
				case ItemType.Potion:
					return "healthpotionconsole.png";

				case ItemType.Gem:
					if (InternalName.StartsWith("Ruby"))
						return "ruby.png";
					if (InternalName.StartsWith("Topaz"))
						return "topaz.png";
					if (InternalName.StartsWith("Diamond"))
						return "diamond.png";
					if (InternalName.StartsWith("Amethyst"))
						return "amethyst.png";
					if (InternalName.StartsWith("Emerald"))
						return "emerald.png";

					break;
				case ItemType.CraftingReagent:
					if (SNO == 361984)
						return "crafting_assortedparts.png";
					if (SNO == 361985)
						return "crafting_magic.png";
					if (SNO == 361986)
						return "crafting_rare.png";

					break;
				case ItemType.CraftingPage:
				case ItemType.CraftingPlan:
				case ItemType.FollowerSpecial:
				case ItemType.HoradricCache:
				case ItemType.KeystoneFragment:
					return "demonorgan.png";
			}

			return "demonorgan.png";
		}
		public Brush GetBrushColor()
		{
			switch (Quality)
			{
				case ItemQuality.Inferior:
					return Brushes.LightGray;
				case ItemQuality.Normal:
				case ItemQuality.Superior:
					return Brushes.DimGray;
				case ItemQuality.Magic1:
				case ItemQuality.Magic2:
				case ItemQuality.Magic3:
					return Brushes.Blue;
				case ItemQuality.Rare4:
				case ItemQuality.Rare5:
				case ItemQuality.Rare6:
					return Brushes.Yellow;
				case ItemQuality.Legendary:
					return Brushes.Orange;
			}

			return Brushes.Black;
		}
		internal bool DetermineIsTwoSlot()
		{
			if (Type == ItemType.Axe || Type == ItemType.Boots || Type == ItemType.Bow || Type == ItemType.Bracer ||
				Type == ItemType.CeremonialDagger || Type == ItemType.Chest || Type == ItemType.Cloak || Type == ItemType.Crossbow ||
				Type == ItemType.CrusaderShield || Type == ItemType.Dagger || Type == ItemType.Daibo || Type == ItemType.FistWeapon ||
				Type == ItemType.Flail || Type == ItemType.Gloves || Type == ItemType.HandCrossbow || Type == ItemType.Helm ||
				Type == ItemType.HoradricCache || Type == ItemType.Legs || Type == ItemType.Mace || Type == ItemType.MightyWeapon ||
				Type == ItemType.Mojo || Type == ItemType.Orb || Type == ItemType.Polearm || Type == ItemType.Quiver ||
				Type == ItemType.Shield || Type == ItemType.Shoulder || Type == ItemType.Spear || Type == ItemType.SpiritStone ||
				Type == ItemType.Staff || Type == ItemType.Sword || Type == ItemType.VoodooMask || Type == ItemType.Wand || Type == ItemType.WizardHat)
				return true;

			return false;
		}
		internal string ReturnItemString()
		{
			var primaryStats = ItemStats.GetPrimaryStatStrings();
			var secondaryStats = ItemStats.GetSecondaryStatStrings();
			var itemMainStat = ItemStats.ReturnItemMainStatString();
			return String.Format("Item - Name: {0} (InternalName: {1})\r\n" +
						"ActorSNO: {2} BalanceID: {3}\r\n" +
						"ItemType: {4} ItemBaseType: {5} Quality: {6}\r\n" +
						"Level: {7} RequiredLevel: {8} ItemLevelRequirementReduction: {9}\r\n" +
						"Stack Quanity: {10} Max Stack Quanity: {11}" +
						"Row: {12} Column: {13} InventorySlot: {14}\r\n" +
						"IsCrafted: {15} IsCraftingPage: {16} IsCraftingReagent: {17}\r\n" +
						"IsGem: {18} GemQuality: {19}\r\n" +
						"IsArmor: {20} IsMiscItem: {21} IsOneHand: {22} IsTwoHand: {23} IsPotion: {24}\r\n" +
						"IsEquipped: {25} IsVendorBought: {26}\r\n" +
						"IsRare: {27} IsElite: {28} IsUnique: {29} \r\n" +
						"IsTwoSquareItem: {30} IsUnidentified: {31}  \r\n" +
						"MaxDurability: {32} NumSockets: {33} FilledSockets: {34}\r\n" +
						"{35}{36}{37}",

						Name, InternalName,
						SNO, BalanceId,
						Type, BaseType, Quality,
						Level, RequiredLevel, ItemLevelRequirementReduction,
						StackQuantity, MaxStackCount,
						invRow, invCol, InventorySlot,
						IsCrafted, IsCraftingPage, IsCraftingReagent,
						IsGem, GemQuality,
						IsArmor, IsMiscItem, OneHanded, IsTwoHand, IsPotion,
						IsEquipped, IsVendorBought,
						IsRare, IsElite, IsUnique,
						IsTwoSquareItem, IsUnidentified,
						MaxDurability, NumSockets, NumSocketsFilled,
						itemMainStat != String.Empty ? itemMainStat + "\r\n" : "",
						primaryStats.Count > 0 ? primaryStats.Aggregate("Primary Stats\r\n", (current, cb) => current + (cb + "\r\n")) : "",
						secondaryStats.Count > 0 ? secondaryStats.Aggregate("Secondary Stats\r\n", (current, cb) => current + (cb + "\r\n")) : "");

		}
	}



}