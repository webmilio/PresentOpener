using PresentOpener.Entries;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace PresentOpener
{
    public class OpenSeasonBag : GlobalItem // This class is solely to adjust the Present and Goodie bag chances to fit the config.
    {
        public override bool PreOpenVanillaBag(string context, Player player, int arg)
        {
            var config = new PresentOpenerConfig();

            switch (context)
            {
                case "present":
                    {
                        if (config.presentMenu.DisablePresentConfig)
                        {
                            return true;
                        }

                        var presentRandom = new WeightedRandom<ItemEntry>(); //This is a form of randomness made by Terraria, useful for avoiding long If/Else chains like I have previously done.
                        ItemEntryLoader.Instance.PopulateWeightedRandom(presentRandom, ItemEntryType.Present, player, config);

                        /*Mod ThoriumMod = ModLoader.GetMod("ThoriumMod");
                        if (ThoriumMod != null && config.moddedmenu.DisableModdedConfigs == false)
                        {
                            presentRandom.Add(ThoriumMod.ItemType("Mistletoe"), 1f / 10f * config.moddedmenu.ThoriumMistleScale);
                        }*/

                        presentRandom.Get().OnOpen(ItemEntryType.Present, player);
                        presentRandom.Clear();

                        return false;
                    }

                case "goodieBag":
                    {
                        if (config.goodiemenu.DisableGoodieConfig)
                        {
                            return true;
                        }

                        WeightedRandom<int> goodierandom = new WeightedRandom<int>();

                        goodierandom.Add(ItemID.UnluckyYarn, 19f / 150f * config.goodiemenu.GoodieRareItemScale);
                        goodierandom.Add(ItemID.BatHook, 19f / 150f * config.goodiemenu.GoodieRareItemScale);
                        goodierandom.Add(ItemID.MorbidCuriosity, 19f / 50f * config.goodiemenu.PaintingScale);
                        goodierandom.Add(ItemID.BitterHarvest, 19f / 50f * config.goodiemenu.PaintingScale);
                        goodierandom.Add(ItemID.BloodMoonCountess, 19f / 50f * config.goodiemenu.PaintingScale);
                        goodierandom.Add(ItemID.HallowsEve, 19f / 50f * config.goodiemenu.PaintingScale);
                        goodierandom.Add(ItemID.JackingSkeletron, 19f / 50f * config.goodiemenu.PaintingScale);
                        goodierandom.Add(ItemID.CatEars, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.CatMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.CreeperMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.PumpkinMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.SpaceCreatureMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.KarateTortoiseMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.FoxMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.WitchHat, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.VampireMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.LeprechaunHat, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.RobotMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.PrincessHat, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.TreasureHunterShirt, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.WolfMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.UnicornMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.ReaperHood, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.PixieShirt, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.BrideofFrankensteinMask, 1f * config.goodiemenu.CostumeScale);
                        goodierandom.Add(ItemID.GhostMask, 1f * config.goodiemenu.CostumeScale);

                        Mod SpiritMod = ModLoader.GetMod("SpiritMod");
                        if (SpiritMod != null && config.moddedMenu.DisableModdedConfigs == false)
                        {
                            WeightedRandom<int> MaskRandom = new WeightedRandom<int>();
                            MaskRandom.Add(SpiritMod.ItemType("MaskHulk"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskIggy"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskSvante"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskLeemyy"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskSchmo"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskLordCake"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskYuyutsu"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskVladimier"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskGraydee"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskBlaze"));
                            MaskRandom.Add(SpiritMod.ItemType("MaskKachow"));
                            if (Main.rand.Next(25) <= 5f * config.moddedMenu.SpiritDevMaskScale)
                            {
                                player.QuickSpawnItem(MaskRandom);
                            }

                            WeightedRandom<int> candyrandom = new WeightedRandom<int>();
                            candyrandom.Add(SpiritMod.ItemType("Taffy"), 1f / 8f * config.moddedMenu.SpiritCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("Candy"), 7f / 25f * config.moddedMenu.SpiritCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("ChocolateBar"), 12f / 25f * config.moddedMenu.SpiritCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("HealthCandy"), 29f / 50f * config.moddedMenu.SpiritCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("ManaCandy"), 17f / 25f * config.moddedMenu.SpiritCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("Lollipop"), 39f / 50f * config.moddedMenu.SpiritCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("Apple"), 100f / 83f * config.moddedMenu.AppleScale);
                            candyrandom.Add(SpiritMod.ItemType("MysteryCandy"), 25f / 24f * config.moddedMenu.MysteryCandyScale);
                            candyrandom.Add(SpiritMod.ItemType("GoldCandy"), 3f / 100f);
                            player.QuickSpawnItem(candyrandom);
                        }

                        if (goodierandom != null)
                        {
                            switch (goodierandom)
                            {
                                case ItemID.RottenEgg:
                                    player.QuickSpawnItem(goodierandom, Main.rand.Next(10, 41));
                                    break;
                                case ItemID.CatMask:
                                    player.QuickSpawnItem(ItemID.CatMask);
                                    player.QuickSpawnItem(ItemID.CatShirt);
                                    player.QuickSpawnItem(ItemID.CatPants);
                                    break;
                                case ItemID.CreeperMask:
                                    player.QuickSpawnItem(ItemID.CreeperMask);
                                    player.QuickSpawnItem(ItemID.CreeperShirt);
                                    player.QuickSpawnItem(ItemID.CreeperPants);
                                    break;
                                case ItemID.PumpkinMask:
                                    player.QuickSpawnItem(ItemID.PumpkinMask);
                                    player.QuickSpawnItem(ItemID.PumpkinShirt);
                                    player.QuickSpawnItem(ItemID.PumpkinPants);
                                    break;
                                case ItemID.SpaceCreatureMask:
                                    player.QuickSpawnItem(ItemID.SpaceCreatureMask);
                                    player.QuickSpawnItem(ItemID.SpaceCreatureShirt);
                                    player.QuickSpawnItem(ItemID.SpaceCreaturePants);
                                    break;
                                case ItemID.KarateTortoiseMask:
                                    player.QuickSpawnItem(ItemID.KarateTortoiseMask);
                                    player.QuickSpawnItem(ItemID.KarateTortoiseShirt);
                                    player.QuickSpawnItem(ItemID.KarateTortoisePants);
                                    break;
                                case ItemID.FoxMask:
                                    player.QuickSpawnItem(ItemID.FoxMask);
                                    player.QuickSpawnItem(ItemID.FoxShirt);
                                    player.QuickSpawnItem(ItemID.FoxPants);
                                    break;
                                case ItemID.WitchHat:
                                    player.QuickSpawnItem(ItemID.WitchHat);
                                    player.QuickSpawnItem(ItemID.WitchDress);
                                    player.QuickSpawnItem(ItemID.WitchBoots);
                                    break;
                                case ItemID.VampireMask:
                                    player.QuickSpawnItem(ItemID.VampireMask);
                                    player.QuickSpawnItem(ItemID.VampireShirt);
                                    player.QuickSpawnItem(ItemID.VampirePants);
                                    break;
                                case ItemID.LeprechaunHat:
                                    player.QuickSpawnItem(ItemID.LeprechaunHat);
                                    player.QuickSpawnItem(ItemID.LeprechaunShirt);
                                    player.QuickSpawnItem(ItemID.LeprechaunPants);
                                    break;
                                case ItemID.RobotMask:
                                    player.QuickSpawnItem(ItemID.RobotMask);
                                    player.QuickSpawnItem(ItemID.RobotShirt);
                                    player.QuickSpawnItem(ItemID.RobotPants);
                                    break;
                                case ItemID.PrincessHat:
                                    player.QuickSpawnItem(ItemID.PrincessHat);
                                    player.QuickSpawnItem(ItemID.PrincessDressNew);
                                    break;
                                case ItemID.TreasureHunterShirt:
                                    player.QuickSpawnItem(ItemID.TreasureHunterShirt);
                                    player.QuickSpawnItem(ItemID.TreasureHunterPants);
                                    break;
                                case ItemID.WolfMask:
                                    player.QuickSpawnItem(ItemID.WolfMask);
                                    player.QuickSpawnItem(ItemID.WolfShirt);
                                    player.QuickSpawnItem(ItemID.WolfPants);
                                    break;
                                case ItemID.UnicornMask:
                                    player.QuickSpawnItem(ItemID.UnicornMask);
                                    player.QuickSpawnItem(ItemID.UnicornShirt);
                                    player.QuickSpawnItem(ItemID.UnicornPants);
                                    break;
                                case ItemID.ReaperHood:
                                    player.QuickSpawnItem(ItemID.ReaperHood);
                                    player.QuickSpawnItem(ItemID.ReaperRobe);
                                    break;
                                case ItemID.PixieShirt:
                                    player.QuickSpawnItem(ItemID.PixieShirt);
                                    player.QuickSpawnItem(ItemID.PixiePants);
                                    break;
                                case ItemID.BrideofFrankensteinMask:
                                    player.QuickSpawnItem(ItemID.BrideofFrankensteinMask);
                                    player.QuickSpawnItem(ItemID.BrideofFrankensteinDress);
                                    break;
                                case ItemID.GhostMask:
                                    player.QuickSpawnItem(ItemID.GhostMask);
                                    player.QuickSpawnItem(ItemID.GhostShirt);
                                    break;
                                default:
                                    player.QuickSpawnItem(goodierandom);
                                    break;
                            }

                            goodierandom.Clear();
                        }

                        return false;
                    }

                default:
                    return true;
            }
        }
    }
}
