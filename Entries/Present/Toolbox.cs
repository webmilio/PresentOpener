using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class Toolbox : PresentEntry
    {
        public Toolbox() : base(ItemID.Toolbox, 323)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.ToolboxScale;
        }
    }
}