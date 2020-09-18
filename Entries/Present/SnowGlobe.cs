using Terraria;
using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class SnowGlobe : PresentEntry
    {
        public SnowGlobe() : base(ItemID.SnowGlobe, 5)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.SnowGlobeScale;
        }

        public override bool CanObtain(ItemEntryType type, Player player)
        {
            return Main.hardMode;
        }
    }
}