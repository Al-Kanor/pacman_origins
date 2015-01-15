using UnityEngine;
using System.Collections;

public class SpiralTowerScript : TowerScript {
    IEnumerator Shoot () {
        do {
            GameObject bullet = (GameObject) Instantiate (BulletPrefab, transform.position, transform.rotation);
            bullet.AddComponent<SpiralBulletScript> ();
            yield return new WaitForSeconds (1);
        } while (true);
    }
}
