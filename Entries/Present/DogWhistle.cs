using Terraria.ID;

namespace PresentOpener.Entries.Present
{
    public class DogWhistle : PresentEntry
    {
        public DogWhistle() : base(ItemID.DogWhistle, 419)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.WhistleScale;
        }
    }
}