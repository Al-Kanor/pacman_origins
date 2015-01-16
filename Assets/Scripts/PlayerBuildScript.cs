using UnityEngine;
using System.Collections;
using System.Linq;

public class PlayerBuildScript : MonoBehaviour {
    public const int c_TowerPrice = 5;
    public GameObject TowerPrefab;
    public ResourcesManagmentScript ResourcesManagmentScript;

    protected TileGridScript m_TileGridScript;
    protected PlayerMovementScript m_PlayerMovementScript;

    protected string m_PXBuild = "";

    protected virtual void Start () {
        m_TileGridScript = GameObject.Find ("TileGridManager").GetComponent<TileGridScript> ();
        m_PlayerMovementScript = this.gameObject.GetComponent<PlayerMovementScript> ();
    }

    void BuildTower () {
        float clampedX = Mathf.Round (transform.position.x);
        clampedX = clampedX < transform.position.x
            ? clampedX + 0.5f
            : clampedX - 0.5f;
        float clampedZ = Mathf.Round (transform.position.z);

        Vector3 spawnPosition = new Vector3 (clampedX, 0.5f, clampedZ) + m_PlayerMovementScript.GetDirection ();
        Vector2 spawn2DPosition = new Vector2 (spawnPosition.x, spawnPosition.z);
        Tile spawnTile = m_TileGridScript.m_Grid.FirstOrDefault (x => x.GetPosition ().Equals (spawn2DPosition));

        if (spawnTile.p_Type == TILE_TYPES.WALL
            && !spawnTile.m_HasTower) {
            SoundScript.Manager.m_TowerBuild.Play ();
            spawnTile.m_HasTower = true;
            Instantiate (TowerPrefab, spawnPosition, transform.rotation);
            ResourcesManagmentScript.p_CurrentGold -= c_TowerPrice;
        }
    }

    void Update () {
        if (Input.GetButtonDown (m_PXBuild) && ResourcesManagmentScript.p_CurrentGold >= c_TowerPrice) {
            BuildTower ();
        }
    }
}
