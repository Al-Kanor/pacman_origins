using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {
    public GameObject BulletPrefab;

    void Clamp () {
        StartCoroutine ("Shoot");
        StopCoroutine("Clamp");
    }

    protected virtual void Start () {
        StartCoroutine ("Clamp");
    }
}
