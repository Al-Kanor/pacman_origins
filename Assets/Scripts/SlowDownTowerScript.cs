using UnityEngine;
using System.Collections;

public class SlowDownTowerScript : NormalTowerScript {
    IEnumerator Shoot () {
        do {
            if (hasValidTarget) {
                SoundScript.Manager.m_TowerShoot.Play ();
                GameObject bullet = (GameObject)Instantiate (BulletPrefab, transform.position, transform.rotation);
                bullet.AddComponent<SlowDownBulletScript> ();
                bullet.GetComponent<SlowDownBulletScript> ().target = target;
                hasValidTarget = false;
            }

            yield return new WaitForSeconds (0.25f);
        } while (true);
    }
}
