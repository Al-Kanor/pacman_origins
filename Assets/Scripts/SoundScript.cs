using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundScript : MonoBehaviour {
    public static SoundScript Manager = null;

    public Transform SoundPrefab;

    [HideInInspector]
    public List<Transform> Soundprefabs = new List<Transform> ();

    public SoundEffect
        m_GameOver,
        m_GameStart,
        m_TowerBuild,
        m_TowerShoot,
        m_GhostIced,
        m_GhostSpawn,
        m_GhostHit,
        //m_GhostDeath,
        m_P1Hit,
        m_P2Hit,
        m_FruitLost,
        m_CollectGum;
    //public SoundEffect m_;
    //public SoundEffectCluster Explosions, DressUp_PickUp, Theatre_PickUp;

    void Start () {
        if (Manager == null) {
            Manager = this;
            m_GameOver = new SoundEffect ();
            m_GameOver.mysound = Resources.Load ("Sound/SFX/game_over") as AudioClip;
            m_GameStart = new SoundEffect ();
            m_GameStart.mysound = Resources.Load ("Sound/SFX/game_start") as AudioClip;
            m_TowerBuild = new SoundEffect ();
            m_TowerBuild.mysound = Resources.Load ("Sound/SFX/tower_builded") as AudioClip;
            m_TowerShoot = new SoundEffect ();
            m_TowerShoot.mysound = Resources.Load ("Sound/SFX/tower_shoot") as AudioClip;
            m_GhostIced = new SoundEffect ();
            m_GhostIced.mysound = Resources.Load ("Sound/SFX/ghost_iced") as AudioClip;
            m_GhostSpawn = new SoundEffect ();
            m_GhostSpawn.mysound = Resources.Load ("Sound/SFX/ghost_spawn") as AudioClip;
            m_GhostHit = new SoundEffect ();
            m_GhostHit.mysound = Resources.Load ("Sound/SFX/ghost_hurted") as AudioClip;
            m_P1Hit = new SoundEffect ();
            m_P1Hit.mysound = Resources.Load ("Sound/SFX/pacman_respawn") as AudioClip;
            m_P2Hit = new SoundEffect ();
            m_P2Hit.mysound = Resources.Load ("Sound/SFX/mrs_pacman_respawn") as AudioClip;
            m_FruitLost = new SoundEffect ();
            m_FruitLost.mysound = Resources.Load ("Sound/SFX/fruit_lost") as AudioClip;
            m_CollectGum = new SoundEffect ();
            m_CollectGum.mysound = Resources.Load ("Sound/SFX/collectible_drop") as AudioClip;
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
