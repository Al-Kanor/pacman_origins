using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
    public GameObject RedGhostPrefab;
    public GameObject PinkGhostPrefab;
    public GameObject GreenGhostPrefab;
    public GameObject YellowGhostPrefab;

    void SpawnGhost () {
        int rand = Random.Range (0, 4);

        switch (rand) {
            case 0:
                Instantiate (RedGhostPrefab, transform.position, transform.rotation);
                break;
            case 1:
                Instantiate (PinkGhostPrefab, transform.position, transform.rotation);
                break;
            case 2:
                Instantiate (GreenGhostPrefab, transform.position, transform.rotation);
                break;
            case 3:
                Instantiate (YellowGhostPrefab, transform.position, transform.rotation);
                break;
        }
        
    }

    IEnumerator SpawnGhosts () {
        do {
            // Chaque seconde, 1 chance sur X de spawn un ghost
            if (0 == (int)Random.Range (0, 12)) {
                SpawnGhost ();
            }
            
            yield return new WaitForSeconds (1);
        } while (true);
    }

    void Start () {
        StartCoroutine ("SpawnGhosts");
    }
}
