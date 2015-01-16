using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundScript : MonoBehaviour {
    public static SoundScript Manager = null;

    public Transform SoundPrefab;

    [HideInInspector]
    public List<Transform> Soundprefabs = new List<Transform> ();

    public SoundEffect m_GhostSpawn,
        m_GhostHit,
        m_GhostDeath,
        m_PlayerHit,
        m_FruitLost,
        m_CollectGum;
    //public SoundEffect m_;
    //public SoundEffectCluster Explosions, DressUp_PickUp, Theatre_PickUp;

    void Start () {
        if (Manager == null) {
            Manager = this;
            m_GhostSpawn.mysound = Resources.Load ("Sounds/SFX/") as AudioClip;
            m_GhostHit.mysound = Resources.Load ("Sounds/SFX/") as AudioClip;
            m_GhostDeath.mysound = Resources.Load ("Sounds/SFX/") as AudioClip;
            m_PlayerHit.mysound = Resources.Load ("Sounds/SFX/") as AudioClip;
            m_FruitLost.mysound = Resources.Load ("Sounds/SFX/") as AudioClip;
            m_CollectGum.mysound = Resources.Load ("Sounds/SFX/") as AudioClip;
        }
    }

    public void Play (AudioClip mysound, float pitchou) {
        Transform o;
        if (SoundScript.Manager.Soundprefabs.Count <= 0) {
            o = (Transform)Instantiate (SoundScript.Manager.SoundPrefab);
        }
        else {
            o = SoundScript.Manager.Soundprefabs[0];
            SoundScript.Manager.Soundprefabs.RemoveAt (0);
        }

        o.position = Vector3.zero;
        o.GetComponent<SoundEffectScript> ().soundplay = true;
        o.GetComponent<AudioSource> ().clip = mysound;
        o.GetComponent<AudioSource> ().Play ();
        o.GetComponent<AudioSource> ().pitch = pitchou;
    }
}
