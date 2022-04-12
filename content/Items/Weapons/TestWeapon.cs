using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Items
{
	public class TestWeapon : ModItem
	{
		public override string Texture => $"TornReality/Assets/Images/TestWeapon";

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			Item.damage = 20;
			Item.DamageType = ModContent.GetInstance<DamageClasses.WarlordDamageClass>();
			Item.width = 400;
			Item.height = 400;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
	}
}