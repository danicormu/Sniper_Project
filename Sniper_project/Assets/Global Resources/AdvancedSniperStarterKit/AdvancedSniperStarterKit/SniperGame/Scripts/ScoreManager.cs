using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public GUISkin skin;
    public int Score;
    public float BestDistance;
    private float lastestDistance;
    private float timeTemp = 0;
    private bool showdistance = false;
    private int scorePlus = 0;
    public float clockTimer = 600.0F;
    public Text text;
    private float minutes;
    private float seconds;
    private string myScore;
    public string oponentScore;

    void Start()
    {
        Score = 0;
        BestDistance = 0;
    }

    void Update()
    {
        clockTimer -= Time.deltaTime;
        minutes = Mathf.Floor(clockTimer / 60);
        seconds = clockTimer % 60;
        text.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        if (showdistance)
        {
            if (Time.time >= timeTemp + 3)
            {
                showdistance = false;
            }
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void AddScore(int score, float distance)
    {
        int bonus = 1;

        if (distance > 500)
            bonus = 2;

        if (distance > 1000)
            bonus = 5;

        if (distance > 1500)
            bonus = 10;

        scorePlus = score * (((int)(distance * 0.1) + 1)) * bonus;
        Score += scorePlus;
        lastestDistance = distance;
        if (distance > BestDistance)
        {
            BestDistance = distance;
        }

        showdistance = true;
        timeTemp = Time.time;
    }
    public int GetScore()
    {
        return this.Score;
    }

    void OnGUI()
    {
        if (skin)
        {
            GUI.skin = skin;
        }
        GUI.skin.label.fontSize = 35;
        GUI.skin.label.normal.textColor = Color.black;
        GUI.skin.label.alignment = TextAnchor.MiddleLeft;
        GUI.Label(new Rect(20, 20, 300, 40), "SCORE " + Score);
        GUI.skin.label.fontSize = 20;
        GUI.Label(new Rect(20, 60, 300, 40), "BEST " + Mathf.Floor(BestDistance) + " M.");

        if (showdistance)
        {
            GUI.skin.label.fontSize = 35;
            GUI.skin.label.alignment = TextAnchor.MiddleCenter;
            GUI.Label(new Rect((Screen.width * 0.5f) - 150, (Screen.height * 0.5f) - 50, 300, 100), Mathf.Floor(lastestDistance) + " M.\n+" + scorePlus);
        }
        if (clockTimer <= 0)
        {
            PauseGame();
            MouseLock.MouseLocked = false;
            myScore = Score.ToString();
            GUI.skin.label.fontSize = 20;
            GUI.Label(new Rect(100, 100, 300, 40), "Your score: " + myScore);
            GUI.Label(new Rect(100, 130, 300, 40), "Oponent Score: " + "Score");
            GUI.Label(new Rect(100, 160 , 300, 40), "winner: " + "Player");
            if (GUI.Button(new Rect(100, 190, 100, 30), "Play Again"))
                SceneManager.LoadScene("Multiplayer");
            if (GUI.Button(new Rect(210, 190, 60, 30), "Quit"))
                SceneManager.LoadScene("MainMenu");
        }
    }
}