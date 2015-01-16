using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
    void OnTriggerEnter (Collider other) {
        if ("Ghost" == other.tag) {
            other.gameObject.GetComponent<GhostScript> ().Death (goalReached: true);
            GameObject.Destroy (other.gameObject);
            GameObject.Destroy (this.transform.FindChild ("Fruits").GetChild (0).gameObject);
            SoundScript.Manager.m_FruitLost.Play ();
        }
    }
}
