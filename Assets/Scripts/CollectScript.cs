using UnityEngine;
using System.Collections;

public class CollectScript : MonoBehaviour {
    #region Members
    public const int m_GoldValue = 5;
    private Tile m_Tile;
    private ResourcesManagmentScript m_ResourcesManager;
    #endregion

    void Start () {
        m_ResourcesManager = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
    }

    void OnTriggerEnter (Collider other) {
        if (other.name.Equals ("Gun-man")
            || other.name.Equals ("Build-man")) {
            //Debug.Log ("Collecté !");
            m_ResourcesManager.p_CurrentGold += m_GoldValue;
            m_Tile.m_HasCollectible = false;
            GameObject.Destroy (this.gameObject);
        }
    }
}
