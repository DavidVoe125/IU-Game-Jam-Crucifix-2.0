using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string sceneName;
    private string lastSceneName;

    public void GoToScene(string scene)
    {
        sceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("lastSceneName", sceneName);
        SceneManager.LoadScene(scene);
    }

    public void GoToLastScene()
    {
        lastSceneName = PlayerPrefs.GetString("lastSceneName", "MainMenu");
        SceneManager.LoadScene(lastSceneName);
    }
}
