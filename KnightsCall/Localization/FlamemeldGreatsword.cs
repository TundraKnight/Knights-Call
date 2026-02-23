using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using KnightsCall.Projectiles;

namespace KnightsCall.Items.Weapons.Melee
{
	public class FlamemeldGreatsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Flamemeld Greatsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			// Tooltip.SetDefault("Throws A Spread Of Cursed Flames To Incinerate Foes\n'Subscribe To CursedFlames!'");
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 26;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 38;
			Item.useAnimation = 38;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 68;
			Item.knockBack = 6;
			Item.crit = 6;

			Item.value = Item.buyPrice(gold: 15);
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.shoot = ProjectileID.CursedFlameFriendly;

			Item.shootSpeed = 15f; // Speed of the projectiles the sword will shoot
		}


		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.CursedInferno, 600);
		}
		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CursedFlame, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}