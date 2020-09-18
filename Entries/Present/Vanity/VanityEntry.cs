namespace PresentOpener.Entries.Present.Vanity
{
    public abstract class VanityEntry : PresentEntry
    {
        protected VanityEntry(int itemId, float denominator) : base(itemId, denominator)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.VanityScale;
        }
    }
}