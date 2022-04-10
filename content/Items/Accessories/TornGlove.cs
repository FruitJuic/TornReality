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
			Tooltip.SetDefault("Why does this old glove give stat boosts? It isn't even whole.");
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.TitanGlove);
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) *= 1.15f;
			player.GetDamage<DamageClasses.WarlordDamageClass>() *= 1.5f;
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitanGlove, 1);
			recipe.AddIngredient(ModContent.ItemType<Items.DimensionalShard>(), 2);
			recipe.AddTile(TileID.Dirt);
			recipe.Register();
		}
	}
}