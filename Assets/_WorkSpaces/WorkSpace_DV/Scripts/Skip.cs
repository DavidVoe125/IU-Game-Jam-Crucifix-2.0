using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour
{
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    public void SkipScene()
    {
        if (sceneName == "Intro")
        {
            SceneManager.LoadScene("Eingangshalle1");
        }
        else if (sceneName == "Outro")
        {
            if (PlayerPrefs.GetInt("startOutro") == 0)
            {
                PlayerPrefs.SetInt("startOutro", 1);
                PlayerPrefs.SetInt("instanceOutro", 1);

                SoundManagerScript.PlaySound("Stop");
                SoundManagerScript.PlaySound("Outro");
            }
            else if (PlayerPrefs.GetInt("startOutro") == 1)
            {
                SceneManager.LoadScene("Credits");
                PlayerPrefs.DeleteAll();
            }
        }
    }
}
