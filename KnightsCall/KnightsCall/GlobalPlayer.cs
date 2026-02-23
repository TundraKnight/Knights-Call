using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace KnightsCall
{

	public class GlobalPlayer : ModPlayer
	{
		public float smithingDamage = 0f;


		public override void ResetEffects()
        {
			smithingDamage = 0f;

        }
	}
}