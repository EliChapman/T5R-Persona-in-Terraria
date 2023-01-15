using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace T5R.Content.Projectiles.Weapons
{
    // Shortsword projectiles are handled in a special way with how they draw and damage things
    // The "hitbox" itself is closer to the player, the sprite is centered on it
    // However the interactions with the world will occur offset from this hitbox, closer to the sword's tip (CutTiles, Colliding)
    // Values chosen mostly correspond to Iron Shortword
    public class RebelKnifeProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.width = 20;
            Projectile.height = 20;

            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 300;

            Projectile.aiStyle = ProjAIStyleID.ShortSword;
        }

        public override void AI()
        {
            base.AI();

            // ToRotation returns the velocity as radians, add pi/2 radians or 90 degrees, and subtract pi/4 or 45 degrees.
            // Projectile.spriteDirection returns either -1 or 1 depending on the way the sprite is facing, flipping the rotation
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            // Adjusts the offset so that the projectile is in the player's hand
            // Half of sprite size - half of projectile size
            DrawOriginOffsetX = 0;
            DrawOffsetX = -(13 - halfProjWidth);
            DrawOriginOffsetY = -(13 - halfProjHeight);
        }

    }
}