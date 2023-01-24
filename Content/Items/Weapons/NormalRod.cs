using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace T5R.Content.Items.Weapons
{
    internal class NormalRod : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 32;

            Item.useAnimation = 28;
            Item.useTime = 28;
            Item.useStyle = ItemUseStyleID.Swing;

            Item.value = Item.buyPrice(silver: 6, copper: 60);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 24;
            Item.knockBack = 5f;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 7)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
