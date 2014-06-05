
using System;
using System.Collections.Generic;

namespace FunkyItemTrackerGUI.Objects
{
	public class ItemProperties
	{
		public List<string> GetStatStrings()
		{
			List<string> retList = new List<string>();
			if (Dexterity > 0) retList.Add(String.Format("Dexterity {0}", Dexterity));
			if (Intelligence > 0) retList.Add(String.Format("Intelligence {0}", Intelligence));
			if (Strength > 0) retList.Add(String.Format("Strength {0}", Strength));
			if (Vitality > 0) retList.Add(String.Format("Vitality {0}", Vitality));
			if (ResistAll > 0) retList.Add(String.Format("ResistAll {0}", ResistAll));
			if (LifePercent > 0) retList.Add(String.Format("LifePercent {0}", LifePercent));
			if (LifeOnHit > 0) retList.Add(String.Format("LifeOnHit {0}", LifeOnHit));
			if (LifeSteal > 0) retList.Add(String.Format("LifeSteal {0}", LifeSteal));
			if (HealthPerSpiritSpent > 0) retList.Add(String.Format("HealthPerSpiritSpent {0}", HealthPerSpiritSpent));
			if (HealthPerSecond > 0) retList.Add(String.Format("HealthPerSecond {0}", HealthPerSecond));
			if (MovementSpeed > 0) retList.Add(String.Format("MovementSpeed {0}", MovementSpeed));
			if (Sockets > 0) retList.Add(String.Format("Sockets {0}", Sockets));
			if (CritPercent > 0) retList.Add(String.Format("CritPercent {0}", CritPercent));
			if (CritDamagePercent > 0) retList.Add(String.Format("CritDamagePercent {0}", CritDamagePercent));
			if (MinDamage > 0) retList.Add(String.Format("MinDamage {0}", MinDamage));
			if (MaxDamage > 0) retList.Add(String.Format("MaxDamage {0}", MaxDamage));
			if (AttackSpeedPercent > 0) retList.Add(String.Format("AttackSpeedPercent {0}", AttackSpeedPercent));
			if (AttackSpeedPercentBonus > 0) retList.Add(String.Format("AttackSpeedPercentBonus {0}", AttackSpeedPercentBonus));
			if (BlockChanceBonus > 0) retList.Add(String.Format("BlockChanceBonus {0}", BlockChanceBonus));
			if (MaxDiscipline > 0) retList.Add(String.Format("MaxDiscipline {0}", MaxDiscipline));
			if (MaxMana > 0) retList.Add(String.Format("MaxMana {0}", MaxMana));
			if (MaxArcanePower > 0) retList.Add(String.Format("MaxArcanePower {0}", MaxArcanePower));
			if (MaxFury > 0) retList.Add(String.Format("MaxFury {0}", MaxFury));
			if (MaxSpirit > 0) retList.Add(String.Format("MaxSpirit {0}", MaxSpirit));
			if (ArcaneOnCrit > 0) retList.Add(String.Format("ArcaneOnCrit {0}", ArcaneOnCrit));
			if (ManaRegen > 0) retList.Add(String.Format("ManaRegen {0}", ManaRegen));
			if (SpiritRegen > 0) retList.Add(String.Format("SpiritRegen {0}", SpiritRegen));
			if (HatredRegen > 0) retList.Add(String.Format("HatredRegen {0}", HatredRegen));
			if (ArmorBonus > 0) retList.Add(String.Format("ArmorBonus {0}", ArmorBonus));

			if (ResistArcane > 0) retList.Add(String.Format("ResistArcane {0}", ResistArcane));
			if (ResistCold > 0) retList.Add(String.Format("ResistCold {0}", ResistCold));
			if (ResistFire > 0) retList.Add(String.Format("ResistFire {0}", ResistFire));
			if (ResistHoly > 0) retList.Add(String.Format("ResistHoly {0}", ResistHoly));
			if (ResistLightning > 0) retList.Add(String.Format("ResistLightning {0}", ResistLightning));
			if (ResistPhysical > 0) retList.Add(String.Format("ResistPhysical {0}", ResistPhysical));
			if (ResistPoison > 0) retList.Add(String.Format("ResistPoison {0}", ResistPoison));

			if (ExperienceBonus > 0) retList.Add(String.Format("ExperienceBonus {0}", ExperienceBonus));
			if (GlobeBonus > 0) retList.Add(String.Format("GlobeBonus {0}", GlobeBonus));
			if (ItemLevelRequirementReduction > 0) retList.Add(String.Format("ItemLevelRequirementReduction {0}", ItemLevelRequirementReduction));
			if (MagicFind > 0) retList.Add(String.Format("MagicFind {0}", MagicFind));
			if (GoldFind > 0) retList.Add(String.Format("GoldFind {0}", GoldFind));
			if (Thorns > 0) retList.Add(String.Format("Thorns {0}", Thorns));
			if (PickUpRadius > 0) retList.Add(String.Format("PickUpRadius {0}", PickUpRadius));
			if (LifeOnKill > 0) retList.Add(String.Format("LifeOnKill {0}", LifeOnKill));

			return retList;
		}

		public float ResistArcane { get; set; }
		public float ResistCold { get; set; }
		public float ResistFire { get; set; }
		public float ResistHoly { get; set; }
		public float ResistLightning { get; set; }
		public float ResistPhysical { get; set; }
		public float ResistPoison { get; set; }

		public float ExperienceBonus { get; set; }
		public float GlobeBonus { get; set; }
		public float ItemLevelRequirementReduction { get; set; }
		public float MagicFind { get; set; }
		public float GoldFind { get; set; }
		public float Thorns { get; set; }
		public float PickUpRadius { get; set; }
		public float LifeOnKill { get; set; }

		public float MaxDiscipline { get; set; }
		public float MaxMana { get; set; }
		public float MaxArcanePower { get; set; }
		public float MaxFury { get; set; }
		public float MaxSpirit { get; set; }

		public float ArcaneOnCrit { get; set; }
		public float ManaRegen { get; set; }
		public float SpiritRegen { get; set; }
		public float HatredRegen { get; set; }

		public float ArmorBonus { get; set; }
		public float Armor { get; set; }
		public float ArmorTotal { get; set; }

		public float Level { get; set; }
		

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





		public float Dexterity { get; set; }
		public float Intelligence { get; set; }
		public float Strength { get; set; }
		public float Vitality { get; set; }

		public float ResistAll { get; set; }
		public float LifePercent { get; set; }
		public float LifeOnHit { get; set; }
		public float LifeSteal { get; set; }
		public float HealthPerSpiritSpent { get; set; }
		public float HealthPerSecond { get; set; }
		public float MovementSpeed { get; set; }

		public float Sockets { get; set; }

		public float CritPercent { get; set; }
		public float CritDamagePercent { get; set; }

		public float MinDamage { get; set; }
		public float MaxDamage { get; set; }

		public float AttackSpeedPercent { get; set; }
		public float AttackSpeedPercentBonus { get; set; }


		public float BlockChance { get; set; }
		public float BlockChanceBonus { get; set; }



		public ItemProperties() { }
	}
}
