using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class ResourcesManagmentScript : MonoBehaviour {
    #region Members
    private int m_CurrentGold;
    public int p_CurrentGold {
        get {
            return m_CurrentGold;
        }
        set {
            m_CurrentGold = value;
            //Debug.Log (m_CurrentGold.ToString ());
        }
    }
    public const int c_StartGold = 100;

    private TileGridScript m_TileGridScript;
    #endregion

    protected void Start () {
        p_CurrentGold = c_StartGold;
        m_TileGridScript = GameObject.Find ("TileGridManager").GetComponent<TileGridScript> ();
        this.StartCoroutine ("PopCollectibleCoroutine");
    }

    public IEnumerator PopCollectibleCoroutine () {
        PopCollectible ();
        yield return new WaitForSeconds (1.0f);
        this.StartCoroutine ("PopCollectibleCoroutine");
    }

    public void PopCollectible () {
        Object newCollectible = Resources.Load ("Prefabs/Collectible");

        List<Tile> availableTiles = m_TileGridScript.m_Grid
            .Where (y => y.p_Type == TILE_TYPES.CORRIDOR
                      && !y.m_HasCollectible)
            .ToList ();
        int rngIndex = Random.Range (0, availableTiles.Count () - 1);
        Vector2 popTilePosition = availableTiles[rngIndex].GetPosition ();

        m_TileGridScript.m_Grid.FirstOrDefault (x => x.GetPosition ().Equals (popTilePosition)).m_HasCollectible = true;
        Vector3 popTile3DPosition = new Vector3 (popTilePosition.x, 0.5f, popTilePosition.y);
        GameObject.Instantiate (newCollectible, popTile3DPosition, Quaternion.identity);
    }
}
