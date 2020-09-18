using System;
using WebmilioCommons.ModCompatibilities;

namespace PresentOpener.Entries.Present
{
    public class Mistletoe : ItemEntry
    {
        public Mistletoe() : base(ItemEntryType.Present, PresentOpener.ThoriumCompatibility.ModInstance.ItemType("Mistletoe"), 10)
        {
        }


        public override float GetConfigurationMultiplier(ItemEntryType type, PresentOpenerConfig config)
        {
            return config.moddedMenu.ThoriumMistleScale;
        }


        public override bool Autoload()
        {
            return ModCompatibility?.Invoke() != default;
        }


        public override Func<ModCompatibility> ModCompatibility { get; } = () => PresentOpener.ThoriumCompatibility;
    }
}