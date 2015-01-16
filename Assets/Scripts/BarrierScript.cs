using UnityEngine;
using System.Collections;

public class BarrierScript : MonoBehaviour {
    void Start () {

    }

    void OnTriggerEnter (Collider other) {
        Debug.Log ("Ping");
        if (other.name.Equals ("P1")
            || other.name.Equals ("P2")) {
            other.GetComponent<PlayerMovementScript> ().BackUpToBarrier();
        }
    }
}
