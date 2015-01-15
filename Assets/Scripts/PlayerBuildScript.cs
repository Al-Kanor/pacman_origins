using UnityEngine;
using System.Collections;

public class PlayerBuildScript : MonoBehaviour {
    public GameObject TowerPrefab;
    public ResourcesManagmentScript ResourcesManagmentScript;

    protected string m_PXBuild = "";

    void BuildTower () {
        ResourcesManagmentScript.p_CurrentGold -= 10;
        Vector3 direction = gameObject.GetComponent<PlayerMovementScript> ().GetDirection ();
        Instantiate (TowerPrefab, new Vector3 (transform.position.x, 0.5f, transform.position.z) + direction, transform.rotation);
    }

    protected virtual void Start () {

    }

    void Update() {
        if (Input.GetButtonDown (m_PXBuild) && ResourcesManagmentScript.p_CurrentGold >= 10) {
            BuildTower ();
        }
    }
}
