using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;

namespace T5R.Content.Items.Placeable.Furniture
{
    public class VelvetRoomDoor : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 96;
            Item.maxStack = 1;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(silver: 5, copper: 20);
            Item.rare = ItemRarityID.Blue;
            Item.createTile = ModContent.TileType<Tiles.Furniture.VelvetRoomDoor>();
        }
    }
}