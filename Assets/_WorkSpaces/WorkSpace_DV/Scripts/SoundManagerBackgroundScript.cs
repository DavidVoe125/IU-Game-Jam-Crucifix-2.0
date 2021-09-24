using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManagerBackgroundScript : MonoBehaviour
{
    public static AudioClip introSound, outroSound, arbeitszimmerSound, creditsSound, eingangshalleSound, endscene12Sound, endscene34Sound, endscene56Sound, mainMenuSound, wohnzimmerSound;
    private static AudioSource audioSrc;
    private string sceneName;
    private string lastSceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        lastSceneName = PlayerPrefs.GetString("lastSceneName");

        audioSrc = GetComponent<AudioSource>();

        introSound = Resources.Load<AudioClip>("Sounds/Intro");
        outroSound = Resources.Load<AudioClip>("Sounds/Outro");
        arbeitszimmerSound = Resources.Load<AudioClip>("Sounds/Arbeitszimmer");
        creditsSound = Resources.Load<AudioClip>("Sounds/Credits");
        eingangshalleSound = Resources.Load<AudioClip>("Sounds/Eingangshalle");
        endscene12Sound = Resources.Load<AudioClip>("Sounds/Endscene12");
        endscene34Sound = Resources.Load<AudioClip>("Sounds/Endscene34");
        endscene56Sound = Resources.Load<AudioClip>("Sounds/Endscene56");
        mainMenuSound = Resources.Load<AudioClip>("Sounds/Main Menu");
        wohnzimmerSound = Resources.Load<AudioClip>("Sounds/Wohnzimmer");

        DontDestroyOnLoad(this.gameObject);

        if (sceneName == "Arbeitszimmer1" || sceneName == "Arbeitszimmer2" || sceneName == "Arbeitszimmer3" || sceneName == "Arbeitszimmer4" || sceneName == "Notiz")
        {
            SoundManagerBackgroundScript.PlaySound("Arbeitszimmer");
        }
        else if (sceneName == "Eingangshalle1" || sceneName == "Eingangshalle2" || sceneName == "Eingangshalle3" || sceneName == "Eingangshalle4" || sceneName == "Notiz3" || sceneName == "Clock" || sceneName == "Postkarte")
        {
            SoundManagerBackgroundScript.PlaySound("Eingangshalle");
        }
        else if (sceneName == "Wohnzimmer1" || sceneName == "Wohnzimmer2" || sceneName == "Wohnzimmer3" || sceneName == "Wohnzimmer4")
        {
            SoundManagerBackgroundScript.PlaySound("Wohnzimmer");
        }
        else if (sceneName == "Intro")
        {
            SoundManagerBackgroundScript.PlaySound("Intro");
        }
        else if (sceneName == "Outro")
        {
            SoundManagerBackgroundScript.PlaySound("Endscene12");
        }
        else if (sceneName == "MainMenu" || sceneName == "SettingsIngame")
        {
            SoundManagerBackgroundScript.PlaySound("Main Menu");
        }
        else if (sceneName == "Credits")
        {
            SoundManagerBackgroundScript.PlaySound("Credits");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Intro":
                print("test");
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = introSound;
                audioSrc.Play();
                break;
            case "Outro":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = outroSound;
                audioSrc.Play();
                break;
            case "Arbeitszimmer":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = arbeitszimmerSound;
                audioSrc.Play();
                break;
            case "Credits":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = creditsSound;
                audioSrc.Play();
                break;
            case "Eingangshalle":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = eingangshalleSound;
                audioSrc.Play();
                break;
            case "Endscene12":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = endscene12Sound;
                audioSrc.Play();
                break;
            case "Endscene34":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = endscene34Sound;
                audioSrc.Play();
                break;
            case "Endscene56":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = endscene56Sound;
                audioSrc.Play();
                break;
            case "Main Menu":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = mainMenuSound;
                audioSrc.Play();
                break;
            case "Wohnzimmer":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = wohnzimmerSound;
                audioSrc.Play();
                break;
        }
    }
}
