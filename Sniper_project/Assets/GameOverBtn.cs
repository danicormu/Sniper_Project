using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverBtn : MonoBehaviour {


    public void TryAgainBtn() 
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void QuitGameBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
