using Terraria;
using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class Eggnog : PresentEntry
    {
        public Eggnog() : base(ItemID.Eggnog, 12)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.EggnogScale;
        }

        public override int GetSpawnCount(ItemEntryType type, Player player)
        {
            return Main.rand.Next(1, 4);
        }
    }
}