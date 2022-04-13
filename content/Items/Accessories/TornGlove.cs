using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Accessories
{
	public class TornGlove : ModItem
	{
		public override string Texture => $"TornReality/Assets/Images/TornGlove";

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault(
				"15% Increased Damage\n" +
				"50% Increased Warlord Damage\n" +
				"100% Increased Melee Speed\n" +
				"Why does this old glove give stat boosts? It isn't even whole."
				);
		}

		public override void SetDefaults()
		{
			Item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) *= 1.15f;
			player.GetDamage<DamageClasses.Warlord>() *= 1.5f;
			player.meleeSpeed *= 2f;
        }

		public override void AddRecipes()
		{
			CreateRecipe().
			AddIngredient(ItemID.TitanGlove, 1).
			AddIngredient(ModContent.ItemType<Items.DimensionalShard>(), 2).
			AddTile(TileID.Dirt).
			Register();
		}
	}
}