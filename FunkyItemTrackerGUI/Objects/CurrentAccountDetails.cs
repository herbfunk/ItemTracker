

namespace FunkyItemTrackerGUI.Objects
{
	public class CurrentAccountDetails
	{
		public string BattleTag { get; set; }
		public Character Hero { get; set; }
		
		public CurrentAccountDetails()
		{
			BattleTag = "";
			Hero = new Character();
		}


		public override bool Equals(object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}


			CurrentAccountDetails p = obj as CurrentAccountDetails;
			if (p == null)
			{
				return false;
			}

			// Return true if the fields match:
			return (BattleTag == p.BattleTag) && (Hero.Equals(p.Hero));
		}
	}
}
