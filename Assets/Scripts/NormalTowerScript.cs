using UnityEngine;
using System.Collections;

public class NormalTowerScript : TowerScript {
    protected bool hasValidTarget = false;
    protected GameObject target;

    IEnumerator Shoot () {
        do {
            if (hasValidTarget) {
                GameObject bullet = (GameObject)Instantiate (BulletPrefab, transform.position, transform.rotation);
                bullet.AddComponent<NormalBulletScript> ();
                bullet.GetComponent<NormalBulletScript> ().target = target;
                hasValidTarget = false;
            }
            
            yield return new WaitForSeconds (0.25f);
        } while (true);
    }

    void OnTriggerStay (Collider other) {
        if ("Ghost" == other.gameObject.tag) {
            target = other.gameObject;
            hasValidTarget = true;
        }
    }
}
