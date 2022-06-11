using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuButton : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(2);
    }


    public void ExitButton()
    {
        Application.Quit();
    }

}
