using UnityEngine;
using System.Collections;

public class SlowDownBulletScript : NormalBulletScript {
    override protected void Start () {
        base.Start ();
        speed = 3;
        strength = 0;
        canSlowDown = true;
    }
}
