using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace T5R.Content.Items.Weapons
{
    internal class RebelKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rebel Knife");
            Tooltip.SetDefault("A weapon manifested from an awakened power.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 38;

            Item.useAnimation = 12;
            Item.useTime = 12;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;

            Item.value = Item.buyPrice(silver: 5, copper: 20);
            Item.rare = ItemRarityID.Blue;
            // Add a use sound

            Item.DamageType = DamageClass.Melee;
            Item.damage = 12;
            Item.knockBack = 4;
            Item.crit = 5;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
