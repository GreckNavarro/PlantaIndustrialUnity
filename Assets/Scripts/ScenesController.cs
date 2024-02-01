using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public void GoPlastic()
    {
        SceneManager.LoadScene("Plastic");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
