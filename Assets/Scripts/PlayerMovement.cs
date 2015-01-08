﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public const int c_Speed = 2;
    protected Rigidbody m_Rigidbody;
    protected Vector3 m_Direction;

    protected string m_PXHorizontal = "";
    protected string m_PXVertical = "";

    protected virtual void Start () {
        m_Rigidbody = this.GetComponent<Rigidbody> ();
        m_Direction = Vector3.forward;
    }

    protected void Update () {
        float h = Input.GetAxisRaw (m_PXHorizontal);
        float v = Input.GetAxisRaw (m_PXVertical);
        Move (h, v);
    }

    protected void Move (float h, float v) {
        if (h > 0.1f) {
            m_Direction = new Vector3 (1.0f, 0.0f, 0.0f);
        }
        else if (h < -0.1f) {
            m_Direction = new Vector3 (-1.0f, 0.0f, 0.0f);
        }
        else if (v > 0.1f) {
            m_Direction = new Vector3 (0.0f, 0.0f, 1.0f);
        }
        else if (v < -0.1f) {
            m_Direction = new Vector3 (0.0f, 0.0f, -1.0f);
        }

        Vector3 movement = m_Direction * c_Speed * Time.deltaTime;
        m_Rigidbody.MovePosition (this.transform.position + movement);
    }
}