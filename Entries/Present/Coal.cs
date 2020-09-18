using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class Coal : PresentEntry
    {
        public Coal() : base(ItemID.Coal, 30)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.CoalScale;
        }
    }
}