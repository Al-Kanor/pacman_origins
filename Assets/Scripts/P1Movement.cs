using UnityEngine;
using System.Collections;

public class P1Movement : PlayerMovement {
    protected override void Start () {
        base.Start ();
        m_PXHorizontal = "P1Horizontal";
        m_PXVertical = "P1Vertical";
    }
}