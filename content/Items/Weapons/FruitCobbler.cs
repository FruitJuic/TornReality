using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Content.Items.Weapons
{
    public class FruitCobbler : ModItem
    {
        public override string Texture => $"Terraria/Images/Item_{ItemID.Peach}";

        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Getting cobbled by a fruit? Sounds like a bad idea.");
		}

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<DamageClasses.Warmonger>();
            Item.damage = 460;
            Item.knockBack = 0;
            Item.crit = 35;

            Item.value = Item.buyPrice(0, 5, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item1;
        }
    }
}