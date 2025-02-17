// =======================================================================================
// Maintained by bobatea#9400 on Discord
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public partial class UCE_DefinesManager
{

    [DevExtMethods("Constructor")]
    public static void Constructor_UCE_CursedEquipment()
    {
        
        UCE_AddOn addon = new UCE_AddOn();

        addon.name          = "UCE CursedEquipment";
        addon.basis         = "uMMORPG3d V1";
        addon.define        = "_iMMOCURSEDEQUIPMENT";
        addon.author        = "Fhiz";
        addon.version       = "2019.202";
        addon.dependencies  = "none";
        addon.comments      = "none";
        addon.active        = true;

        addons.Add(addon);
    }

}

#endif
