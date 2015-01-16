﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour {
    //private bool isGameOver = false;
    private ResourcesManagmentScript resourcesManagmentScript;
    private GameObject gameOverText;

    void FixedUpdate () {
        if (0 == resourcesManagmentScript.p_CurrentLifePoint) {
            //isGameOver = true;
            gameOverText.GetComponent<Text> ().enabled = true;
        }
    }

    void Start () {
        resourcesManagmentScript = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
        gameOverText = GameObject.Find ("GameOverText");
    }
}
