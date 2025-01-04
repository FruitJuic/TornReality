using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Content.Items.Accessories
{
	public class Ammobag : ModItem
	{
		public override string Texture => $"TornReality/Assets/Images/{ItemID.EndlessMusketPouch}";

		public override void SetStaticDefaults()
		{
			//Tooltip.SetDefault("Stores ammo.");
		}

		public override void SetDefaults()
		{
			
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.LunarBar, 25)
			.AddIngredient(ItemID.FragmentNebula, 25)
			.AddIngredient(ItemID.FragmentSolar, 25)
			.AddIngredient(ItemID.FragmentStardust, 25)
			.AddIngredient(ItemID.FragmentVortex, 25)
			.AddTile<Tiles.RealityManipulator>()
			.Register();
		}

        
	}
}