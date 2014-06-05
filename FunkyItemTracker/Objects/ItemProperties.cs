using Zeta.Game.Internals;

namespace FunkyItemTracker.Objects
{
	public class ItemProperties
	{
		public float Dexterity { get; set; }
		public float Intelligence { get; set; }
		public float Strength { get; set; }
		public float Vitality { get; set; }

		public float ResistAll { get; set; }
		public float ResistArcane { get; set; }
		public float ResistCold { get; set; }
		public float ResistFire { get; set; }
		public float ResistHoly { get; set; }
		public float ResistLightning { get; set; }
		public float ResistPhysical { get; set; }
		public float ResistPoison { get; set; }

		public float LifePercent { get; set; }

		public float LifeOnHit { get; set; }
		public float LifeSteal { get; set; }
		public float LifeOnKill { get; set; }
		public float HealthPerSpiritSpent { get; set; }
		public float HealthPerSecond { get; set; }

		public float MagicFind { get; set; }
		public float GoldFind { get; set; }
		public float MovementSpeed { get; set; }
		public float PickUpRadius { get; set; }

		public float Sockets { get; set; }

		public float CritPercent { get; set; }
		public float CritDamagePercent { get; set; }
		
		public float MinDamage { get; set; }
		public float MaxDamage { get; set; }

		public float AttackSpeedPercent { get; set; }
		public float AttackSpeedPercentBonus { get; set; }


		public float BlockChance { get; set; }
		public float BlockChanceBonus { get; set; }

		public float Thorns { get; set; }

		
		
		public float MaxDiscipline { get; set; }
		public float MaxMana { get; set; }
		public float MaxArcanePower { get; set; }
		public float MaxFury { get; set; }
		public float MaxSpirit { get; set; }

		public float ArcaneOnCrit { get; set; }
		public float ManaRegen { get; set; }
		public float SpiritRegen { get; set; }
		public float HatredRegen { get; set; }

		public float ExperienceBonus { get; set; }
		public float GlobeBonus { get; set; }

		public float ArmorBonus { get; set; }
		public float Armor { get; set; }
		public float ArmorTotal { get; set; }

		public float Level { get; set; }
		public float ItemLevelRequirementReduction { get; set; }

		public float WeaponDamagePerSecond { get; set; }
		public float WeaponAttacksPerSecond { get; set; }
		public float WeaponDamagePercent { get; set; }
		public float WeaponMaxDamage { get; set; }
		public float WeaponMinDamage { get; set; }
		public float MinDamageElemental { get; set; }
		public float MaxDamageElemental { get; set; }

		public float PowerCooldownReductionPercent { get; set; }
		public float ResourceCostReductionPercent { get; set; }
		public float SkillDamagePercentBonus { get; set; }
		public float OnHitAreaDamageProcChance { get; set; }

		public float DamagePercentReductionFromElites { get; set; }
		public float DamageReductionPhysicalPercent { get; set; }
		public float DamagePercentBonusVsElites { get; set; }


		public float WeaponOnHitFearProcChance { get; set; }
		public float WeaponOnHitBlindProcChance { get; set; }
		public float WeaponOnHitFreezeProcChance { get; set; }
		public float WeaponOnHitChillProcChance { get; set; }
		public float WeaponOnHitImmobilizeProcChance { get; set; }
		public float WeaponOnHitKnockbackProcChance { get; set; }
		public float WeaponOnHitSlowProcChance { get; set; }
		public float WeaponOnHitBleedProcChance { get; set; }


		public float MaxDamageFire { get; set; }
		public float MinDamageFire { get; set; }
		public float FireSkillDamagePercentBonus { get; set; }

		public float MaxDamageLightning { get; set; }
		public float MinDamageLightning { get; set; }
		public float LightningSkillDamagePercentBonus { get; set; }

		public float MaxDamageCold { get; set; }
		public float MinDamageCold { get; set; }
		public float ColdSkillDamagePercentBonus { get; set; }

		public float MaxDamagePoison { get; set; }
		public float MinDamagePoison { get; set; }
		public float PosionSkillDamagePercentBonus { get; set; }

		public float MaxDamageArcane { get; set; }
		public float MinDamageArcane { get; set; }
		public float ArcaneSkillDamagePercentBonus { get; set; }

		public float MaxDamageHoly { get; set; }
		public float MinDamageHoly { get; set; }
		public float HolySkillDamagePercentBonus { get; set; }
		

