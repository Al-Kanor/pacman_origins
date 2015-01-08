using UnityEngine;
using System.Collections;

public class P2Movement : PlayerMovement {
    protected override void Start () {
        base.Start ();
        m_PXHorizontal = "P2Horizontal";
        m_PXVertical = "P2Vertical";
    }
}