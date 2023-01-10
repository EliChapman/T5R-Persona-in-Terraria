using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using T5R.Content.Projectiles.Shortswords;

namespace T5R.Content.Items.Weapons
{
    internal class RebelKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 52;
            Item.height = 52;

            Item.useAnimation = 12;
            Item.useTime = 12;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.autoReuse = true;

            Item.value = Item.buyPrice(silver: 5, copper: 20);
            Item.rare = ItemRarityID.Blue;
            // Add a use sound

            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.damage = 12;
            Item.knockBack = 4;
            Item.crit = 5;

            Item.noUseGraphic = true; // The sword is actually a "projectile", so the item should not be visible when used
            Item.noMelee = true; // The projectile will do the damage and not the item

            Item.shoot = ModContent.ProjectileType<RebelKnifeProjectile>(); // The projectile is what makes a shortsword work
            Item.shootSpeed = 2.1f; // This value bleeds into the behavior of the projectile as velocity, keep that in mind when tweaking values
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
