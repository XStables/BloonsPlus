using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models.Difficulty;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Models.Store.Loot;

public class Bananza : ModGameMode
{
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Bananza";
    public override string Icon => VanillaSprites.GreaterProductionUpgradeIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetStartingCash(1300);
        gameModeModel.SetAllCashMultiplier(2);
        gameModeModel.SetEndingRound(85);
    }
}
public class Randomizer : ModGameMode
{
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Randomizer";
    public override string Icon => VanillaSprites.RandomIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<RandomRounds>();
    }
}
public class ColorClash : ModGameMode
{
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Color Clash";
    public override string Icon => VanillaSprites.RainbowBloonsIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<ColorRounds>();
        gameModeModel.SetStartingCash(5000);
    }
}

public class DoubleThrift : ModGameMode
{
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Double Thrift";
    public override string Icon => VanillaSprites.ValuableBananasUpgradeIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetStartingCash(325);
        gameModeModel.SetSellMultiplier(0);
        gameModeModel.SetAllCashMultiplier(1.5f);
    }
}
public class FastTrack : ModGameMode
{
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Fast-Track";
    public override string Icon => VanillaSprites.EventRaceIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetStartingRound(26);
        gameModeModel.SetStartingCash(5000);
    }
}
public class Evolution : ModGameMode
{
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Evolution";
    public override string Icon => VanillaSprites.LeadtoGoldUpgradeIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<EvolutionRounds>();
    }
}

public class SupportOnly : ModGameMode
{
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Support Monkeys Only";
    public override string Icon => VanillaSprites.StoreIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.LockTowerSet(TowerSet.Primary, true);
        gameModeModel.LockTowerSet(TowerSet.Military, true);
        gameModeModel.LockTowerSet(TowerSet.Magic, true);
    }
}
public class Mastery : ModGameMode
{
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Mastery";
    public override string Icon => VanillaSprites.GoldenBloonIcon;

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<MasteryRounds>();
        gameModeModel.SetStartingRound(1);
    }
}