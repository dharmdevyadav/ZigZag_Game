using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void OnClickEnd()
    {
        Application.Quit();
        Debug.Log("Quitted");
    }
}
