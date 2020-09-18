using Terraria;
using Terraria.ID;

namespace PresentOpener.Entries.Present.Rare
{
    public class RedRyder : PresentRareEntry
    {
        public RedRyder() : base(ItemID.RedRyder, 156)
        {
        }


        public override void OnOpen(ItemEntryType type, Player player)
        {
            base.OnOpen(type, player);

            player.QuickSpawnItem(ItemID.MusketBall, Main.rand.Next(30, 61));
        }
    }
}