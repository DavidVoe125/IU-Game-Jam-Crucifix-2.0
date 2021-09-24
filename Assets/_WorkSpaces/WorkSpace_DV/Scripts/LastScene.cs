using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScene : MonoBehaviour
{
    private string sceneName;
    private string lastSceneName;

    private GameObject SoundManagerBackgroundOld;
    public GameObject SoundManagerBackground;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        lastSceneName = PlayerPrefs.GetString("lastSceneName");

        if ((sceneName == "Arbeitszimmer1" || sceneName == "Arbeitszimmer2" || sceneName == "Arbeitszimmer3" || sceneName == "Arbeitszimmer4" || sceneName == "Notiz") &&
            (lastSceneName == "Arbeitszimmer1" || lastSceneName == "Arbeitszimmer2" || lastSceneName == "Arbeitszimmer3" || lastSceneName == "Arbeitszimmer4" || lastSceneName == "Notiz"))
        {
            
        }
        else if ((sceneName == "Eingangshalle1" || sceneName == "Eingangshalle2" || sceneName == "Eingangshalle3" || sceneName == "Eingangshalle4" || sceneName == "Notiz3" || sceneName == "Clock" || sceneName == "Postkarte") && 
                 (lastSceneName == "Eingangshalle1" || lastSceneName == "Eingangshalle2" || lastSceneName == "Eingangshalle3" || lastSceneName == "Eingangshalle4" || lastSceneName == "Notiz3" || lastSceneName == "Clock" || lastSceneName == "Postkarte"))
        {

        }
        else if ((sceneName == "Wohnzimmer1" || sceneName == "Wohnzimmer2" || sceneName == "Wohnzimmer3" || sceneName == "Wohnzimmer4") && 
                 (lastSceneName == "Wohnzimmer1" || lastSceneName == "Wohnzimmer2" || lastSceneName == "Wohnzimmer3" || lastSceneName == "Wohnzimmer4"))
        {
            if (lastSceneName == "Wohnzimmer1" && PlayerPrefs.GetInt("ende") == 1)
            {
                var instance = Instantiate(SoundManagerBackground,
                    new Vector3(0, 0, 0), transform.rotation);
            }
        }
        else if (sceneName == "MainMenu" && lastSceneName == "MainMenu")
        {
            var instance = Instantiate(SoundManagerBackground,
                new Vector3(0, 0, 0), transform.rotation);
        }
        else if ((sceneName == "MainMenu" || sceneName == "SettingsIngame") &&
                 (lastSceneName == "MainMenu" || lastSceneName == "SettingsIngame"))
        {

        }
        else
        {
            SoundManagerBackgroundOld = GameObject.Find("SoundManagerBackground(Clone)");

            if (SoundManagerBackgroundOld != null)
            {
                Destroy(SoundManagerBackgroundOld);
            }

            var instance = Instantiate(SoundManagerBackground,
                new Vector3(0, 0, 0), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        sceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("lastSceneName", sceneName);
    }
}
