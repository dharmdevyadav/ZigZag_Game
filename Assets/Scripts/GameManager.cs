using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public bool gamestarted;

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
}
