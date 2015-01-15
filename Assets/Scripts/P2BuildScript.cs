using UnityEngine;
using System.Collections;

public class P2BuildScript : PlayerBuildScript {
    protected override void Start () {
        base.Start ();
        m_PXBuild = "P2Build";
    }
}
