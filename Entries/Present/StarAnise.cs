using Terraria;
using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class StarAnise : PresentEntry
    {
        public StarAnise() : base(ItemID.StarAnise, 16)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.StarAniseScale;
        }

        public override int GetSpawnCount(ItemEntryType type, Player player)
        {
            return Main.rand.Next(20, 41);
        }
    }
}