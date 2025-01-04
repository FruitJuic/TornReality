using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TornReality.Content.Tiles
{
    public class RealityManipulator : ModTile
    {

        //public override string Texture => $"TornReality/Assets/Images/RealityManipulator";

        public override void SetStaticDefaults() {
			// Properties
			Main.tileTable[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileFrameImportant[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileID.Sets.IgnoredByNpcStepUp[Type] = true;
			
            AdjTiles = new int[] { TileID.WorkBenches };

			// Placement
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new[] { 18 };
			TileObjectData.addTile(Type);

			// Etc
			//ModTranslation name = CreateMapEntryName();
			//name.SetDefault("Reality Manipulator");
			//AddMapEntry(new Color(200, 200, 200), name);
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY) {
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, ModContent.ItemType<Items.Placeables.RealityManipulator>());
		}
    }
}