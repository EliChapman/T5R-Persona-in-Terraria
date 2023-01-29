using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using T5R.Content.Tiles.Furniture;
using System.Collections.Generic;

namespace T5R.Content.Subworlds.VelvetRoom.Structures;

public class VelvetRoomStructure
{
    // Position of the blocks
    private static readonly int[,] _blockArray = new int[,]
    {
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {2, 3, 2, 3 }
    };

    // Sets the TileMap, 0 is nothing, 1 is destroy
    private static readonly Dictionary<int, int> _blockTileMap = new Dictionary<int, int>()
    {
        { 2, TileID.StoneSlab },
        { 3, TileID.GrayBrick },
    };

    // Position of the furniture
    private static readonly int[,] _furnitureArray = new int[,]
    {
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {0, 0, 2, 0 },
        {0, 0, 0, 0 }
    };

    // Sets the TileMap, 0 is nothing, 1 is destroy
    private static readonly Dictionary<int, int> _furnitureTileMap = new Dictionary<int, int>()
    {
        { 2, ModContent.TileType<VelvetRoomDoor>() },
    };


    public static void StructureGen(int xPosO, int yPosO, bool mirrored)
    {
        PlaceTiles(_blockArray, _blockTileMap, xPosO, yPosO, mirrored);
        PlaceTiles(_furnitureArray, _furnitureTileMap, xPosO, yPosO, mirrored);
    }


    //Making sure tiles arent out of bounds
    private static bool TileCheckSafe(int i, int j)
    {
        if (i > 0 && i < Main.maxTilesX && j > 0 && j < Main.maxTilesY)
            return true;
        return false;
    }

    // Places the tiles based off of a tilemap and array
    private static void PlaceTiles(int[,] tileArray, Dictionary<int, int> tileMap, int xPosO, int yPosO, bool mirrored)
    {
        for (int i = 0; i < tileArray.GetLength(1); i++)
        {
            for (int j = 0; j < tileArray.GetLength(0); j++)
            {
                int tileKey = tileArray[j, i];

                if (mirrored)
                {
                    if (TileCheckSafe((int)(xPosO + tileArray.GetLength(1) - i), (int)(yPosO + j)))
                    {
                        if (tileKey == 1)
                        {
                            WorldGen.KillTile(xPosO + tileArray.GetLength(1) - i, yPosO + j);
                        }
                        else if (tileKey != 0)
                        {
                            WorldGen.KillTile(xPosO + tileArray.GetLength(1) - i, yPosO + j);
                            WorldGen.PlaceTile(xPosO + tileArray.GetLength(1) - i, yPosO + j, tileMap[tileKey], true, true);
                        }
                    }
                }
                else
                {
                    if (TileCheckSafe((int)(xPosO + i), (int)(yPosO + j)))
                    {
                        if (tileKey == 1)
                        {
                            WorldGen.KillTile(xPosO + i, yPosO + j);
                        }
                        else if (tileKey != 0)
                        {
                            WorldGen.KillTile(xPosO + i, yPosO + j);
                            WorldGen.PlaceTile(xPosO + i, yPosO + j, tileMap[tileKey], true, true);
                        }
                    }
                }
            }
        }
    }
}