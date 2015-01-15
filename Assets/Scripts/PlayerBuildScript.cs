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

<<<<<<< HEAD
    void Update() {
        if (Input.GetButtonDown (m_PXBuild) && ResourcesManagmentScript.p_CurrentGold >= 10) {
            BuildTower ();
=======
    void Update () {
        if (Input.GetButtonDown (m_PXBuild)) {
            Vector3 direction = gameObject.GetComponent<PlayerMovementScript> ().GetDirection ();
            Instantiate (TowerPrefab, new Vector3 (transform.position.x, 0.5f, transform.position.z) + direction, transform.rotation);
>>>>>>> 7dee492dd32c6eb4a0c6f4c7210fa3a0afe13730
        }
    }
}
