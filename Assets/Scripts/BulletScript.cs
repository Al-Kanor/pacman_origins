﻿using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    public float speed;
    public int strength;
    public bool canSlowDown = false;

    private ResourcesManagmentScript resourcesManagmentScript;

    IEnumerator DeathAfterDelay () {
        yield return new WaitForSeconds (3);
        GameObject.Destroy (gameObject);
    }

    void OnCollisionEnter (Collision other) {
        if ("Ghost" == other.gameObject.tag) {
            GhostScript ghostScript = other.gameObject.GetComponent<GhostScript> ();
            ghostScript.life -= strength;
            SoundScript.Manager.m_GhostHit.Play ();

            if (canSlowDown) {
                ghostScript.SlowDown ();
                SoundScript.Manager.m_GhostIced.Play ();
            }

            if (ghostScript.life <= 0) {
                ghostScript.Death ();
                resourcesManagmentScript.p_CurrentScore++;
            }

            Destroy (gameObject);
        }
    }

    protected virtual void Start () {
        resourcesManagmentScript = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
        StartCoroutine ("DeathAfterDelay");
    }
}
