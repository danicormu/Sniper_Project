using UnityEngine;
using System.Collections;

public class SoundFX : MonoBehaviour {
    public AudioSource FX;

    public void ButtonPressed()
    {
        if (FX.mute == false)
            FX.mute = true;
        else if (FX.mute == true)
            FX.mute = false;
        PlaySound();
    }

    public void PlaySound()
    {
        FX.Play();
    }
}
