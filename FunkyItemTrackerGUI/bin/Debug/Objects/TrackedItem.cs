using System;
using System.Drawing;
using FunkyItemTrackerGUI.Enums;

namespace FunkyItemTrackerGUI.Objects
{
	public class TrackedItem
	{
		public string InternalName { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
		public TrackerItemQuality Quality { get; set; }
		public int Gold { get; set; }
		public int SNO { get; set; }
		public int BalanceId { get; set; }
		public bool OneHanded { get; set; }
		public TrackerDyeType DyeType { get; set; }
		public TrackerItemType Type { get; set; }
		public TrackerFollowerType FollowerType { get; set; }
		public bool IsUnidentified { get; set; }
		public bool IsPotion { get; set; }
		public int StackQuantity { get; set; }
		public int invRow { get; set; }
		public int invCol { get; set; }
		public bool IsVendorBought { get; set; }
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
				case TrackerItemType.CraftingReagent:
				case TrackerItemType.CraftingPage:
				case TrackerItemType.CraftingPlan:
				case TrackerItemType.FollowerSpecial:
				case TrackerItemType.HoradricCache:
				case TrackerItemType.KeystoneFragment:
					return "demonorgan.png";
			}

			return String.Empty;
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
			SNO = -1;
			BalanceId = -1;
			InternalName = "Null";
			Name = "Null";
			Gold = -1;
			Level = -1;
			StackQuantity = -1;
			Type = TrackerItemType.Unknown;
			DyeType = TrackerDyeType.None;
			invRow = -1;
			invCol = -1;
			ItemStats = new ItemProperties();
		}


	}



}