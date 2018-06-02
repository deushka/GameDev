using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void FindGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //TODO// Find server
    }
    public void Quit()
    {
        Debug.Log("QUIT EVENT");
        Application.Quit();
    }
}
