using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinningZone : MonoBehaviour {

    public Collider player;
    private bool triggered;

    void OnTriggerEnter(Collider collider) 
    {
        if (collider != player)
            return;
        else 
        {
            triggered = true;
            SceneManager.LoadScene("HeadQuarter");
            MouseLock.MouseLocked = false;
        }
    }
}
