using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using SubworldLibrary;
using Terraria.ModLoader;
using Terraria.ObjectData;
using T5R.Content.Subworlds.VelvetRoom;

namespace T5R.Content.Tiles.Furniture
{
    public class VelvetRoomDoor : ModTile
    {
        public override void SetStaticDefaults()
        {
            // Properties
            Main.tileSolid[Type] = false;
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            // Placement
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.addTile(Type);

            // Etc
            AddMapEntry(new Color(200, 200, 200), CreateMapEntryName());

            AdjTiles = new int[] { Type };
        }

        public override bool RightClick(int x, int y)
        {
            if (SubworldSystem.IsActive<VelvetRoom>())
            {
                SubworldSystem.Exit();
            } else
            {
                SubworldSystem.Enter<VelvetRoom>();
            }
            return true;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 32, ModContent.ItemType<Items.Placeable.Furniture.VelvetRoomDoor>());
        }
    }
}