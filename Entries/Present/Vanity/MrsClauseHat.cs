using Terraria;
using Terraria.ID;

namespace PresentOpener.Entries.Present.Vanity
{
    public class MrsClauseHat : VanityEntry
    {
        public MrsClauseHat() : base(ItemID.MrsClauseHat, 92)
        {
        }


        public override void OnOpen(ItemEntryType type, Player player)
        {
            base.OnOpen(type, player);

            player.QuickSpawnItem(ItemID.MrsClauseShirt);
            player.QuickSpawnItem(ItemID.MrsClauseHeels);
        }
    }
}