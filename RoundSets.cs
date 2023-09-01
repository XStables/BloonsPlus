using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Unity;
using System;

public class SparkRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Spark Rounds";
    public override string Icon => VanillaSprites.CeramicBloonIcon;

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        switch (round)
        {
            case 0:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 24, 0, 576);
                break;

            case 1:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 36, 0, 594);
                break;

            case 2:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 18, 0, 324);
                roundModel.AddBloonGroup(BloonType.Blue, 10, 276, 576);
                roundModel.AddBloonGroup(BloonType.Red, 12, 570, 685);
                break;

            case 3:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Blue, 8, 0, 312);
                roundModel.AddBloonGroup(BloonType.Red, 22, 276, 520);
                roundModel.AddBloonGroup(BloonType.Blue, 14, 540, 876);
                break;

            case 4:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 40, 0, 480);
                roundModel.AddBloonGroup(BloonType.Blue, 24, 492, 1046);
                roundModel.AddBloonGroup(BloonType.Green, 2, 1080, 1140);
                break;

            case 5:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Blue, 8, 0, 144);
                roundModel.AddBloonGroup(BloonType.Green, 9, 120, 363);
                roundModel.AddBloonGroup(BloonType.Red, 35, 375, 585);
                roundModel.AddBloonGroup(BloonType.Green, 12, 600, 924);
                break;

            case 6:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 15, 0, 360);
                roundModel.AddBloonGroup(BloonType.Green, 10, 204, 288);
                roundModel.AddBloonGroup(BloonType.Blue, 20, 435, 735);
                roundModel.AddBloonGroup(BloonType.Green, 20, 744, 1194);
                break;

            case 7:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Green, 5, 0, 90);
                roundModel.AddBloonGroup(BloonType.Blue, 50, 120, 720);
                roundModel.AddBloonGroup(BloonType.Green, 9, 240, 780);
                roundModel.AddBloonGroup(BloonType.Yellow, 3, 840, 966);
                break;

            case 8:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 30, 0, 90);
                roundModel.AddBloonGroup(BloonType.Yellow, 6, 120, 300);
                roundModel.AddBloonGroup(BloonType.Blue, 20, 300, 720);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 4, 720, 840);
                break;

            case 9:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Green, 40, 0, 960);
                roundModel.AddBloonGroup(BloonType.Blue, 45, 965, 1775);
                roundModel.AddBloonGroup(BloonType.Yellow, 12, 1775, 1883);
                break;

            case 10:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 6, 0, 180);
                roundModel.AddBloonGroup(BloonType.Green, 25, 180, 630);
                roundModel.AddBloonGroup(BloonType.Yellow, 10, 630, 810);
                roundModel.AddBloonGroup(BloonType.Red, 20, 810, 930);
                break;

            case 11:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 30, 0, 180);
                roundModel.AddBloonGroup(BloonType.Yellow, 9, 180, 288);
                roundModel.AddBloonGroup(BloonType.Red, 30, 288, 468);
                roundModel.AddBloonGroup(BloonType.Yellow, 9, 468, 576);
                roundModel.AddBloonGroup(BloonType.Blue, 40, 576, 1176);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 10, 1176, 1416);
                break;

            case 12:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Blue, 20, 0, 240);
                roundModel.AddBloonGroup(BloonType.Yellow, 15, 240, 600);
                roundModel.AddBloonGroup(BloonType.Blue, 20, 600, 840);
                roundModel.AddBloonGroup(BloonType.Pink, 6, 900, 1152);
                roundModel.AddBloonGroup(BloonType.Blue, 20, 1152, 1392);
                break;

            case 13:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Green, 24, 0, 216);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 14, 216, 413);
                roundModel.AddBloonGroup(BloonType.Pink, 10, 413, 653);
                roundModel.AddBloonGroup(BloonType.Yellow, 7, 653, 1073);
                roundModel.AddBloonGroup(BloonType.Blue, 30, 915, 1005);
                break;

            case 14:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.GreenRegrow, 10, 0, 300);
                roundModel.AddBloonGroup(BloonType.Pink, 4, 300, 324);
                roundModel.AddBloonGroup(BloonType.Yellow, 50, 402, 1152);
                break;

            case 15:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 24, 0, 576);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 8, 576, 984);
                break;

            case 16:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.YellowRegrow, 10, 0, 240);
                roundModel.AddBloonGroup(BloonType.PinkRegrow, 5, 240, 360);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 10, 420, 780);
                roundModel.AddBloonGroup(BloonType.Green, 40, 780, 1980);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 12, 840, 1920);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 12, 855, 1935);
                break;

            case 17:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Orange>(), 6, 0, 126);
                roundModel.AddBloonGroup(BloonID<Cyan>(), 6, 150, 276);
                roundModel.AddBloonGroup(BloonID<Lime>(), 6, 300, 426);
                roundModel.AddBloonGroup(BloonID<Amber>(), 6, 450, 576);
                break;

            case 18:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Pink, 40, 0, 600);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 12, 180, 252);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 12, 375, 447);
                roundModel.AddBloonGroup(BloonType.YellowRegrow, 20, 735, 795);
                break;

            case 19:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Magenta>(), 8, 0, 480);
                roundModel.AddBloonGroup(BloonID<CyanRegrow>(), 18, 480, 804);
                roundModel.AddBloonGroup(BloonType.Green, 40, 804, 972);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 4, 972, 1152);
                break;

            case 20:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.BlueCamo, 4, 0, 240);
                roundModel.AddBloonGroup(BloonID<Scarlet>(), 20, 360, 960);
                roundModel.AddBloonGroup(BloonID<Amber>(), 3, 960, 989);
                break;

            case 21:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Black, 5, 0, 240);
                roundModel.AddBloonGroup(BloonType.White, 5, 270, 510);
                roundModel.AddBloonGroup(BloonType.Pink, 10, 540, 600);
                break;

            case 22:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Magenta>(), 4, 0, 48);
                roundModel.AddBloonGroup(BloonType.Yellow, 20, 48, 288);
                roundModel.AddBloonGroup(BloonType.Black, 7, 288, 498);
                roundModel.AddBloonGroup(BloonID<Lime>(), 15, 750, 975);
                roundModel.AddBloonGroup(BloonID<Magenta>(), 4, 600, 648);
                break;

            case 23:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Black, 12, 0, 648);
                roundModel.AddBloonGroup(BloonType.White, 10, 120, 660);
                roundModel.AddBloonGroup(BloonID<Gray>(), 8, 240, 672);
                roundModel.AddBloonGroup(BloonID<Peach>(), 4, 720, 864);
                break;

            case 24:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Orange>(), 100, 0, 1200);
                roundModel.AddBloonGroup(BloonType.Pink, 20, 180, 264);
                roundModel.AddBloonGroup(BloonID<LimeRegrow>(), 10, 420, 600);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 4, 780, 1068);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 4, 786, 1074);
                roundModel.AddBloonGroup(BloonID<Aqua>(), 4, 792, 1080);
                roundModel.AddBloonGroup(BloonType.White, 6, 1140, 1284);
                break;

            case 25:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Lavender>(), 8, 0, 240);
                roundModel.AddBloonGroup(BloonID<RipeGray>(), 8, 300, 540);
                break;

            case 26:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Lead, 8, 0, 480);
                roundModel.AddBloonGroup(BloonType.YellowRegrow, 20, 630, 750);
                break;

            case 27:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Indigo>(), 5, 0, 60);
                roundModel.AddBloonGroup(BloonType.GreenCamo, 20, 90, 330);
                roundModel.AddBloonGroup(BloonID<Orange>(), 16, 330, 522);
                roundModel.AddBloonGroup(BloonType.Zebra, 6, 540, 900);
                break;

            case 28:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Red, 36, 0, 108);
                roundModel.AddBloonGroup(BloonType.Blue, 36, 150, 258);
                roundModel.AddBloonGroup(BloonType.Green, 36, 300, 408);
                roundModel.AddBloonGroup(BloonType.Yellow, 36, 450, 558);
                roundModel.AddBloonGroup(BloonType.Pink, 36, 600, 708);
                roundModel.AddBloonGroup(BloonID<Gray>(), 8, 780, 1020);
                roundModel.AddBloonGroup(BloonID<RipeGray>(), 8, 795, 1035);
                break;

            case 29:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Zebra, 15, 0, 900);
                roundModel.AddBloonGroup(BloonID<Tangerine>(), 7, 240, 450);
                roundModel.AddBloonGroup(BloonID<Navy>(), 7, 600, 810);
                roundModel.AddBloonGroup(BloonType.ZebraRegrow, 4, 900, 942);
                break;

            case 30:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.PinkRegrow, 100, 0, 240);
                roundModel.AddBloonGroup(BloonID<Tiger>(), 8, 270, 510);
                roundModel.AddBloonGroup(BloonType.Lead, 10, 510, 630);
                roundModel.AddBloonGroup(BloonID<Navy>(), 6, 630, 792);
                break;

            case 31:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Black, 4, 0, 240);
                roundModel.AddBloonGroup(BloonType.White, 4, 15, 255);
                roundModel.AddBloonGroup(BloonID<Gray>(), 4, 30, 270);
                roundModel.AddBloonGroup(BloonID<Tangerine>(), 4, 45, 285);
                roundModel.AddBloonGroup(BloonType.Zebra, 8, 285, 477);
                roundModel.AddBloonGroup(BloonType.Rainbow, 8, 540, 732);
                roundModel.AddBloonGroup(BloonID<Indigo>(), 16, 732, 876);
                break;

            case 32:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<Midnight>(), 16, 0, 768);
                roundModel.AddBloonGroup(BloonID<AmberCamo>(), 8, 240, 264);
                roundModel.AddBloonGroup(BloonID<LavenderRegrow>(), 8, 561, 585);
                roundModel.AddBloonGroup(BloonID<Metal>(), 4, 780, 1020);
                break;

            case 33:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<CyanCamo>(), 40, 0, 240);
                roundModel.AddBloonGroup(BloonType.ZebraRegrow, 8, 240, 576);
                roundModel.AddBloonGroup(BloonType.ZebraRegrow, 8, 244, 580);
                roundModel.AddBloonGroup(BloonID<Tiger>(), 7, 580, 643);
                roundModel.AddBloonGroup(BloonID<Magenta>(), 16, 720, 816);
                roundModel.AddBloonGroup(BloonType.Pink, 75, 816, 1041);
                break;

            case 34:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Ceramic, 4, 0, 144);
                roundModel.AddBloonGroup(BloonType.Rainbow, 14, 231, 315);
                roundModel.AddBloonGroup(BloonType.Yellow, 100, 315, 555);
                roundModel.AddBloonGroup(BloonType.LeadRegrow, 12, 630, 846);
                roundModel.AddBloonGroup(BloonID<Peach>(), 30, 846, 1566);
                break;

            case 35:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<MagentaCamo>(), 8, 0, 288);
                roundModel.AddBloonGroup(BloonType.Zebra, 12, 330, 762);
                roundModel.AddBloonGroup(BloonID<Tiger>(), 12, 348, 780);
                roundModel.AddBloonGroup(BloonType.Rainbow, 9, 810, 1134);
                roundModel.AddBloonGroup(BloonID<Delta>(), 9, 828, 1152);
                roundModel.AddBloonGroup(BloonID<TangerineRegrow>(), 10, 1200, 1440);
                break;

            case 36:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.Lead, 75, 0, 900);
                roundModel.AddBloonGroup(BloonID<Metal>(), 15, 15, 915);
                roundModel.AddBloonGroup(BloonID<Metal>(), 12, 915, 987);
                break;

            case 37:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonType.PinkRegrowCamo, 25, 0, 188);
                roundModel.AddBloonGroup(BloonType.Ceramic, 8, 188, 428);
                roundModel.AddBloonGroup(BloonType.RedCamo, 100, 428, 638);
                roundModel.AddBloonGroup(BloonType.Lead, 20, 720, 1200);
                roundModel.AddBloonGroup(BloonID<Delta>(), 10, 1200, 1560);
                roundModel.AddBloonGroup(BloonID<Midnight>(), 10, 1560, 1710);
                roundModel.AddBloonGroup(BloonType.Ceramic, 12, 1770, 2130);
                roundModel.AddBloonGroup(BloonID<Brick>(), 3, 2130, 2400);
                break;

            case 38:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<MetalRegrow>(), 9, 0, 216);
                roundModel.AddBloonGroup(BloonID<PeachRegrow>(), 25, 216, 329);
                roundModel.AddBloonGroup(BloonType.Ceramic, 8, 360, 696);
                roundModel.AddBloonGroup(BloonID<TigerCamo>(), 4, 696, 720);
                roundModel.AddBloonGroup(BloonID<Cyan>(), 240, 780, 1500);
                roundModel.AddBloonGroup(BloonID<Midnight>(), 9, 960, 1095);
                roundModel.AddBloonGroup(BloonType.Rainbow, 16, 1260, 1452);
                break;

            case 39:
                roundModel.ClearBloonGroups();
                roundModel.AddBloonGroup(BloonID<BrickCastle>(), 2, 0, 480);
                break;
        }
    }
}

