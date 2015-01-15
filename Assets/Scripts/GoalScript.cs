using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
    public GameObject GoalFX;

    void OnTriggerEnter (Collider other) {
        if ("Ghost" == other.tag) {
            GoalFX.GetComponent<ParticleSystem> ().Play ();
            GameObject.Destroy (other.gameObject);
        }
    }
}
