using UnityEngine;
using System.Collections;

public class SlowDownTowerScript : NormalTowerScript {
    IEnumerator Shoot () {
        do {
            if (hasValidTarget) {
                GameObject bullet = (GameObject)Instantiate (BulletPrefab, transform.position, transform.rotation);
                bullet.AddComponent<SlowDownBulletScript> ();
                bullet.GetComponent<SlowDownBulletScript> ().target = target;
                hasValidTarget = false;
            }

            yield return new WaitForSeconds (1);
        } while (true);
    }
}