public class AllRegrow : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "All Regrow";
    public override string Icon => VanillaSprites.RegrowBloonIcon;

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        foreach (var group in roundModel.groups)
        {
            var bloon = Game.instance.model.GetBloon(group.bloon);
            if (bloon.FindChangedBloonId(bloonModel => bloonModel.isGrow = true, out var regrowBloon))
            {
                group.bloon = regrowBloon;
            }
        }
    }
}

public class AllCamo : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "All Camo";
    public override string Icon => VanillaSprites.CamoBloonIcon;

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        foreach (var group in roundModel.groups)
        {
            var bloon = Game.instance.model.GetBloon(group.bloon);
            if (bloon.FindChangedBloonId(bloonModel => bloonModel.isCamo = true, out var camoBloon))
            {
                group.bloon = camoBloon;
            }
        }
    }
}

public class EvolutionRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Evolution Rounds";
    public override string Icon => VanillaSprites.CamoBloonIcon;
    public override bool AddToOverrideMenu => false;

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        if (round % 2 == 0) //Regrow Rounds
        {
            foreach (var group in roundModel.groups)
            {
                var bloon = Game.instance.model.GetBloon(group.bloon);
                if (bloon.FindChangedBloonId(bloonModel => bloonModel.isGrow = true, out var regrowBloon))
                {
                    group.bloon = regrowBloon;
                }
            }
        }

        if (round % 2 == 1) //Camo Rounds
        {
            foreach (var group in roundModel.groups)
            {
                var bloon = Game.instance.model.GetBloon(group.bloon);
                if (bloon.FindChangedBloonId(bloonModel => bloonModel.isCamo = true, out var camoBloon))
                {
                    group.bloon = camoBloon;
                }
            }
        }
    }
}

