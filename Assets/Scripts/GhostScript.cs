using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour {

    public int life = 3;
    public Transform goal;
    public GameObject GhostDeathFXPrefab;

    private NavMeshAgent navComponent;

    public void Death () {
        Instantiate (GhostDeathFXPrefab, transform.position, transform.rotation);
        transform.GetChild (0).gameObject.SetActive (false);

        StartCoroutine ("EndOfDeath");
    }

    IEnumerator EndOfDeath () {
        yield return new WaitForSeconds (1);
        GameObject.Destroy (gameObject);
    }

    void Start () {
        goal = GameObject.Find ("Goal").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent> ();
    }

    void FixedUpdate () {
        if (goal) {
            navComponent.SetDestination (goal.position);
        }
    }
}
