using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeta.Game;

namespace FunkyItemTracker.Objects
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

		public bool Update()
		{
			try
			{
				BattleTag = ZetaDia.Service.Hero.BattleTagName;
				Hero.Name = ZetaDia.Service.Hero.Name;
				Hero.Level = ZetaDia.Service.Hero.Level;
				Hero.Class = ZetaDia.Service.Hero.Class;
			}
			catch (Exception)
			{
				return false;
			}

			return true;
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
