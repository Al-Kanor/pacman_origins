using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour {

    public int life = 3;
    public Transform goal;
    public GameObject GhostDeathFXPrefab;

    private bool isSlowed = false;

    public void Death () {
        Instantiate (GhostDeathFXPrefab, transform.position, transform.rotation);
        transform.GetChild (0).gameObject.SetActive (false);

        StartCoroutine ("EndOfDeath");
    }

    IEnumerator EndOfDeath () {
        yield return new WaitForSeconds (1);
        GameObject.Destroy (gameObject);
    }

    IEnumerator EndOfSlowDown () {
        yield return new WaitForSeconds (1);
        this.gameObject.GetComponent<NavMeshAgent> ().speed = 3.5f;
        StopCoroutine ("EndOfSlowDown");
    }

    void FixedUpdate () {
        if (isSlowed) {
            StopCoroutine ("EndOfSlowDown");
            StartCoroutine ("EndOfSlowDown");
            isSlowed = false;
        }
    }

    public void SlowDown () {
        isSlowed = true;
        this.gameObject.GetComponent<NavMeshAgent> ().speed = 1;
    }

    void Start () {
        goal = GameObject.Find ("Goal").transform;
        this.gameObject.GetComponent<NavMeshAgent> ().SetDestination (goal.position);
    }
}
