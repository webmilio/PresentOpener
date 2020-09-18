namespace PresentOpener.Entries.Present.Rare
{
    public abstract class PresentRareEntry : PresentEntry
    {
        protected PresentRareEntry(int itemId, float denominator) : base(itemId, denominator)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.PresentRareItemScale;
        }
    }
}