using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private int highScore;
    private int score;
    private float timer;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text timeText;

    [SerializeField]
    private Text highScoreText;

    [SerializeField]
    private GameObject gameOverPanel;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            this.score = value;
        }
    }

    public float Timer
    {
        get
        {
            return timer;
        }
        set
        {
            this.timer = value;
        }
    }

    public int HighScore
    {
        get
        {
            return highScore;
        }
        set
        {
            this.highScore = value;
        }
    }

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 60;
        highScore = PlayerPrefsManager.GetHighScore();
        Debug.Log("High Score : " + highScore);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            ChangeScore();
            ChangeTime();
            ChangeHighScore();
        }
       
    }

    void ChangeScore()
    {
        scoreText.text = "Score : " + GameManager.Instance.Score;
    }

    void ChangeHighScore()
    {
        highScoreText.text = "High Score : " + PlayerPrefsManager.GetHighScore();
    }

    void ChangeTime()
    {
        timer -= Time.deltaTime;
        timeText.text = "Time : " + Mathf.Round(GameManager.Instance.Timer);
        if (timer <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        if (highScore < score)
        {
            PlayerPrefsManager.SetHighScore(score);
        }
    }
}
