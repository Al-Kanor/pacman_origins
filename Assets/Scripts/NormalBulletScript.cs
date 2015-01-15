using UnityEngine;
using System.Collections;

public class NormalBulletScript : BulletScript {
    public GameObject target;

    void FixedUpdate () {
        if (null == target) {
            GameObject.Destroy (gameObject);
        }
        else {
            transform.GetChild (0).Rotate (new Vector3 (0, 0, 10));

            float h = 0;
            float v = 0;

            if (transform.position.x < target.transform.position.x) {
                h = 1;
            }
            else if (transform.position.x > target.transform.position.x) {
                h = -1;
            }

            if (transform.position.z < target.transform.position.z) {
                v = 1;
            }
            else if (transform.position.z > target.transform.position.z) {
                v = -1;
            }

            transform.Translate (new Vector3 (h, 0, v) * speed * Time.fixedDeltaTime);
        }
    }

    override protected void Start () {
        base.Start ();
        speed = 3;
        strength = 1;
    }
}
