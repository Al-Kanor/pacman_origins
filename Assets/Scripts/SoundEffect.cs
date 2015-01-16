using UnityEngine;
using System.Collections;

public class SoundEffect {
    public AudioClip mysound;

    public void Play () {
        SoundScript.Manager.Play (mysound, 1f);
    }

    public void Play (float pitch) {
        SoundScript.Manager.Play (mysound, pitch);
    }
}
