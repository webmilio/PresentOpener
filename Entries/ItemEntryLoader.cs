using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;
using WebmilioCommons.Loaders;

namespace PresentOpener.Entries
{
    public class ItemEntryLoader : SingletonLoader<ItemEntryLoader, ItemEntry>
    {
        private Dictionary<int, ItemEntry> _entriesById;
        private Dictionary<ItemEntryType, List<ItemEntry>> _entriesByType;


        public override void PreLoad()
        {
            var entryTypes = Enum.GetValues(typeof(ItemEntryType));

            _entriesById = new Dictionary<int, ItemEntry>();
            _entriesByType = new Dictionary<ItemEntryType, List<ItemEntry>>(entryTypes.Length - 2); // We remove None and All.

            for (int i = 0; i < entryTypes.Length; i++)
                _entriesByType.Add((ItemEntryType)entryTypes.GetValue(i), new List<ItemEntry>());
        }

        protected override void PostAdd(Mod mod, ItemEntry entry, Type type)
        {
            _entriesById.Add(entry.ItemId, entry);

            foreach (var kvp in _entriesByType) 
                if (entry.Type.HasFlag(kvp.Key))
                    kvp.Value.Add(entry);
        }

        protected override void PostUnload()
        {
            _entriesById?.Clear();
            _entriesById = default;

            _entriesByType?.Clear();
            _entriesByType = default;
        }


        public void PopulateWeightedRandom(WeightedRandom<ItemEntry> weightedRandom, ItemEntryType entryType, Player player, PresentOpenerConfig config)
        {
            foreach (var entry in _entriesByType[entryType])
                if (entry.CanObtain(entryType, player))
                    weightedRandom.Add(entry, entry.GetOdds(entryType, config));
        }
    }
}