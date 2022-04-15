using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Weapons
{
    public class Omniclaws : ModItem
    {
        public override string Texture => $"Terraria/Images/Item_{ItemID.FeralClaws}";

        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A claw from an Eldritch Cat, Nya~");
		}

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 1;
            Item.useAnimation = 5;
            Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<DamageClasses.Eldritch>();
            Item.damage = 99998;
            Item.knockBack = 0;
            Item.crit = 35;

            Item.value = Item.sellPrice(5, 0, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item1;

            Item.pick = 299;
            Item.axe = 299;
            Item.hammer = 299;

            
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Weapons.EldritchClaws>()
                .AddIngredient(ItemID.DrillContainmentUnit)
                .AddIngredient(ItemID.Zenith)
                .AddTile<Tiles.RealityManipulator>()
                .Register();
        }
    }
}