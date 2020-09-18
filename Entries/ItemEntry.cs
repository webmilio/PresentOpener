using System;
using Terraria;
using WebmilioCommons.ModCompatibilities;

namespace PresentOpener.Entries
{
    public abstract class ItemEntry
    {
        protected ItemEntry(ItemEntryType type, int itemId, float weight)
        {
            Type = type;
            ItemId = itemId;
            Weight = weight;
        }


        public virtual bool CanObtain(ItemEntryType type, Player player) => true;

        public abstract float GetConfigurationMultiplier(ItemEntryType type, PresentOpenerConfig config);

        public virtual float GetOdds(ItemEntryType type, PresentOpenerConfig config) => Weight * GetConfigurationMultiplier(type, config);


        public virtual void OnOpen(ItemEntryType type, Player player)
        {
            player.QuickSpawnItem(ItemId, GetSpawnCount(type, player));
        }

        public virtual int GetSpawnCount(ItemEntryType type, Player player) => 1;


        public virtual bool Autoload() => true;

        public virtual Func<ModCompatibility> ModCompatibility { get; } = default;

        public ItemEntryType Type { get; }

        public int ItemId { get; }

        public float Weight { get; }
    }
}