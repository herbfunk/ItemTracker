using System;
using System.Collections.Generic;
using FunkyItemTrackerGUI.Enums;


namespace FunkyItemTrackerGUI.Objects
{
	public class Character
	{


		public string Name { get; set; }
		public int Level { get; set; }
		public TrackerActorClass Class { get; set; }
		public List<TrackedItem> InventoryItems { get; set; }
		public List<TrackedItem> EquippedItems { get; set; } 

		public string GetImageIcon()
		{
			switch (Class)
			{
				case TrackerActorClass.DemonHunter:
					return "demonhunter_male.png";
				case TrackerActorClass.Barbarian:
					return "barbarian_male.png";
				case TrackerActorClass.Wizard:
					return "wizard_male.png";
				case TrackerActorClass.Witchdoctor:
					return "witchdoctor_male.png";
				case TrackerActorClass.Monk:
					return "monk_male.png";
				case TrackerActorClass.Crusader:
					return "crusader_male.png";
			}

			return String.Empty;
		}

		public Character()
		{
			Name = "";
			Level = -1;
			Class = TrackerActorClass.Invalid;
			InventoryItems = new List<TrackedItem>();
			EquippedItems = new List<TrackedItem>();
		}
		public Character(string CharacterName, int level, TrackerActorClass AC)
		{
			Name = CharacterName;
			Level = level;
			Class = AC;
			InventoryItems = new List<TrackedItem>();
			EquippedItems = new List<TrackedItem>();
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Character) obj);
		}
		protected bool Equals(Character other)
		{
			return string.Equals(Name, other.Name) && Class == other.Class;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = (Name != null ? Name.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ Level;
				hashCode = (hashCode * 397) ^ (int)Class;
				return hashCode;
			}
		}
	}
}
