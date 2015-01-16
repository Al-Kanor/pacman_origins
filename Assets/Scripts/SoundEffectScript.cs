using UnityEngine;
using System.Collections;

public class SoundEffectScript : MonoBehaviour {
    public bool soundplay = true;

    void Update () {
        if (GetComponent<AudioSource> ().isPlaying == false
            && soundplay) {
            soundplay = false;
            SoundScript.Manager.Soundprefabs.Add (transform);
        }
    }
}
