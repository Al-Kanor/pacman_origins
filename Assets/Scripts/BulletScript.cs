using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    public float speed = 3;
    public int strength = 1;

    IEnumerator DeathAfterDelay () {
        yield return new WaitForSeconds (3);
        GameObject.Destroy (gameObject);
    }

    void FixedUpdate () {
        transform.Rotate (new Vector3 (0, 5, 0));
        transform.Translate (Vector3.forward * speed * Time.fixedDeltaTime);
        speed += 0.1f;
    }

    void OnCollisionEnter (Collision other) {
        if ("Ghost" == other.gameObject.tag) {
            GhostScript ghostScript = other.gameObject.GetComponent<GhostScript> ();
            ghostScript.life -= strength;

            if (ghostScript.life <= 0) {
                ghostScript.Death ();
            }
        }
    }

    void Start () {
        StartCoroutine ("DeathAfterDelay");
    }
}
