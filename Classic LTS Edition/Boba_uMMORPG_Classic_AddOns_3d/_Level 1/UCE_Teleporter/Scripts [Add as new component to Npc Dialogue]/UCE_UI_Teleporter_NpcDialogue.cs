// =======================================================================================
// Maintained by bobatea#9400 on Discord
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using UnityEngine;
using UnityEngine.UI;

// NPC DIALOGUE

public partial class UCE_UI_Teleporter_NpcDialogue : MonoBehaviour
{
    public GameObject panel;
    public GameObject teleportationPanel;
    public Button teleportationButton;

    // -----------------------------------------------------------------------------------
    // Update
    // -----------------------------------------------------------------------------------
    public void Update()
    {
        Player player = Player.localPlayer;
        if (!player) return;

        if (panel.activeSelf &&
            player.target != null &&
            player.target is Npc &&
            Utils.ClosestDistance(player, player.target) <= player.interactionRange
            )
        {
            teleportationButton.gameObject.SetActive(((Npc)player.target).teleportationDestinations.Length > 0);
            teleportationButton.onClick.SetListener(() =>
            {
                teleportationPanel.SetActive(true);
                panel.SetActive(false);
            });
        }
    }

    // -----------------------------------------------------------------------------------
}
