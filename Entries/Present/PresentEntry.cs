using Terraria;
using Terraria.ID;
using static Terraria.ID.ItemID;

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

    public class CoalEntry : PresentEntry
    {
        public CoalEntry() : base(Coal, 30)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.CoalScale;
        }
    }

    public class DogWhistleEntry : PresentEntry
    {
        public DogWhistleEntry() : base(DogWhistle, 419)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.WhistleScale;
        }
    }

    public class EggnogEntry : PresentEntry
    {
        public EggnogEntry() : base(Eggnog, 12)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.EggnogScale;
        }

        public override int GetSpawnCount(ItemEntryType type, Player player)
        {
            return Main.rand.Next(1, 4);
        }
    }

    public class HollyEntry : PresentEntry
    {
        public HollyEntry() : base(Holly, 11)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.HollyScale;
        }
    }

    public class ReindeerAntlersEntry : PresentEntry
    {
        public ReindeerAntlersEntry() : base(ReindeerAntlers, 43)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.AntlersScale;
        }
    }

    public class SnowGlobeEntry : PresentEntry
    {
        public SnowGlobeEntry() : base(SnowGlobe, 5)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.SnowGlobeScale;
        }

        public override bool CanObtain(ItemEntryType type, Player player)
        {
            return Main.hardMode;
        }
    }

    public class StarAniseEntry : PresentEntry
    {
        public StarAniseEntry() : base(StarAnise, 16)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.StarAniseScale;
        }

        public override int GetSpawnCount(ItemEntryType type, Player player)
        {
            return Main.rand.Next(20, 41);
        }
    }

    public class ToolboxEntry : PresentEntry
    {
        public ToolboxEntry() : base(Toolbox, 323)
        {
        }


        public override float GetConfigurationMultiplier(PresentOpenerConfig.PresentMenu presentMenu)
        {
            return presentMenu.ToolboxScale;
        }
    }
}