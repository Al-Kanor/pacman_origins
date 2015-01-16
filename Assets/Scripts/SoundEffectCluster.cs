using UnityEngine;
using System.Collections;

public class SoundEffectCluster : MonoBehaviour {
    public AudioClip[] mysound;

    public void Play () {
        SoundScript.Manager.Play (mysound[Random.Range (0, mysound.Length)], 1f);
    }

    public void Play (float pitch) {
        SoundScript.Manager.Play (mysound[Random.Range (0, mysound.Length)], pitch);
    }
}
