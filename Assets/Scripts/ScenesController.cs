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

    public void GoAlimenticia()
    {
        SceneManager.LoadScene("Alimenticia");
    }
    public void GoMineria()
    {
        SceneManager.LoadScene("Mineria");
    }
    public void GoOficinas()
    {
        SceneManager.LoadScene("Oficinas");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
