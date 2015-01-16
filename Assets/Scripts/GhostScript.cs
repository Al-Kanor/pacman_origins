using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour {
    #region Members
    public int life = 3;
    public Transform goal;
    public GameObject GhostDeathFXPrefab;

    private bool isSlowed = false;
    private ResourcesManagmentScript m_ResourcesManagmentScript;
    private Transform m_RendererTransform;
    private Quaternion m_RendererRotation;
    #endregion

    void Start () {
        goal = GameObject.Find ("Goal").transform;
        this.gameObject.GetComponent<NavMeshAgent> ().SetDestination (goal.position);
        m_ResourcesManagmentScript = GameObject.Find ("ResourcesManager").GetComponent<ResourcesManagmentScript> ();
        m_RendererTransform = this.transform.FindChild ("Renderer").transform;
        m_RendererRotation = new Quaternion ();
        m_RendererRotation.eulerAngles = new Vector3 (90.0f, 0.0f, 0.0f);
    }

    void FixedUpdate () {
        if (isSlowed) {
            StopCoroutine ("EndOfSlowDown");
            StartCoroutine ("EndOfSlowDown");
            isSlowed = false;
        }
        m_RendererTransform.rotation = m_RendererRotation;
    }

    public void Death (bool goalReached = false) {
        if (!goalReached) {
            Instantiate (GhostDeathFXPrefab, transform.position, transform.rotation);
            m_ResourcesManagmentScript.GetDamage ();
        }
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

    public void SlowDown () {
        isSlowed = true;
        this.gameObject.GetComponent<NavMeshAgent> ().speed = 1;
    }
}
