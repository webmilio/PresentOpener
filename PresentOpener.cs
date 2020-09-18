using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WebmilioCommons.ModCompatibilities;

namespace PresentOpener
{
	public class PresentOpener : Mod
	{
		public static readonly string GithubUserName = "Plantterror"; //These 2 lines are for ModHelpers Github intergration, just in case.
		public static readonly string GithubProjectName = "PresentOpener";


        public PresentOpener()
        {
            Instance = this;
        }


        public override void Load() //Loading ModConfig and making an instance
        {
            Config = new PresentOpenerConfig();

            ThoriumCompatibility = ModCompatibilityLoader.Instance.GetCompatibility<ThoriumCompatibility>();
        }

		public override void Unload() //Unloading ModConfig and Instance
        {
            ThoriumCompatibility = default;

			Config = null;
			Instance = null;
        }


        public static PresentOpener Instance { get; private set; }

        public static PresentOpenerConfig Config { get; private set; }


        public static ThoriumCompatibility ThoriumCompatibility { get; private set; }
    }
}