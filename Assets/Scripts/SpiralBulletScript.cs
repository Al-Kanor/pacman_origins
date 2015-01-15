using UnityEngine;
using System.Collections;

public class SpiralBulletScript : BulletScript {
    void FixedUpdate () {
        transform.Rotate (new Vector3 (0, 5, 0));
        transform.Translate (Vector3.forward * speed * Time.fixedDeltaTime);
        speed += 0.1f;
    }

    override protected void Start () {
        base.Start ();
        speed = 3;
        strength = 1;
    }
}
