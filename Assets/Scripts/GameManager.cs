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
        Highscore.text = "Best: " + GetHighScore().ToString();
    }
   
    public void GameStarted()
  {
    gamestarted = true;
        FindObjectOfType<Road>().StartBuilding();

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
            Highscore.text ="Best: "+Score.ToString();
        }
    }

    public int GetHighScore()
    {
        int i = PlayerPrefs.GetInt("HighScore",0);
        return i;
    }
}
