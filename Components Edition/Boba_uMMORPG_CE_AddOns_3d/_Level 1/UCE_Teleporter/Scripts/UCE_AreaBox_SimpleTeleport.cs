// =======================================================================================
// Maintained by bobatea#9400 on Discord
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: 
 
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using Mirror;
using UnityEngine;

// SIMPLE TELEPORT AREA

[RequireComponent(typeof(BoxCollider))]
public class UCE_AreaBox_SimpleTeleport : NetworkBehaviour
{
    [Header("[-=-=-=- UCE TELEPORTER -=-=-=-]")]
    [Tooltip("[Optional] One click deactivation")]
    public bool isActive = true;

    [Tooltip("[Required] Any on scene Transform or GameObject OR off scene coordinates (requires UCE Network Zones AddOn)")]
    public UCE_TeleportationTarget teleportationTarget;

    [Header("-=-=- Editor -=-=-")]
    public Color gizmoColor = new Color(0, 1, 1, 0.25f);

    public Color gizmoWireColor = new Color(1, 1, 1, 0.8f);

    // -----------------------------------------------------------------------------------
    // OnDrawGizmos
    // @Editor
    // -----------------------------------------------------------------------------------
    private void OnDrawGizmos()
    {
        BoxCollider collider = GetComponent<BoxCollider>();

        // we need to set the gizmo matrix for proper scale & rotation
        Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.lossyScale);
        Gizmos.color = gizmoColor;
        Gizmos.DrawCube(collider.center, collider.size);
        Gizmos.color = gizmoWireColor;
        Gizmos.DrawWireCube(collider.center, collider.size);
        Gizmos.matrix = Matrix4x4.identity;
    }

    // -----------------------------------------------------------------------------------
    // OnTriggerEnter
    // -----------------------------------------------------------------------------------
    [ServerCallback]
    private void OnTriggerEnter(Collider co)
    {
        Player player = co.GetComponentInParent<Player>();
        if (player && isActive)
            teleportationTarget.OnTeleport(player);
    }

    // -----------------------------------------------------------------------------------
}
