using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour {

    public Transform goal;

    private NavMeshAgent navComponent;

    void Start () {
        navComponent = this.gameObject.GetComponent<NavMeshAgent> ();
    }

    void FixedUpdate () {
        if (goal) {
            navComponent.SetDestination (goal.position);
        }
    }
}
