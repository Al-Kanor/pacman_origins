using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIScript : MonoBehaviour {
    private ResourcesManagmentScript resourcesManagmentScript;

    void FixedUpdate () {
        // Màj vie
        transform.GetChild (0).GetComponent<Text> ().text = "Gums : " + resourcesManagmentScript.p_CurrentLifePoint;

        // Màj gums
        transform.GetChild (1).GetComponent<Text> ().text = "Gums : " + resourcesManagmentScript.p_CurrentGold;
    }

    void Start () {
        resourcesManagmentScript = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
    }
}
