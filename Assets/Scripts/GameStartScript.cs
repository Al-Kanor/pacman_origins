using UnityEngine;
using System.Collections;

public class GameStartScript : MonoBehaviour {
    void Start () {
        SoundScript.Manager.m_GameStart.Play ();
    }
}
