using System.Collections.Generic;
using Terraria.ModLoader;

namespace TornReality.DamageClasses
{
	public class Warlord : DamageClass
	{
		public override void SetStaticDefaults() {
			//DisplayName.SetDefault("Warlord Damage");
		}

		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
		{
			if(damageClass == DamageClass.Generic)
				return StatInheritanceData.Full;
			
			if(damageClass == DamageClass.Melee)
				return new StatInheritanceData(
					damageInheritance: 0.5f,
					critChanceInheritance: 0.5f,
					attackSpeedInheritance: 0.5f,
					armorPenInheritance: 0.5f,
					knockbackInheritance: 0.5f
				);

			return StatInheritanceData.None;
		}
	}
}