using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    public float speed;
    public int strength;

    IEnumerator DeathAfterDelay () {
        yield return new WaitForSeconds (3);
        GameObject.Destroy (gameObject);
    }

    void OnCollisionEnter (Collision other) {
        if ("Ghost" == other.gameObject.tag) {
            GhostScript ghostScript = other.gameObject.GetComponent<GhostScript> ();
            ghostScript.life -= strength;

            if (ghostScript.life <= 0) {
                ghostScript.Death ();
            }

            Destroy (gameObject);
        }
    }

    protected virtual void Start () {
        StartCoroutine ("DeathAfterDelay");
    }
}
