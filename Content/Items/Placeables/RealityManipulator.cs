using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace TornReality.Content.Items.Placeables
{
	public class RealityManipulator : ModItem
	{

        	//public override string Texture => $"TornReality/Assets/Images/RealityManipulator";

		public override void SetStaticDefaults() {
			//Tooltip.SetDefault("Required to craft good gear.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
            		Item.CloneDefaults(412);
			Item.rare = ItemRarityID.Red;
			Item.createTile = ModContent.TileType<Tiles.RealityManipulator>();
		}

		public override void AddRecipes() {
			// LunarCraftingStation is an Ancient Manipulator and Lunar Bars are Luminite Bars.
			CreateRecipe()
				.AddIngredient(ItemID.LunarCraftingStation) 
				.AddIngredient(ItemID.LunarBar, 25) 
				.AddTile(TileID.LunarCraftingStation) 
				.Register();
		}
	}
}