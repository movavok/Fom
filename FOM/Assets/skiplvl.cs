using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiplvl : MonoBehaviour
{
    public void nextlvlButton()
    {
        SceneManager.LoadScene(1);
    }
}
