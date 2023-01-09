using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace T5R.Content.Items
{
    internal class TestItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Item");
            Tooltip.SetDefault("An item for testing\nDoes nothing");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.value = Item.buyPrice(copper: 20);
            Item.maxStack = 9999;

            Item.rare = ItemRarityID.Blue;
        }

    }
}
