using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class Holly : PresentEntry
    {
        public Holly() : base(ItemID.Holly, 11)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.HollyScale;
        }
    }
}