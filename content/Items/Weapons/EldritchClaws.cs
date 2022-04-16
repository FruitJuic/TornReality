using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TornReality.Content.Items.Weapons
{
    public class EldritchClaws : ModItem
    {
        public override string Texture => $"Terraria/Images/Item_{ItemID.FetidBaghnakhs}";

        public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A claw from an Eldritch Cat, Nya~");
		}

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<DamageClasses.Eldritch>();
            Item.damage = 460;
            Item.knockBack = 0;
            Item.crit = 35;

            Item.value = Item.sellPrice(5, 0, 0, 0);
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item1;

            Item.pick = 299;
        }
    }
}