		public ItemProperties() { }
		public ItemProperties(ItemStats thesestats)
		{
			MaxDamageHoly = thesestats.MaxDamageHoly;
			MinDamageHoly = thesestats.MinDamageHoly;
			HolySkillDamagePercentBonus = thesestats.HolySkillDamagePercentBonus;

			MaxDamageArcane = thesestats.MaxDamageArcane;
			MinDamageArcane = thesestats.MinDamageArcane;
			ArcaneSkillDamagePercentBonus = thesestats.ArcaneSkillDamagePercentBonus;

			MaxDamagePoison = thesestats.MaxDamagePoison;
			MinDamagePoison = thesestats.MinDamagePoison;
			PosionSkillDamagePercentBonus = thesestats.PosionSkillDamagePercentBonus;

			MaxDamageCold = thesestats.MaxDamageCold;
			MinDamageCold = thesestats.MinDamageCold;
			ColdSkillDamagePercentBonus = thesestats.ColdSkillDamagePercentBonus;

			MaxDamageLightning = thesestats.MaxDamageLightning;
			MinDamageLightning = thesestats.MinDamageLightning;
			LightningSkillDamagePercentBonus = thesestats.LightningSkillDamagePercentBonus;

			MaxDamageFire = thesestats.MaxDamageFire;
			MinDamageFire = thesestats.MinDamageFire;
			FireSkillDamagePercentBonus = thesestats.FireSkillDamagePercentBonus;


			WeaponOnHitFearProcChance = thesestats.WeaponOnHitFearProcChance;
			WeaponOnHitBlindProcChance = thesestats.WeaponOnHitBlindProcChance;
			WeaponOnHitFreezeProcChance = thesestats.WeaponOnHitFreezeProcChance;
			WeaponOnHitChillProcChance = thesestats.WeaponOnHitChillProcChance;
			WeaponOnHitImmobilizeProcChance = thesestats.WeaponOnHitImmobilizeProcChance;
			WeaponOnHitKnockbackProcChance = thesestats.WeaponOnHitKnockbackProcChance;
			WeaponOnHitSlowProcChance = thesestats.WeaponOnHitSlowProcChance;
			WeaponOnHitBleedProcChance = thesestats.WeaponOnHitBleedProcChance;

			DamagePercentBonusVsElites = thesestats.DamagePercentBonusVsElites;
			DamagePercentReductionFromElites = thesestats.DamagePercentReductionFromElites;
			DamageReductionPhysicalPercent = thesestats.DamageReductionPhysicalPercent;

			PowerCooldownReductionPercent=thesestats.PowerCooldownReductionPercent;
			ResourceCostReductionPercent = thesestats.ResourceCostReductionPercent;
			SkillDamagePercentBonus=thesestats.SkillDamagePercentBonus;
			OnHitAreaDamageProcChance = thesestats.OnHitAreaDamageProcChance;

			ArmorBonus = thesestats.ArmorBonus;
			Armor=thesestats.Armor;
			ArmorTotal=thesestats.ArmorTotal;

			Level = thesestats.Level;
			ItemLevelRequirementReduction = thesestats.ItemLevelRequirementReduction;

			ArcaneOnCrit = thesestats.ArcaneOnCrit;

			AttackSpeedPercent = thesestats.AttackSpeedPercent;
			AttackSpeedPercentBonus = thesestats.AttackSpeedPercentBonus;

			BlockChance = thesestats.BlockChance;
			BlockChanceBonus = thesestats.BlockChanceBonus;

			CritPercent = thesestats.CritPercent;
			CritDamagePercent = thesestats.CritDamagePercent;
			Dexterity = thesestats.Dexterity;
			ExperienceBonus = thesestats.ExperienceBonus;
			Intelligence = thesestats.Intelligence;

			LifePercent = thesestats.LifePercent;
			LifeOnHit = thesestats.LifeOnHit;
			LifeSteal = thesestats.LifeSteal;
			LifeOnKill=thesestats.LifeOnKill;
			HealthPerSpiritSpent = thesestats.HealthPerSpiritSpent;

			HealthPerSecond = thesestats.HealthPerSecond;
			MagicFind = thesestats.MagicFind;
			GoldFind = thesestats.GoldFind;
			GlobeBonus = thesestats.HealthGlobeBonus;
			MovementSpeed = thesestats.MovementSpeed;
			PickUpRadius = thesestats.PickUpRadius;

			ResistAll = thesestats.ResistAll;
			ResistArcane = thesestats.ResistArcane;
			ResistCold = thesestats.ResistCold;
			ResistFire = thesestats.ResistFire;
			ResistHoly = thesestats.ResistHoly;
			ResistLightning = thesestats.ResistLightning;
			ResistPhysical = thesestats.ResistPhysical;
			ResistPoison = thesestats.ResistPoison;


			MinDamage = thesestats.MinDamage;
			MaxDamage = thesestats.MaxDamage;
			MinDamageElemental = thesestats.MinDamageElemental;
			MaxDamageElemental = thesestats.MaxDamageElemental;

			MaxDiscipline = thesestats.MaxDiscipline;
			MaxMana = thesestats.MaxMana;
			MaxArcanePower = thesestats.MaxArcanePower;
			MaxFury = thesestats.MaxFury;
			MaxSpirit = thesestats.MaxSpirit;

			ManaRegen = thesestats.ManaRegen;
			HatredRegen = thesestats.HatredRegen;

			Thorns = thesestats.Thorns;

			Sockets = thesestats.Sockets;
			SpiritRegen = thesestats.SpiritRegen;
			Strength = thesestats.Strength;
			Vitality = thesestats.Vitality;
			WeaponDamagePerSecond = thesestats.WeaponDamagePerSecond;
			WeaponAttacksPerSecond = thesestats.WeaponAttacksPerSecond;
			WeaponMaxDamage=thesestats.WeaponMaxDamage;
			WeaponMinDamage = thesestats.WeaponMinDamage;
			WeaponDamagePercent = thesestats.WeaponDamagePercent;
		}
	}
}
