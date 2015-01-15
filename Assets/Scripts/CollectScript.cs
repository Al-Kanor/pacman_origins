﻿using UnityEngine;
using System.Collections;

public class CollectScript : MonoBehaviour {
    #region Members
    public const int m_GoldValue = 5;
    private ResourcesManagmentScript m_ResourcesManager;
    #endregion

    void Start () {
        m_ResourcesManager = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
    }

    void OnTriggerEnter (Collider other) {
        if (other.name.Equals ("P1")
            || other.name.Equals ("P2")) {
            //Debug.Log ("Collecté !");
            m_ResourcesManager.p_CurrentGold += m_GoldValue;
            GameObject.Destroy (this.gameObject);
        }
    }
}
