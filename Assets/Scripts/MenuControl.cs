using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public void StartPressed()
    {
        SceneManager.LoadScene("Playground");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void PausePressed()
    {
        SceneManager.LoadScene("Main");
    }

}
