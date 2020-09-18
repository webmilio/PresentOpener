using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class ReindeerAntlers : PresentEntry
    {
        public ReindeerAntlers() : base(ItemID.ReindeerAntlers, 43)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.AntlersScale;
        }
    }
}