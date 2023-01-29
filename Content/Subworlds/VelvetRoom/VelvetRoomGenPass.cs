using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.WorldBuilding;
using T5R.Content.Subworlds.VelvetRoom.Structures;

namespace T5R.Content.Subworlds.VelvetRoom
{
    public class VelvetRoomGenPass : GenPass
    {
        //TODO: remove this once tML changes generation passes
        public VelvetRoomGenPass() : base("Terrain", 1) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Loading the Velvet Room"; // Sets the text displayed for this pass
            Main.worldSurface = Main.maxTilesY - 42; // Hides the underground layer just out of bounds
            Main.rockLayer = Main.maxTilesY; // Hides the cavern layer way out of bounds
            for (int i = 0; i < Main.maxTilesX; i++)
            {
                for (int j = 0; j < Main.maxTilesY; j++)
                {
                    progress.Set((j + i * Main.maxTilesY) / (float)(Main.maxTilesX * Main.maxTilesY)); // Controls the progress bar, should only be set between 0f and 1f
                    //Tile tile = Main.tile[i, j];
                    //tile.HasTile = true;
                    //tile.TileType = TileID.Dirt;
                }
            }

            VelvetRoomStructure.StructureGen((int)(Main.maxTilesX / 2), (int)(Main.maxTilesY / 2), false);
        }
    }
}
