using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
    public GameObject GoalFX;

    void OnTriggerEnter (Collider other) {
        if ("Ghost" == other.tag) {
            GoalFX.GetComponent<ParticleSystem> ().Play ();
            other.gameObject.GetComponent<GhostScript> ().Death (goalReached: true);
            GameObject.Destroy (other.gameObject);
        }
    }
}
