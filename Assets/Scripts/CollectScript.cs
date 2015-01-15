using UnityEngine;
using System.Collections;
using System.Linq;

public class CollectScript : MonoBehaviour {
    #region Members
    public const int m_GoldValue = 5;
    private Tile m_Tile;
    private ResourcesManagmentScript m_ResourcesManager;
    #endregion

    void Start () {
        m_ResourcesManager = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
        Vector2 tilePosition = new Vector2 (this.transform.position.x, this.transform.position.z);
        TileGridScript tileGridScript = GameObject.Find ("TileGridManager").GetComponent<TileGridScript> ();
        m_Tile = tileGridScript.m_Grid.FirstOrDefault (x => x.GetPosition ().Equals (tilePosition));
    }

    void OnTriggerEnter (Collider other) {
        if (other.name.Equals ("P1")
            || other.name.Equals ("P2")) {
            //Debug.Log ("Collecté !");
            m_ResourcesManager.p_CurrentGold += m_GoldValue;
            m_Tile.m_HasCollectible = false;
            GameObject.Destroy (this.gameObject);
        }
    }
}
