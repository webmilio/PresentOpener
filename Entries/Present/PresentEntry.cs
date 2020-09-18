namespace PresentOpener.Entries.Present
{
    public abstract class PresentEntry : ItemEntry
    {
        protected PresentEntry(int itemId, float denominator) : base(ItemEntryType.Present, itemId, 1 / denominator)
        {
        }


        public override float GetConfigurationMultiplier(ItemEntryType type, PresentOpenerConfig config)
        {
            return GetConfigurationMultiplier(config.presentMenu);
        }

        public abstract float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu);
    }
}