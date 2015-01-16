﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIScript : MonoBehaviour {
    private ResourcesManagmentScript resourcesManagmentScript;

    void FixedUpdate () {
        // Màj score
        transform.GetChild (0).GetComponent<Text> ().text = "Score : " + resourcesManagmentScript.p_CurrentScore;

        // Màj gums
        transform.GetChild (1).GetComponent<Text> ().text = "Gums : " + resourcesManagmentScript.p_CurrentGold;
    }

    void Start () {
        resourcesManagmentScript = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
    }
}
