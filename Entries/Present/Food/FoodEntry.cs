namespace PresentOpener.Entries.Present.Food
{
    public abstract class FoodEntry : PresentEntry
    {
        protected FoodEntry(int itemId, float denominator) : base(itemId, denominator)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.FoodScale;
        }
    }
}