public class RandomRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => 0;
    public override string DisplayName => "Randomizer";
    public override string Icon => VanillaSprites.RandomIcon;
    public override bool AddToOverrideMenu => false;
}

public class MasteryRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Mastery";
    public override string Icon => VanillaSprites.GoldenBloonIcon;
    public override bool AddToOverrideMenu => false;

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        for (int k = 0; k < roundModel.groups.Length; k++)
        {
            BloonGroupModel bloonGroup = roundModel.groups[k];

            if (bloonGroup.bloon == "Red") bloonGroup.bloon = "Blue";
            else if (bloonGroup.bloon == "RedRegrow") bloonGroup.bloon = "BlueRegrow";
            else if (bloonGroup.bloon == "RedCamo") bloonGroup.bloon = "BlueCamo";
            else if (bloonGroup.bloon == "RedRegrowCamo") bloonGroup.bloon = "BlueRegrowCamo";

            else if (bloonGroup.bloon == "Blue") bloonGroup.bloon = "Green";
            else if (bloonGroup.bloon == "BlueRegrow") bloonGroup.bloon = "GreenRegrow";
            else if (bloonGroup.bloon == "BlueCamo") bloonGroup.bloon = "GreenCamo";
            else if (bloonGroup.bloon == "BlueRegrowCamo") bloonGroup.bloon = "GreenRegrowCamo";

            else if (bloonGroup.bloon == "Green") bloonGroup.bloon = "Yellow";
            else if (bloonGroup.bloon == "GreenRegrow") bloonGroup.bloon = "YellowRegrow";
            else if (bloonGroup.bloon == "GreenCamo") bloonGroup.bloon = "YellowCamo";
            else if (bloonGroup.bloon == "GreenRegrowCamo") bloonGroup.bloon = "YellowRegrowCamo";

            else if (bloonGroup.bloon == "Yellow") bloonGroup.bloon = "Pink";
            else if (bloonGroup.bloon == "YellowRegrow") bloonGroup.bloon = "PinkRegrow";
            else if (bloonGroup.bloon == "YellowCamo") bloonGroup.bloon = "PinkCamo";
            else if (bloonGroup.bloon == "YellowRegrowCamo") bloonGroup.bloon = "PinkRegrowCamo";

            else if (bloonGroup.bloon == "Pink") bloonGroup.bloon = "Black";
            else if (bloonGroup.bloon == "PinkRegrow") bloonGroup.bloon = "BlackRegrow";
            else if (bloonGroup.bloon == "PinkCamo") bloonGroup.bloon = "BlackCamo";
            else if (bloonGroup.bloon == "PinkRegrowCamo") bloonGroup.bloon = "BlackRegrowCamo";

            else if (bloonGroup.bloon == "Black") bloonGroup.bloon = "Zebra";
            else if (bloonGroup.bloon == "BlackRegrow") bloonGroup.bloon = "ZebraRegrow";
            else if (bloonGroup.bloon == "BlackCamo") bloonGroup.bloon = "ZebraCamo";
            else if (bloonGroup.bloon == "BlackRegrowCamo") bloonGroup.bloon = "ZebraRegrowCamo";

            else if (bloonGroup.bloon == "White") bloonGroup.bloon = "Purple";
            else if (bloonGroup.bloon == "WhiteRegrow") bloonGroup.bloon = "PurpleRegrow";
            else if (bloonGroup.bloon == "WhiteCamo") bloonGroup.bloon = "PurpleCamo";
            else if (bloonGroup.bloon == "WhiteRegrowCamo") bloonGroup.bloon = "PurpleRegrowCamo";

            else if (bloonGroup.bloon == "Purple") bloonGroup.bloon = "Lead";
            else if (bloonGroup.bloon == "PurpleRegrow") bloonGroup.bloon = "LeadRegrow";
            else if (bloonGroup.bloon == "PurpleCamo") bloonGroup.bloon = "LeadCamo";
            else if (bloonGroup.bloon == "PurpleRegrowCamo") bloonGroup.bloon = "LeadRegrowCamo";

            else if (bloonGroup.bloon == "Lead") bloonGroup.bloon = "Rainbow";
            else if (bloonGroup.bloon == "LeadRegrow") bloonGroup.bloon = "RainbowRegrow";
            else if (bloonGroup.bloon == "LeadCamo") bloonGroup.bloon = "RainbowCamo";
            else if (bloonGroup.bloon == "LeadRegrowCamo") bloonGroup.bloon = "RainbowRegrowCamo";
            else if (bloonGroup.bloon == "LeadFortified") bloonGroup.bloon = "Rainbow";
            else if (bloonGroup.bloon == "LeadRegrowFortified") bloonGroup.bloon = "RainbowRegrow";
            else if (bloonGroup.bloon == "LeadFortifiedCamo") bloonGroup.bloon = "RainbowCamo";
            else if (bloonGroup.bloon == "LeadRegrowFortifiedCamo") bloonGroup.bloon = "RainbowRegrowCamo";

            else if (bloonGroup.bloon == "Zebra") bloonGroup.bloon = "Rainbow";
            else if (bloonGroup.bloon == "ZebraRegrow") bloonGroup.bloon = "RainbowRegrow";
            else if (bloonGroup.bloon == "ZebraCamo") bloonGroup.bloon = "RainbowCamo";
            else if (bloonGroup.bloon == "ZebraRegrowCamo") bloonGroup.bloon = "RainbowRegrowCamo";

            else if (bloonGroup.bloon == "Rainbow") bloonGroup.bloon = "Ceramic";
            else if (bloonGroup.bloon == "RainbowRegrow") bloonGroup.bloon = "CeramicRegrow";
            else if (bloonGroup.bloon == "RainbowCamo") bloonGroup.bloon = "CeramicCamo";
            else if (bloonGroup.bloon == "RainbowRegrowCamo") bloonGroup.bloon = "CeramicRegrowCamo";

            else if (bloonGroup.bloon == "Ceramic") bloonGroup.bloon = "Moab";
            else if (bloonGroup.bloon == "CeramicRegrow") bloonGroup.bloon = "Moab";
            else if (bloonGroup.bloon == "CeramicCamo") bloonGroup.bloon = "Moab";
            else if (bloonGroup.bloon == "CeramicRegrowCamo") bloonGroup.bloon = "Moab";
            else if (bloonGroup.bloon == "CeramicFortified") bloonGroup.bloon = "MoabFortified";
            else if (bloonGroup.bloon == "CeramicRegrowFortified") bloonGroup.bloon = "MoabFortified";
            else if (bloonGroup.bloon == "CeramicFortifiedCamo") bloonGroup.bloon = "MoabFortified";
            else if (bloonGroup.bloon == "CeramicRegrowFortifiedCamo") bloonGroup.bloon = "MoabFortified";

            else if (bloonGroup.bloon == "Moab") bloonGroup.bloon = "Bfb";
            else if (bloonGroup.bloon == "MoabFortified") bloonGroup.bloon = "BfbFortified";

            else if (bloonGroup.bloon == "Bfb") bloonGroup.bloon = "Zomg";
            else if (bloonGroup.bloon == "BfbFortified") bloonGroup.bloon = "ZomgFortified";

            else if (bloonGroup.bloon == "Zomg") bloonGroup.bloon = "Bad";
            else if (bloonGroup.bloon == "ZomgFortified") bloonGroup.bloon = "BadFortified";

            else if (bloonGroup.bloon == "DdtCamo") bloonGroup.bloon = "DdtFortifiedCamo";

            else if (bloonGroup.bloon == "Bad") bloonGroup.bloon = "BadFortified";
        }
    }
}

public class ColorRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Color Clash";
    public override string Icon => VanillaSprites.CeramicBloonIcon;
    public override bool AddToOverrideMenu => false;

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        if ((round + 1) % 3 == 0 & round > 0)
        {
            float typeE = ((round - 2) / 3);
            int type = (int)Math.Round(typeE);
            float countAE = 3 + ((round - 2) / 3);
            int countA = (int)Math.Round(countAE);

            if (type % 3 == 0)
                roundModel.AddBloonGroup(BloonID<ColorfulRed>(), countA, 0, 70 * countA);
            else if (type % 3 == 1)
                roundModel.AddBloonGroup(BloonID<ColorfulYellow>(), countA, 0, 70 * countA);
            else if (type % 3 == 2)
                roundModel.AddBloonGroup(BloonID<ColorfulBlue>(), countA, 0, 70 * countA);
        }

        if ((round + 1) % 10 == 0 & round > 0)
        {
            float countBE = 1 + ((round - 9) / 10);
            int countB = (int)Math.Round(countBE);
            roundModel.AddBloonGroup(BloonID<ColorCastle>(), countB, 0, 90 * countB);
        }
    }
}