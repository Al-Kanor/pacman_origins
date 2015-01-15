using UnityEngine;
using System.Collections;

public class PlayerBuildScript : MonoBehaviour {
    public GameObject TowerPrefab;

    protected string m_PXBuild = "";

    protected virtual void Start () {

    }

    void Update() {
        if (Input.GetButtonDown (m_PXBuild)) {
            Vector3 direction = gameObject.GetComponent<PlayerMovement> ().GetDirection ();
            Instantiate (TowerPrefab, new Vector3(transform.position.x, 0.5f, transform.position.z) + direction, transform.rotation);
        }
    }
}
