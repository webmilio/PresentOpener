using Terraria;

namespace PresentOpener.Entries.Present.Block
{
    public abstract class BlockEntry : PresentEntry
    {
        protected BlockEntry(int itemId, float denominator) : base(itemId, denominator)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.BlockScale;
        }

        public override int GetSpawnCount(ItemEntryType type, Player player)
        {
            return Main.rand.Next(20, 51);
        }
    }
}