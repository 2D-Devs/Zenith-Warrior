using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();

        /*#if UNITY_EDITOR*/
        UnityEditor.EditorApplication.isPlaying = false;
        /*#endif*/
    }
}