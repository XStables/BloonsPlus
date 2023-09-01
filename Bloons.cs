using MelonLoader;
using BTD_Mod_Helper;
using XStablesMod;
using BTD_Mod_Helper.Api.Bloons;
using Il2CppAssets.Scripts.Models.Bloons;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity.Display;
using System.Collections.Generic;
using System;

public class Scarlet : ModBloon
{
    public override string BaseBloon => BloonType.Yellow;
    public override string Icon => "Scarlet-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 55;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Green);
        bloonModel.AddToChildren(BloonType.Green);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class ScarletRegrow : ModBloon<Scarlet>
{
    public override bool Regrow => true;
    public override string Icon => "ScarletRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class ScarletCamo : ModBloon<Scarlet>
{
    public override bool Camo => true;
    public override string Icon => "ScarletCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class ScarletRegrowCamo : ModBloon<Scarlet>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "ScarletRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Aqua : ModBloon
{
    public override string BaseBloon => BloonType.Pink;
    public override string Icon => "Aqua-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 65;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Scarlet>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class AquaRegrow : ModBloon<Aqua>
{
    public override bool Regrow => true;
    public override string Icon => "AquaRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class AquaCamo : ModBloon<Aqua>
{
    public override bool Camo => true;
    public override string Icon => "AquaCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class AquaRegrowCamo : ModBloon<Aqua>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "AquaRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Orange : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Aqua>();
    public override string Icon => "Orange-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 30;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Red);
        bloonModel.AddToChildren(BloonType.Red);
        bloonModel.AddToChildren(BloonType.Red);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class OrangeRegrow : ModBloon<Orange>
{
    public override bool Regrow => true;
    public override string Icon => "OrangeRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class OrangeCamo : ModBloon<Orange>
{
    public override bool Camo => true;
    public override string Icon => "OrangeCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class OrangeRegrowCamo : ModBloon<Orange>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "OrangeRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Cyan : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Orange>();
    public override string Icon => "Cyan-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 40;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Blue);
        bloonModel.AddToChildren(BloonType.Blue);
        bloonModel.AddToChildren(BloonType.Blue);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class CyanRegrow : ModBloon<Cyan>
{
    public override bool Regrow => true;
    public override string Icon => "CyanRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class CyanCamo : ModBloon<Cyan>
{
    public override bool Camo => true;
    public override string Icon => "CyanCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class CyanRegrowCamo : ModBloon<Cyan>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "CyanRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Lime : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Orange>();
    public override string Icon => "Lime-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 50;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Green);
        bloonModel.AddToChildren(BloonType.Green);
        bloonModel.AddToChildren(BloonType.Green);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class LimeRegrow : ModBloon<Lime>
{
    public override bool Regrow => true;
    public override string Icon => "LimeRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class LimeCamo : ModBloon<Lime>
{
    public override bool Camo => true;
    public override string Icon => "LimeCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class LimeRegrowCamo : ModBloon<Lime>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "LimeRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Amber : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Orange>();
    public override string Icon => "Amber-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 85;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Yellow);
        bloonModel.AddToChildren(BloonType.Yellow);
        bloonModel.AddToChildren(BloonType.Yellow);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class AmberRegrow : ModBloon<Amber>
{
    public override bool Regrow => true;
    public override string Icon => "AmberRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class AmberCamo : ModBloon<Amber>
{
    public override bool Camo => true;
    public override string Icon => "AmberCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class AmberRegrowCamo : ModBloon<Amber>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "AmberRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Peach : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Amber>();
    public override string Icon => "Peach-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 60;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Scarlet>());
        bloonModel.AddToChildren(ModBloon.BloonID<Scarlet>());
        bloonModel.AddToChildren(ModBloon.BloonID<Scarlet>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class PeachRegrow : ModBloon<Peach>
{
    public override bool Regrow => true;
    public override string Icon => "PeachRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class PeachCamo : ModBloon<Peach>
{
    public override bool Camo => true;
    public override string Icon => "PeachCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class PeachRegrowCamo : ModBloon<Peach>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "PeachRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Lavender : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Orange>();
    public override string Icon => "Lavender-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 87.5F;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Pink);
        bloonModel.AddToChildren(BloonType.Pink);
        bloonModel.AddToChildren(BloonType.Pink);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class LavenderRegrow : ModBloon<Lavender>
{
    public override bool Regrow => true;
    public override string Icon => "LavenderRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class LavenderCamo : ModBloon<Lavender>
{
    public override bool Camo => true;
    public override string Icon => "LavenderCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class LavenderRegrowCamo : ModBloon<Lavender>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "LavenderRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Indigo : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Lavender>();
    public override string Icon => "Indigo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 70;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());
        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());
        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class IndigoRegrow : ModBloon<Indigo>
{
    public override bool Regrow => true;
    public override string Icon => "IndigoRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class IndigoCamo : ModBloon<Indigo>
{
    public override bool Camo => true;
    public override string Icon => "IndigoCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class IndigoRegrowCamo : ModBloon<Indigo>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "IndigoRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Magenta : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Indigo>();
    public override string Icon => "Magenta-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 64;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Red);
        bloonModel.AddToChildren(BloonType.Blue);
        bloonModel.AddToChildren(BloonType.Green);
        bloonModel.AddToChildren(BloonType.Yellow);
        bloonModel.AddToChildren(BloonType.Pink);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class MagentaRegrow : ModBloon<Magenta>
{
    public override bool Regrow => true;
    public override string Icon => "MagentaRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class MagentaCamo : ModBloon<Magenta>
{
    public override bool Camo => true;
    public override string Icon => "MagentaCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class MagentaRegrowCamo : ModBloon<Magenta>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "MagentaRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class ColorfulRed : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Magenta>();
    public override string Icon => "ColorfulRed-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 55.5f;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Amber>());
        bloonModel.AddToChildren(ModBloon.BloonID<Amber>());
        bloonModel.AddToChildren(ModBloon.BloonID<Scarlet>());
        bloonModel.AddToChildren(ModBloon.BloonID<Scarlet>());
        bloonModel.AddToChildren(ModBloon.BloonID<Indigo>());
        bloonModel.AddToChildren(ModBloon.BloonID<Indigo>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class ColorfulYellow : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Magenta>();
    public override string Icon => "ColorfulYellow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 55.5f;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Lavender>());
        bloonModel.AddToChildren(ModBloon.BloonID<Lavender>());
        bloonModel.AddToChildren(ModBloon.BloonID<Lime>());
        bloonModel.AddToChildren(ModBloon.BloonID<Lime>());
        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());
        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());
        bloonModel.AddToChildren(BloonType.Pink);
        bloonModel.AddToChildren(BloonType.Pink);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class ColorfulBlue : ModBloon
{
    public override string BaseBloon => ModBloon.BloonID<Magenta>();
    public override string Icon => "ColorfulBlue-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 55.5f;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Orange>());
        bloonModel.AddToChildren(ModBloon.BloonID<Orange>());
        bloonModel.AddToChildren(ModBloon.BloonID<Orange>());
        bloonModel.AddToChildren(ModBloon.BloonID<Orange>());
        bloonModel.AddToChildren(ModBloon.BloonID<Peach>());
        bloonModel.AddToChildren(ModBloon.BloonID<Peach>());
        bloonModel.AddToChildren(ModBloon.BloonID<Magenta>());
        bloonModel.AddToChildren(ModBloon.BloonID<Magenta>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}

public class Gray : ModBloon
{
    public override string BaseBloon => BloonType.Black;
    public override string Icon => "Gray-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 47.5F;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Pink);
        bloonModel.AddToChildren(BloonType.Pink);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class GrayRegrow : ModBloon<Gray>
{
    public override bool Regrow => true;
    public override string Icon => "GrayRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class GrayCamo : ModBloon<Gray>
{
    public override bool Camo => true;
    public override string Icon => "GrayCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class GrayRegrowCamo : ModBloon<Gray>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "GrayRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class RipeGray : ModBloon
{
    public override string BaseBloon => BloonType.White;
    public override string Icon => "RipeGray-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 55;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Pink);
        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class RipeGrayRegrow : ModBloon<RipeGray>
{
    public override bool Regrow => true;
    public override string Icon => "RipeGrayRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class RipeGrayCamo : ModBloon<RipeGray>
{
    public override bool Camo => true;
    public override string Icon => "RipeGrayCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class RipeGrayRegrowCamo : ModBloon<RipeGray>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "RipeGrayRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Tangerine : ModBloon
{
    public override string BaseBloon => BloonType.White;
    public override string Icon => "Tangerine-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 60;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Pink);
        bloonModel.AddToChildren(ModBloon.BloonID<Lavender>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class TangerineRegrow : ModBloon<Tangerine>
{
    public override bool Regrow => true;
    public override string Icon => "TangerineRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class TangerineCamo : ModBloon<Tangerine>
{
    public override bool Camo => true;
    public override string Icon => "TangerineCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class TangerineRegrowCamo : ModBloon<Tangerine>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "TangerineRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Navy : ModBloon
{
    public override string BaseBloon => BloonType.White;
    public override string Icon => "Navy-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 50;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Aqua>());
        bloonModel.AddToChildren(ModBloon.BloonID<Indigo>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class NavyRegrow : ModBloon<Navy>
{
    public override bool Regrow => true;
    public override string Icon => "NavyRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class NavyCamo : ModBloon<Navy>
{
    public override bool Camo => true;
    public override string Icon => "NavyCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class NavyRegrowCamo : ModBloon<Navy>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "NavyRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Arcane : ModBloon
{
    public override string BaseBloon => BloonType.Purple;
    public override string Icon => "Arcane-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 80;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.Purple | Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Purple);
        bloonModel.AddToChildren(BloonType.Purple);
        bloonModel.AddToChildren(BloonType.Purple);
        bloonModel.AddToChildren(BloonType.Purple);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class ArcaneRegrow : ModBloon<Arcane>
{
    public override bool Regrow => true;
    public override string Icon => "ArcaneRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class ArcaneCamo : ModBloon<Arcane>
{
    public override bool Camo => true;
    public override string Icon => "ArcaneCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class ArcaneRegrowCamo : ModBloon<Arcane>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "ArcaneRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Metal : ModBloon
{
    public override string BaseBloon => BloonType.Lead;
    public override string Icon => "Metal-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 5;
        bloonModel.speed = 35;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.Lead | Il2Cpp.BloonProperties.Black;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Lead);
        bloonModel.AddToChildren(BloonType.Lead);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class MetalRegrow : ModBloon<Metal>
{
    public override bool Regrow => true;
    public override string Icon => "MetalRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class MetalCamo : ModBloon<Metal>
{
    public override bool Camo => true;
    public override string Icon => "MetalCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class MetalRegrowCamo : ModBloon<Metal>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "MetalRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}
public class MetalFortified : ModBloon<Metal>
{
    public override bool Fortified => true;
    public override string Icon => "MetalFortified-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 10;
        bloonModel.MakeChildrenFortified();
    }
}
public class MetalRegrowFortified : ModBloon<Metal>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override string Icon => "MetalRegrowFortified-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 10;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
    }
}
public class MetalFortifiedCamo : ModBloon<Metal>
{
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "MetalFortifiedCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 10;
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}
public class MetalRegrowFortifiedCamo : ModBloon<Metal>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "MetalRegrowFortifiedCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 10;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}

public class Tiger : ModBloon
{
    public override string BaseBloon => BloonType.Zebra;
    public override string Icon => "Tiger-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 61.5f;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Black);
        bloonModel.AddToChildren(ModBloon.BloonID<Gray>());
        bloonModel.AddToChildren(BloonType.White);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class TigerRegrow : ModBloon<Tiger>
{
    public override bool Regrow => true;
    public override string Icon => "TigerRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class TigerCamo : ModBloon<Tiger>
{
    public override bool Camo => true;
    public override string Icon => "TigerCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class TigerRegrowCamo : ModBloon<Tiger>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "TigerRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Midnight : ModBloon
{
    public override string BaseBloon => BloonType.Zebra;
    public override string Icon => "Midnight-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 40;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Tangerine>());
        bloonModel.AddToChildren(ModBloon.BloonID<Navy>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class MidnightRegrow : ModBloon<Midnight>
{
    public override bool Regrow => true;
    public override string Icon => "MidnightRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class MidnightCamo : ModBloon<Midnight>
{
    public override bool Camo => true;
    public override string Icon => "MidnightCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class MidnightRegrowCamo : ModBloon<Midnight>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "MidnightRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Glade : ModBloon
{
    public override string BaseBloon => BloonType.Zebra;
    public override string Icon => "Glade-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 52;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.None;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<RipeGray>());
        bloonModel.AddToChildren(ModBloon.BloonID<RipeGray>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class GladeRegrow : ModBloon<Glade>
{
    public override bool Regrow => true;
    public override string Icon => "GladeRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class GladeCamo : ModBloon<Glade>
{
    public override bool Camo => true;
    public override string Icon => "GladeCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class GladeRegrowCamo : ModBloon<Glade>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "GladeRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Delta : ModBloon
{
    public override string BaseBloon => BloonType.Rainbow;
    public override string Icon => "Delta-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 65;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Tiger>());
        bloonModel.AddToChildren(ModBloon.BloonID<Tiger>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class DeltaRegrow : ModBloon<Delta>
{
    public override bool Regrow => true;
    public override string Icon => "DeltaRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class DeltaCamo : ModBloon<Delta>
{
    public override bool Camo => true;
    public override string Icon => "DeltaCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class DeltaRegrowCamo : ModBloon<Delta>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "DeltaRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Grayscale : ModBloon
{
    public override string BaseBloon => BloonType.Rainbow;
    public override string Icon => "Grayscale-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 49;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Midnight>());
        bloonModel.AddToChildren(ModBloon.BloonID<Tiger>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class GrayscaleRegrow : ModBloon<Grayscale>
{
    public override bool Regrow => true;
    public override string Icon => "GrayscaleRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class GrayscaleCamo : ModBloon<Grayscale>
{
    public override bool Camo => true;
    public override string Icon => "GrayscaleCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class GrayscaleRegrowCamo : ModBloon<Grayscale>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "GrayscaleRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Alpha : ModBloon
{
    public override string BaseBloon => BloonType.Rainbow;
    public override string Icon => "Alpha-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 52.5f;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Grayscale>());
        bloonModel.AddToChildren(BloonType.Rainbow);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class AlphaRegrow : ModBloon<Alpha>
{
    public override bool Regrow => true;
    public override string Icon => "AlphaRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class AlphaCamo : ModBloon<Alpha>
{
    public override bool Camo => true;
    public override string Icon => "AlphaCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class AlphaRegrowCamo : ModBloon<Alpha>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "AlphaRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Prismatic : ModBloon
{
    public override string BaseBloon => BloonType.Rainbow;
    public override string Icon => "Prismatic-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.speed = 60;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Rainbow);
        bloonModel.AddToChildren(BloonType.Rainbow);
        bloonModel.AddToChildren(BloonType.Rainbow);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class PrismaticRegrow : ModBloon<Prismatic>
{
    public override bool Regrow => true;
    public override string Icon => "PrismaticRegrow-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class PrismaticCamo : ModBloon<Prismatic>
{
    public override bool Camo => true;
    public override string Icon => "PrismaticCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class PrismaticRegrowCamo : ModBloon<Prismatic>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "PrismaticRegrowCamo-Icon";

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}

public class Robo : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Robo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Robo-1-Icon", "Robo-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 15;
        bloonModel.speed = 60;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.Lead | Il2Cpp.BloonProperties.Black | Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Metal>());
        bloonModel.AddToChildren(ModBloon.BloonID<Metal>());
        bloonModel.AddToChildren(ModBloon.BloonID<Metal>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class RoboFortified : ModBloon<Robo>
{
    public override bool Fortified => true;
    public override string Icon => "RoboFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "RoboFortified-1-Icon", "RoboFortified-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 30;
        bloonModel.MakeChildrenFortified();
    }
}

public class Stone : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Stone-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] {"Stone-1-Icon", "Stone-2-Icon", "Stone-3-Icon", "Stone-4-Icon", "Stone-5-Icon", "Stone-6-Icon", "Stone-7-Icon", "Stone-8-Icon"};

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 20;
        bloonModel.speed = 64;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Delta>());
        bloonModel.AddToChildren(ModBloon.BloonID<Delta>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class StoneRegrow : ModBloon<Stone>
{
    public override bool Regrow => true;
    public override string Icon => "StoneRegrow-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneRegrow-1-Icon", "StoneRegrow-2-Icon", "StoneRegrow-3-Icon", "StoneRegrow-4-Icon", "StoneRegrow-5-Icon", "StoneRegrow-6-Icon", "StoneRegrow-7-Icon", "StoneRegrow-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class StoneCamo : ModBloon<Stone>
{
    public override bool Camo => true;
    public override string Icon => "StoneCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneCamo-1-Icon", "StoneCamo-2-Icon", "StoneCamo-3-Icon", "StoneCamo-4-Icon", "StoneCamo-5-Icon", "StoneCamo-6-Icon", "StoneCamo-7-Icon", "StoneCamo-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class StoneRegrowCamo : ModBloon<Stone>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "StoneRegrowCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneRegrowCamo-1-Icon", "StoneRegrowCamo-2-Icon", "StoneRegrowCamo-3-Icon", "StoneRegrowCamo-4-Icon", "StoneRegrowCamo-5-Icon", "StoneRegrowCamo-6-Icon", "StoneRegrowCamo-7-Icon", "StoneRegrowCamo-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}
public class StoneFortified : ModBloon<Stone>
{
    public override bool Fortified => true;
    public override string Icon => "StoneFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneFortified-1-Icon", "StoneFortified-2-Icon", "StoneFortified-3-Icon", "StoneFortified-4-Icon", "StoneFortified-5-Icon", "StoneFortified-6-Icon", "StoneFortified-7-Icon", "StoneFortified-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenFortified();
    }
}
public class StoneRegrowFortified : ModBloon<Stone>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override string Icon => "StoneRegrowFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneRegrowFortified-1-Icon", "StoneRegrowFortified-2-Icon", "StoneRegrowFortified-3-Icon", "StoneRegrowFortified-4-Icon", "StoneRegrowFortified-5-Icon", "StoneRegrowFortified-6-Icon", "StoneRegrowFortified-7-Icon", "StoneRegrowFortified-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
    }
}
public class StoneFortifiedCamo : ModBloon<Stone>
{
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "StoneFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneFortifiedCamo-1-Icon", "StoneFortifiedCamo-2-Icon", "StoneFortifiedCamo-3-Icon", "StoneFortifiedCamo-4-Icon", "StoneFortifiedCamo-5-Icon", "StoneFortifiedCamo-6-Icon", "StoneFortifiedCamo-7-Icon", "StoneFortifiedCamo-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}
public class StoneRegrowFortifiedCamo : ModBloon<Stone>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "StoneRegrowFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneRegrowFortifiedCamo-1-Icon", "StoneRegrowFortifiedCamo-2-Icon", "StoneRegrowFortifiedCamo-3-Icon", "StoneRegrowFortifiedCamo-4-Icon", "StoneRegrowFortifiedCamo-5-Icon", "StoneRegrowFortifiedCamo-6-Icon", "StoneRegrowFortifiedCamo-7-Icon", "StoneRegrowFortifiedCamo-8-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}

public class Magma : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Magma-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Magma-1-Icon", "Magma-2-Icon", "Magma-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 20;
        bloonModel.speed = 40;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Alpha>());
        bloonModel.AddToChildren(ModBloon.BloonID<Alpha>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class MagmaRegrow : ModBloon<Magma>
{
    public override bool Regrow => true;
    public override string Icon => "MagmaRegrow-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaRegrow-1-Icon", "MagmaRegrow-2-Icon", "MagmaRegrow-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class MagmaCamo : ModBloon<Magma>
{
    public override bool Camo => true;
    public override string Icon => "MagmaCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaCamo-1-Icon", "MagmaCamo-2-Icon", "MagmaCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class MagmaRegrowCamo : ModBloon<Magma>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "MagmaRegrowCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaRegrowCamo-1-Icon", "MagmaRegrowCamo-2-Icon", "MagmaRegrowCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}
public class MagmaFortified : ModBloon<Magma>
{
    public override bool Fortified => true;
    public override string Icon => "MagmaFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaFortified-1-Icon", "MagmaFortified-2-Icon", "MagmaFortified-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenFortified();
    }
}
public class MagmaRegrowFortified : ModBloon<Magma>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override string Icon => "MagmaRegrowFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaRegrowFortified-1-Icon", "MagmaRegrowFortified-2-Icon", "MagmaRegrowFortified-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
    }
}
public class MagmaFortifiedCamo : ModBloon<Magma>
{
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "MagmaFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaFortifiedCamo-1-Icon", "MagmaFortifiedCamo-2-Icon", "MagmaFortifiedCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}
public class MagmaRegrowFortifiedCamo : ModBloon<Magma>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "MagmaRegrowFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagmaRegrowFortifiedCamo-1-Icon", "MagmaRegrowFortifiedCamo-2-Icon", "MagmaRegrowFortifiedCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}

public class Frost : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Frost-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Frost-1-Icon", "Frost-2-Icon", "Frost-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 20;
        bloonModel.speed = 60;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.White | Il2Cpp.BloonProperties.Lead;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Glade>());
        bloonModel.AddToChildren(ModBloon.BloonID<Glade>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class FrostRegrow : ModBloon<Frost>
{
    public override bool Regrow => true;
    public override string Icon => "FrostRegrow-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostRegrow-1-Icon", "FrostRegrow-2-Icon", "FrostRegrow-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class FrostCamo : ModBloon<Frost>
{
    public override bool Camo => true;
    public override string Icon => "FrostCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostCamo-1-Icon", "FrostCamo-2-Icon", "FrostCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class FrostRegrowCamo : ModBloon<Frost>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "FrostRegrowCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostRegrowCamo-1-Icon", "FrostRegrowCamo-2-Icon", "FrostRegrowCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}
public class FrostFortified : ModBloon<Frost>
{
    public override bool Fortified => true;
    public override string Icon => "FrostFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostFortified-1-Icon", "FrostFortified-2-Icon", "FrostFortified-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenFortified();
    }
}
public class FrostRegrowFortified : ModBloon<Frost>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override string Icon => "FrostRegrowFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostRegrowFortified-1-Icon", "FrostRegrowFortified-2-Icon", "FrostRegrowFortified-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
    }
}
public class FrostFortifiedCamo : ModBloon<Frost>
{
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "FrostFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostFortifiedCamo-1-Icon", "FrostFortifiedCamo-2-Icon", "FrostFortifiedCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}
public class FrostRegrowFortifiedCamo : ModBloon<Frost>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "FrostRegrowFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "FrostRegrowFortifiedCamo-1-Icon", "FrostRegrowFortifiedCamo-2-Icon", "FrostRegrowFortifiedCamo-3-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 40;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}

public class Brick : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Brick-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Brick-1-Icon", "Brick-2-Icon", "Brick-3-Icon", "Brick-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 30;
        bloonModel.speed = 55;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(BloonType.Ceramic);
        bloonModel.AddToChildren(BloonType.Ceramic);

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class BrickRegrow : ModBloon<Brick>
{
    public override bool Regrow => true;
    public override string Icon => "BrickRegrow-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickRegrow-1-Icon", "BrickRegrow-2-Icon", "BrickRegrow-3-Icon", "BrickRegrow-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class BrickCamo : ModBloon<Brick>
{
    public override bool Camo => true;
    public override string Icon => "BrickCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickCamo-1-Icon", "BrickCamo-2-Icon", "BrickCamo-3-Icon", "BrickCamo-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class BrickRegrowCamo : ModBloon<Brick>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "BrickRegrowCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickRegrowCamo-1-Icon", "BrickRegrowCamo-2-Icon", "BrickRegrowCamo-3-Icon", "BrickRegrowCamo-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}
public class BrickFortified : ModBloon<Brick>
{
    public override bool Fortified => true;
    public override string Icon => "BrickFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickFortified-1-Icon", "BrickFortified-2-Icon", "BrickFortified-3-Icon", "BrickFortified-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenFortified();
    }
}
public class BrickRegrowFortified : ModBloon<Brick>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override string Icon => "BrickRegrowFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickRegrowFortified-1-Icon", "BrickRegrowFortified-2-Icon", "BrickRegrowFortified-3-Icon", "BrickRegrowFortified-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
    }
}
public class BrickFortifiedCamo : ModBloon<Brick>
{
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "BrickFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickFortifiedCamo-1-Icon", "BrickFortifiedCamo-2-Icon", "BrickFortifiedCamo-3-Icon", "BrickFortifiedCamo-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}
public class BrickRegrowFortifiedCamo : ModBloon<Brick>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "BrickRegrowFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickRegrowFortifiedCamo-1-Icon", "BrickRegrowFortifiedCamo-2-Icon", "BrickRegrowFortifiedCamo-3-Icon", "BrickRegrowFortifiedCamo-4-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}

public class Polkadot : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Polkadot-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Polkadot-1-Icon", "Polkadot-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 30;
        bloonModel.speed = 58.5f;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Stone>());
        bloonModel.AddToChildren(ModBloon.BloonID<Stone>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class PolkadotRegrow : ModBloon<Polkadot>
{
    public override bool Regrow => true;
    public override string Icon => "PolkadotRegrow-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "PolkadotRegrow-1-Icon", "PolkadotRegrow-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
    }
}
public class PolkadotCamo : ModBloon<Polkadot>
{
    public override bool Camo => true;
    public override string Icon => "PolkadotCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "PolkadotCamo-1-Icon", "PolkadotCamo-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenCamo();
    }
}
public class PolkadotRegrowCamo : ModBloon<Polkadot>
{
    public override bool Regrow => true;
    public override bool Camo => true;
    public override string Icon => "PolkadotRegrowCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] {"PolkadotRegrowCamo-1-Icon", "PolkadotRegrowCamo-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenCamo();
    }
}
public class PolkadotFortified : ModBloon<Polkadot>
{
    public override bool Fortified => true;
    public override string Icon => "PolkadotFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] {"PolkadotFortified-1-Icon", "PolkadotFortified-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenFortified();
    }
}
public class PolkadotRegrowFortified : ModBloon<Polkadot>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override string Icon => "PolkadotRegrowFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] {"PolkadotRegrowFortified-1-Icon", "PolkadotRegrowFortified-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
    }
}
public class PolkadotFortifiedCamo : ModBloon<Polkadot>
{
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "PolkadotFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] {"PolkadotFortifiedCamo-1-Icon", "PolkadotFortifiedCamo-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}
public class PolkadotRegrowFortifiedCamo : ModBloon<Polkadot>
{
    public override bool Regrow => true;
    public override bool Fortified => true;
    public override bool Camo => true;
    public override string Icon => "PolkadotRegrowFortifiedCamo-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] {"PolkadotRegrowFortifiedCamo-1-Icon", "PolkadotRegrowFortifiedCamo-2-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 60;
        bloonModel.MakeChildrenRegrow();
        bloonModel.MakeChildrenFortified();
        bloonModel.MakeChildrenCamo();
    }
}

public class Mega : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Mega-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Mega-1-Icon", "Mega-2-Icon", "Mega-3-Icon", "Mega-4-Icon", "Mega-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 100;
        bloonModel.speed = 50;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Brick>());
        bloonModel.AddToChildren(ModBloon.BloonID<Polkadot>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class MegaFortified : ModBloon<Mega>
{
    public override bool Fortified => true;
    public override string Icon => "MegaFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MegaFortified-1-Icon", "MegaFortified-2-Icon", "MegaFortified-3-Icon", "MegaFortified-4-Icon", "MegaFortified-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 200;
        bloonModel.MakeChildrenFortified();
    }
}

public class Elemental : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Elemental-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Elemental-1-Icon", "Elemental-2-Icon", "Elemental-3-Icon", "Elemental-4-Icon", "Elemental-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 100;
        bloonModel.speed = 44;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.Purple | Il2Cpp.BloonProperties.Black;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Magma>());
        bloonModel.AddToChildren(ModBloon.BloonID<Frost>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class ElementalFortified : ModBloon<Elemental>
{
    public override bool Fortified => true;
    public override string Icon => "ElementalFortified-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "ElementalFortified-1-Icon", "ElementalFortified-2-Icon", "ElementalFortified-3-Icon", "ElementalFortified-4-Icon", "ElementalFortified-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 200;
        bloonModel.MakeChildrenFortified();
    }
}

public class Space : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "Space-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "Space-Icon", "Space-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 250;
        bloonModel.speed = 57;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.Purple | Il2Cpp.BloonProperties.Black | Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Mega>());
        bloonModel.AddToChildren(ModBloon.BloonID<Elemental>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class SpaceFortified : ModBloon<Space>
{
    public override bool Fortified => true;
    public override string Icon => "SpaceFortified-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "SpaceFortified-Icon", "SpaceFortified-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = bloonModel.leakDamage = 500;
        bloonModel.MakeChildrenFortified();
    }
}

//Castle Bloons
public class BrickCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "BrickCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "BrickCastle-1-Icon", "BrickCastle-2-Icon", "BrickCastle-3-Icon", "BrickCastle-4-Icon", "BrickCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 250;
        bloonModel.speed = 25;
        bloonModel.isMoab = true;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Brick>());
        bloonModel.AddToChildren(ModBloon.BloonID<Brick>());
        bloonModel.AddToChildren(ModBloon.BloonID<Brick>());
        bloonModel.AddToChildren(ModBloon.BloonID<Brick>());
        bloonModel.AddToChildren(ModBloon.BloonID<Brick>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class StoneCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "StoneCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "StoneCastle-1-Icon", "StoneCastle-2-Icon", "StoneCastle-3-Icon", "StoneCastle-4-Icon", "StoneCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 475;
        bloonModel.speed = 40;
        bloonModel.isMoab = true;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Polkadot>());
        bloonModel.AddToChildren(ModBloon.BloonID<Polkadot>());
        bloonModel.AddToChildren(ModBloon.BloonID<Polkadot>());
        bloonModel.AddToChildren(ModBloon.BloonID<Polkadot>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class ColorCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "ColorCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "ColorCastle-1-Icon", "ColorCastle-2-Icon", "ColorCastle-3-Icon", "ColorCastle-4-Icon", "ColorCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 100;
        bloonModel.speed = 48.5f;
        bloonModel.isMoab = true;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<ColorfulRed>());
        bloonModel.AddToChildren(ModBloon.BloonID<ColorfulRed>());
        bloonModel.AddToChildren(ModBloon.BloonID<ColorfulYellow>());
        bloonModel.AddToChildren(ModBloon.BloonID<ColorfulYellow>());
        bloonModel.AddToChildren(ModBloon.BloonID<ColorfulBlue>());
        bloonModel.AddToChildren(ModBloon.BloonID<ColorfulBlue>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class TechnoCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "TechnoCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "TechnoCastle-1-Icon", "TechnoCastle-2-Icon", "TechnoCastle-3-Icon", "TechnoCastle-4-Icon", "TechnoCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 500;
        bloonModel.speed = 32.5f;
        bloonModel.isMoab = true;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.Lead | Il2Cpp.BloonProperties.Black | Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Robo>());
        bloonModel.AddToChildren(ModBloon.BloonID<Robo>());
        bloonModel.AddToChildren(ModBloon.BloonID<Robo>());
        bloonModel.AddToChildren(ModBloon.BloonID<Robo>());
        bloonModel.AddToChildren(ModBloon.BloonID<Robo>());
        bloonModel.AddToChildren(ModBloon.BloonID<Robo>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class MagicCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "MagicCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "MagicCastle-1-Icon", "MagicCastle-2-Icon", "MagicCastle-3-Icon", "MagicCastle-4-Icon", "MagicCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 160;
        bloonModel.speed = 60;
        bloonModel.isMoab = true;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.White | Il2Cpp.BloonProperties.Purple;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());
        bloonModel.AddToChildren(ModBloon.BloonID<Arcane>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class GigaCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "GigaCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "GigaCastle-1-Icon", "GigaCastle-2-Icon", "GigaCastle-3-Icon", "GigaCastle-4-Icon", "GigaCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 850;
        bloonModel.speed = 20;
        bloonModel.isMoab = true;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.White;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Mega>());
        bloonModel.AddToChildren(ModBloon.BloonID<Elemental>());
        bloonModel.AddToChildren(ModBloon.BloonID<Mega>());
        bloonModel.AddToChildren(ModBloon.BloonID<Elemental>());
        bloonModel.AddToChildren(ModBloon.BloonID<Mega>());
        bloonModel.AddToChildren(ModBloon.BloonID<Elemental>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}
public class SpaceCastle : ModBloon
{
    public override string BaseBloon => BloonType.Ceramic;
    public override string Icon => "SpaceCastle-1-Icon";
    public override IEnumerable<string> DamageStates => (IEnumerable<string>)new[] { "SpaceCastle-1-Icon", "SpaceCastle-2-Icon", "SpaceCastle-3-Icon", "SpaceCastle-4-Icon", "SpaceCastle-5-Icon" };

    public override void ModifyBaseBloonModel(BloonModel bloonModel)
    {
        bloonModel.maxHealth = 2000;
        bloonModel.speed = 10;
        bloonModel.isMoab = true;
        bloonModel.bloonProperties = Il2Cpp.BloonProperties.White | Il2Cpp.BloonProperties.Black | Il2Cpp.BloonProperties.Purple;

        bloonModel.RemoveAllChildren();

        bloonModel.AddToChildren(ModBloon.BloonID<Space>());
        bloonModel.AddToChildren(ModBloon.BloonID<Space>());
        bloonModel.AddToChildren(ModBloon.BloonID<Space>());
        bloonModel.AddToChildren(ModBloon.BloonID<Space>());
        bloonModel.AddToChildren(ModBloon.BloonID<Space>());

        bloonModel.hasChildrenWithDifferentTotalHealths = false;
        bloonModel.distributeDamageToChildren = true;
    }
}