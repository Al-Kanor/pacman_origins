using UnityEngine;
using System.Collections;

public class PlayerBuildScript : MonoBehaviour {
    public GameObject TowerPrefab;

    protected string m_PXBuild = "";

    protected virtual void Start () {

    }

    void Update() {
        if (Input.GetButtonDown (m_PXBuild)) {
            Vector3 direction = gameObject.GetComponent<PlayerMovementScript> ().GetDirection ();
            
            Instantiate (TowerPrefab, new Vector3(transform.position.x, 2, transform.position.z) + direction, transform.rotation);
        }
    }
}
