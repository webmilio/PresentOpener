using Terraria;
using Terraria.ID;

namespace PresentOpener.Entries.Present.Vanity
{
    public class TreeMask : VanityEntry
    {
        public TreeMask() : base(ItemID.TreeMask, 92)
        {
        }


        public override void OnOpen(ItemEntryType type, Player player)
        {
            base.OnOpen(type, player);

            player.QuickSpawnItem(ItemID.TreeShirt);
            player.QuickSpawnItem(ItemID.TreeTrunks);
        }
    }
}