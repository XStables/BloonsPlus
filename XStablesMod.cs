using MelonLoader;
using BTD_Mod_Helper;
using XStablesMod;

[assembly: MelonInfo(typeof(XStablesMod.XStablesMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace XStablesMod;

public class XStablesMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<XStablesMod>("XStables's Mod / Bloons+ Mod loaded!");
    }
}