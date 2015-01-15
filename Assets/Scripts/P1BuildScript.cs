using UnityEngine;
using System.Collections;

public class P1BuildScript : PlayerBuildScript {
    protected override void Start () {
        base.Start ();
        m_PXBuild = "P1Build";
    }
}
