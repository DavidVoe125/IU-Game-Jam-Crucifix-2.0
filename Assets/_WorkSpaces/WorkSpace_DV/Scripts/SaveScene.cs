using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveScene : MonoBehaviour
{
    private string sceneName;
    private string lastSceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("SettingsIngame");
    }
    public void GoToLastScene()
    {
        lastSceneName = PlayerPrefs.GetString("lastSceneName", "MainMenu");
        SceneManager.LoadScene(lastSceneName);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.DeleteAll();
    }
}
