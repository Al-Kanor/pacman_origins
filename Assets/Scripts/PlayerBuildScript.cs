using UnityEngine;
using System.Collections;

public class PlayerBuildScript : MonoBehaviour {
    public GameObject TowerPrefab;

    protected string m_PXBuild = "";

    protected virtual void Start () {

    }

    void Update() {
        if (Input.GetButtonDown (m_PXBuild)) {
<<<<<<< HEAD
            Vector3 direction = gameObject.GetComponent<PlayerMovement> ().GetDirection ();
            Instantiate (TowerPrefab, new Vector3(transform.position.x, 0.5f, transform.position.z) + direction, transform.rotation);
=======
            Vector3 direction = gameObject.GetComponent<PlayerMovementScript> ().GetDirection ();
            
            Instantiate (TowerPrefab, new Vector3(transform.position.x, 2, transform.position.z) + direction, transform.rotation);
>>>>>>> 67f0fab055e0bc21858d94ca9890f3a822deb9d5
        }
    }
}
