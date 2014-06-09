using System;
using System.Drawing;
using System.Linq;
using FunkyItemTrackerGUI.Enums;

namespace FunkyItemTrackerGUI.Objects
{
	public class TrackedItem
	{
		public string Name { get; set; }
		public string InternalName { get; set; }
		public int SNO { get; set; }
		public int BalanceId { get; set; }

		public int Level { get; set; }
		public TrackerItemQuality Quality { get; set; }
		public int Gold { get; set; }
		public bool OneHanded { get; set; }
		public TrackerDyeType DyeType { get; set; }
		public TrackerItemType Type { get; set; }
		public TrackerItemBaseType BaseType { get; set; }
		public TrackerFollowerType FollowerType { get; set; }
		public bool IsUnidentified { get; set; }
		public bool IsPotion { get; set; }
		public int StackQuantity { get; set; }
		public int invRow { get; set; }
		public int invCol { get; set; }
		public TrackerInventorySlot InventorySlot { get; set; }
		public bool IsVendorBought { get; set; }
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
	
		
		public ItemProperties ItemStats { get; set; }

		public string GetImageIcon()
		{
			switch (Type)
			{
				case TrackerItemType.Unknown:
					break;
				case TrackerItemType.Axe:
					if (OneHanded) return "axe.png"; 
					return "axe_2h.png";
				case TrackerItemType.Sword:
					if (OneHanded) return "sword.png"; 
					return "sword_2h.png";
				case TrackerItemType.Mace:
					if (OneHanded) return "mace.png"; 
					return "mace_2h.png";
				case TrackerItemType.Dagger:
					return "dagger.png";
				case TrackerItemType.Flail:
					if (OneHanded) return "flail.png"; 
					return "flail_2h.png";
				case TrackerItemType.Bow:
					return "bow.png";
				case TrackerItemType.Crossbow:
					return "crossbow.png";
				case TrackerItemType.Staff:
					return "staff.png";
				case TrackerItemType.Spear:
					return "spear.png";
				case TrackerItemType.Shield:
					return "shield.png";
				case TrackerItemType.CrusaderShield:
					return "crusadershield.png";
				case TrackerItemType.Gloves:
					return "gloves.png";
				case TrackerItemType.Boots:
					return "boots.png";
				case TrackerItemType.Chest:
					return "chestarmor.png";
				case TrackerItemType.Ring:
					return "ring.png";
				case TrackerItemType.Amulet:
					return "amulet.png";
				case TrackerItemType.Quiver:
					return "quiver.png";
				case TrackerItemType.Shoulder:
					return "shoulders.png";
				case TrackerItemType.Legs:
					return "pants.png";
				case TrackerItemType.FistWeapon:
					return "fistweapon.png";
				case TrackerItemType.Mojo:
					return "mojo.png";
				case TrackerItemType.CeremonialDagger:
					return "ceremonialdagger.png";
				case TrackerItemType.WizardHat:
					return "helm.png";
				case TrackerItemType.Helm:
					return "helm.png";
				case TrackerItemType.Belt:
					return "belt.png";
				case TrackerItemType.Bracer:
					return "bracers.png";
				case TrackerItemType.Orb:
					return "orb.png";
				case TrackerItemType.MightyWeapon:
					if (OneHanded) return "mightyweapon.png"; 
					return "mightyweapon_2h.png";
				case TrackerItemType.MightyBelt:
					return "belt.png";
				case TrackerItemType.Polearm:
					return "polearm.png";
				case TrackerItemType.Cloak:
					return "chestarmor.png";
				case TrackerItemType.Wand:
					return "wand.png";
				case TrackerItemType.SpiritStone:
					return "helm.png";
				case TrackerItemType.Daibo:
					return "combatstaff.png";
				case TrackerItemType.HandCrossbow:
					return "handxbow.png";
				case TrackerItemType.VoodooMask:
					return "helm.png";
				case TrackerItemType.Potion:
					return "healthpotionconsole.png";

				case TrackerItemType.Gem:
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
				case TrackerItemType.CraftingReagent:
					if (SNO==361984)
						return "crafting_assortedparts.png";
					if (SNO==361985)
						return "crafting_magic.png";
					if (SNO==361986)
						return "crafting_rare.png";

					break;
				case TrackerItemType.CraftingPage:
				case TrackerItemType.CraftingPlan:
				case TrackerItemType.FollowerSpecial:
				case TrackerItemType.HoradricCache:
				case TrackerItemType.KeystoneFragment:
					return "demonorgan.png";
			}

			return "demonorgan.png";
		}

		public Brush GetBrushColor()
		{
			switch (Quality)
			{
				case TrackerItemQuality.Inferior:
					return Brushes.LightGray;
				case TrackerItemQuality.Normal:
				case TrackerItemQuality.Superior:
					return Brushes.DimGray;
				case TrackerItemQuality.Magic1:
				case TrackerItemQuality.Magic2:
				case TrackerItemQuality.Magic3:
					return Brushes.Blue;
				case TrackerItemQuality.Rare4:
				case TrackerItemQuality.Rare5:
				case TrackerItemQuality.Rare6:
					return Brushes.Yellow;
				case TrackerItemQuality.Legendary:
					return Brushes.Orange;
			}

			return Brushes.Black;
		}

		internal bool DetermineIsTwoSlot()
		{
			if (Type == TrackerItemType.Axe || Type == TrackerItemType.Boots || Type == TrackerItemType.Bow || Type == TrackerItemType.Bracer ||
				Type == TrackerItemType.CeremonialDagger || Type == TrackerItemType.Chest || Type == TrackerItemType.Cloak || Type == TrackerItemType.Crossbow ||
				Type == TrackerItemType.CrusaderShield || Type == TrackerItemType.Dagger || Type == TrackerItemType.Daibo || Type == TrackerItemType.FistWeapon ||
				Type == TrackerItemType.Flail || Type == TrackerItemType.Gloves || Type == TrackerItemType.HandCrossbow || Type == TrackerItemType.Helm ||
				Type == TrackerItemType.HoradricCache || Type == TrackerItemType.Legs || Type == TrackerItemType.Mace || Type == TrackerItemType.MightyWeapon ||
				Type == TrackerItemType.Mojo || Type == TrackerItemType.Orb || Type == TrackerItemType.Polearm || Type == TrackerItemType.Quiver ||
				Type == TrackerItemType.Shield || Type == TrackerItemType.Shoulder || Type == TrackerItemType.Spear || Type == TrackerItemType.SpiritStone ||
				Type == TrackerItemType.Staff || Type == TrackerItemType.Sword || Type == TrackerItemType.VoodooMask || Type == TrackerItemType.Wand || Type == TrackerItemType.WizardHat)
				return true;

			return false;
		}


		public TrackedItem()
		{
			Name = "Null";
			InternalName = "Null";
			SNO = -1;
			BalanceId = -1;
			
			
			Gold = -1;
			Level = -1;
			StackQuantity = -1;
			Type = TrackerItemType.Unknown;
			DyeType = TrackerDyeType.None;
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
			BaseType = TrackerItemBaseType.None;
			InventorySlot = TrackerInventorySlot.None;

			ItemStats = new ItemProperties();
		}

		internal string ReturnItemString()
		{
			var primaryStats=ItemStats.GetPrimaryStatStrings();
			var secondaryStats=ItemStats.GetSecondaryStatStrings();
			var itemMainStat=ItemStats.ReturnItemMainStatString();
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
						StackQuantity,MaxStackCount,
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