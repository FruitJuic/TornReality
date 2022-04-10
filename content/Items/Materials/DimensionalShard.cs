using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Items
{
	public class DimensionalShard : ModItem
	{
		public override string Texture => $"TornReality/Assets/Images/DimensionalShard";

		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("No");
		}

		public override void SetDefaults()
		{
			Item.width = 20; 
            Item.height = 20;
            
            Item.value = Item.sellPrice(3, 0, 0, 0); // The sell price. In (Platnium, Gold, Silver, Copper).
            
            Item.rare = 0;

            Item.maxStack = 999;
		}
	}
}