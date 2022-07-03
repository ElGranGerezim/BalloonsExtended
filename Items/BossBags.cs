using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace BalloonsExtended.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg) {
			// This method shows adding items to Fishrons boss bag. 
			// Typically you'll also want to also add an item to the non-expert boss drops, that code can be found in ExampleGlobalNPC.NPCLoot. Use this and that to add drops to bosses.
			if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag) {
                if (Main.rand.Next(1,4) == 3){
				    player.QuickSpawnItem(ItemID.ShinyRedBalloon, 1);
                }
			}
		}
    }
}