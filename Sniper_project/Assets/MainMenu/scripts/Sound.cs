using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

    // Use this for initialization
    public AudioSource sound;
    

    public void OnMarkedToggle()
    {
        if (sound.isPlaying)
            sound.Pause();
        else
            sound.Play();
    }

}
