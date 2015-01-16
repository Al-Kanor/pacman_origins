using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    public const int c_Speed = 5;

    protected Rigidbody m_Rigidbody;
    protected Vector3 m_Direction;
    protected string m_PXHorizontal = "";
    protected string m_PXVertical = "";
    protected Transform SpawnZone;
    protected Animator animator;

    protected virtual void Start () {
        m_Rigidbody = this.GetComponent<Rigidbody> ();
        m_Direction = Vector3.forward;
        animator = transform.GetChild(0).GetComponent<Animator> ();
    }

    protected void Update () {
        float h = Input.GetAxisRaw (m_PXHorizontal);
        float v = Input.GetAxisRaw (m_PXVertical);
        Move (h, v);
    }

    public Vector3 GetDirection () {
        return m_Direction;
    }

    public void BackUpToBarrier () {
        this.transform.Translate (0.0f, 0.0f, 0.25f);
    }

    void OnCollisionEnter (Collision other) {
        if ("Ghost" == other.gameObject.tag) {
            transform.position = SpawnZone.position;
        }
    }

    protected void Move (float h, float v) {
        if (h > 0.1f) {
            m_Direction = new Vector3 (1.0f, 0.0f, 0.0f);
            animator.SetTrigger ("Right");
        }
        else if (h < -0.1f) {
            m_Direction = new Vector3 (-1.0f, 0.0f, 0.0f);
            animator.SetTrigger ("Left");
        }
        else if (v > 0.1f) {
            m_Direction = new Vector3 (0.0f, 0.0f, 1.0f);
            animator.SetTrigger ("Up");
        }
        else if (v < -0.1f) {
            m_Direction = new Vector3 (0.0f, 0.0f, -1.0f);
            animator.SetTrigger ("Down");
        }

        if (m_Direction != Vector3.zero) {
            Vector3 movement = m_Direction * c_Speed;
            m_Rigidbody.velocity = movement;
        }
    }
}
