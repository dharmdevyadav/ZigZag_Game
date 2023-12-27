using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public bool gamestarted;
    public int Score;
    [SerializeField] int HighScore;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI Highscore;

    private void Awake()
    {
        Highscore.text = "BestScore: " + GetHighScore().ToString();
    }
   /* public void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        Highscore=FindObjectOfType<TextMeshProUGUI>();  
    }*/
    public void GameStarted()
  {
    gamestarted = true;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Return))
    {
      GameStarted();
    }
  }

    public void GameEnd()
    {
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        Score++;
        scoreText.text = "Score: " + Score.ToString();
        if (Score > GetHighScore())
        {
            PlayerPrefs.SetInt("HighScore", Score);
            Highscore.text ="BestScore: "+Score.ToString();
        }
    }

    public int GetHighScore()
    {
        int i = PlayerPrefs.GetInt("HighScore",0);
        return i;
    }
}
