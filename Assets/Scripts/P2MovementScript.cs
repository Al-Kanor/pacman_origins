using UnityEngine;
using System.Collections;

public class P2MovementScript : PlayerMovementScript {
    protected override void Start () {
        base.Start ();
        m_PXHorizontal = "P2Horizontal";
        m_PXVertical = "P2Vertical";
        m_PlayerNumber = 2;
        SpawnZone = GameObject.Find ("SpawnZoneP2").transform;
    }
}