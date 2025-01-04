using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Content.Items.Accessories
{
	public class TornGlove : ModItem
	{

		public override void SetStaticDefaults()
		{
			//Tooltip.SetDefault(
			//	"+15% Increased Damage\n" +
			//	"+50% Increased Warlord Damage\n" +
			//	"+100% Increased Melee Speed\n" +
			//	"Why does this old glove give stat boosts? It isn't even whole. You can't even wear it... better just put it in your pocket\n" +
			//	"Accessory"
			//	);
		}

		public override void SetDefaults()
		{
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) *= 1.15f;
			player.GetDamage<DamageClasses.Warlord>() *= 1.5f;
			player.GetAttackSpeed<DamageClasses.Warlord>() *= 2f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.TitanGlove, 1)
			.AddIngredient(ModContent.ItemType<Materials.DimensionalShard>(), 2)
			.AddTile<Tiles.RealityManipulator>()
			.Register();
		}
	}
}