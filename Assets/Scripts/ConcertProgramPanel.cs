using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcertProgramPanel : MonoBehaviour
{
    public GameObject DocumentationUI;
    public GameObject MainMenuUI;

    public void gotoConcertProgram()
    {
        DocumentationUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void gotoMainMenu()
    {
        MainMenuUI.SetActive(true);
        DocumentationUI.SetActive(false);
    }
}
