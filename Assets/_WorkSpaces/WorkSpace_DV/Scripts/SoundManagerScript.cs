using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip introSound, outroSound, arbeitszimmerSound, creditsSound, eingangshalleSound, endscene12Sound, endscene34Sound, endscene56Sound, mainMenuSound, wohnzimmerSound, 
        türSound, baldrianSound, blubbernSound, kaugummiSound, papierSound, standuhrSound, stinkesockeSound, clockFSound, clockRSound, wanduhrSound, buchSound, eheringSound, kaminfeuerSound,
        katzenSchnurrenSound, katzenSchreiSound, lichtSound, omaSound, schlüsselSound, schraubeSound, wz7Sound, clockTSound;
    private static AudioSource audioSrc;
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
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
        türSound = Resources.Load<AudioClip>("Sounds/Türsound");
        baldrianSound = Resources.Load<AudioClip>("Sounds/Baldrian");
        blubbernSound = Resources.Load<AudioClip>("Sounds/Blubbern");
        kaugummiSound = Resources.Load<AudioClip>("Sounds/Kaugummi");
        papierSound = Resources.Load<AudioClip>("Sounds/Papiersound");
        standuhrSound = Resources.Load<AudioClip>("Sounds/Standuhr");
        stinkesockeSound = Resources.Load<AudioClip>("Sounds/Stinkesocke");
        clockFSound = Resources.Load<AudioClip>("Sounds/ClockF");
        clockRSound = Resources.Load<AudioClip>("Sounds/ClockR");
        wanduhrSound = Resources.Load<AudioClip>("Sounds/Wanduhr");
        buchSound = Resources.Load<AudioClip>("Sounds/Buch");
        eheringSound = Resources.Load<AudioClip>("Sounds/Ehering");
        kaminfeuerSound = Resources.Load<AudioClip>("Sounds/Kaminfeuer");
        katzenSchnurrenSound = Resources.Load<AudioClip>("Sounds/Katzenschnurren");
        katzenSchreiSound = Resources.Load<AudioClip>("Sounds/Katzenschrei");
        lichtSound = Resources.Load<AudioClip>("Sounds/Licht");
        omaSound = Resources.Load<AudioClip>("Sounds/Oma");
        schlüsselSound = Resources.Load<AudioClip>("Sounds/Schlüssel");
        schraubeSound = Resources.Load<AudioClip>("Sounds/Schraube");
        wz7Sound = Resources.Load<AudioClip>("Sounds/WZ_6Sound");
        clockTSound = Resources.Load<AudioClip>("Sounds/ClockT");

        sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "Arbeitszimmer1" || sceneName == "Arbeitszimmer2" || sceneName == "Arbeitszimmer3" || sceneName == "Arbeitszimmer4" || sceneName == "Notiz")
        {
            SoundManagerScript.PlaySound("Arbeitszimmer");

            if (sceneName == "Arbeitszimmer1")
            {
                SoundManagerScript.PlaySound("Wanduhr");
            }
            else if (sceneName == "Arbeitszimmer2")
            {
                SoundManagerScript.PlaySound("Blubbern");
            }
        }
        if (sceneName == "Eingangshalle1" || sceneName == "Eingangshalle2" || sceneName == "Eingangshalle3" || sceneName == "Eingangshalle4" || sceneName == "Notiz3" || sceneName == "Clock" || sceneName == "Postkarte")
        {
            SoundManagerScript.PlaySound("Eingangshalle");

            if (sceneName == "Notiz" || sceneName == "Notiz3")
            {
                SoundManagerScript.PlaySound("Papiersound");
            }

            if (sceneName == "Eingangshalle1" && PlayerPrefs.GetInt("ClockR") == 1)
            {
                PlayerPrefs.SetInt("ClockR", 0);

                SoundManagerScript.PlaySound("ClockR");
            }
        }
        if (sceneName == "Wohnzimmer1" || sceneName == "Wohnzimmer2" || sceneName == "Wohnzimmer3" || sceneName == "Wohnzimmer4")
        {
            SoundManagerScript.PlaySound("Wohnzimmer");

            if (sceneName == "Wohnzimmer2")
            {
                SoundManagerScript.PlaySound("Kaminfeuer");
            }
            else if (sceneName == "Wohnzimmer4" && PlayerPrefs.GetInt("lampRepair") == 0)
            {
                SoundManagerScript.PlaySound("Licht");
            }

            if (sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("RegalRepair") == 0 || sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("RegalRepair") == 3)
            {
                SoundManagerScript.PlaySound("Katzenschnurren");
            }
            else if (sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("RegalRepair") == 2)
            {
                SoundManagerScript.PlaySound("Katzenschrei");
            }
        }
        if (sceneName == "MainMenu" || sceneName == "Settings" || sceneName == "SettingsIngame")
        {
            SoundManagerScript.PlaySound("Main Menu");
        }
        if (sceneName == "Credits")
        {
            SoundManagerScript.PlaySound("Credits");
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
                audioSrc.PlayOneShot(introSound);
                break;
            case "Outro":
                audioSrc.PlayOneShot(outroSound);
                break;
            case "Arbeitszimmer":
                audioSrc.PlayOneShot(arbeitszimmerSound);
                break;
            case "Credits":
                audioSrc.PlayOneShot(creditsSound);
                break;
            case "Eingangshalle":
                audioSrc.PlayOneShot(eingangshalleSound);
                break;
            case "Endscene12":
                audioSrc.PlayOneShot(endscene12Sound);
                break;
            case "Endscene34":
                audioSrc.PlayOneShot(endscene34Sound);
                break;
            case "Endscene56":
                audioSrc.PlayOneShot(endscene56Sound);
                break;
            case "Main Menu":
                audioSrc.PlayOneShot(mainMenuSound);
                break;
            case "Wohnzimmer":
                audioSrc.PlayOneShot(wohnzimmerSound);
                break;
            case "Türsound":
                audioSrc.PlayOneShot(türSound);
                break;
            case "Baldrian":
                audioSrc.PlayOneShot(baldrianSound);
                break;
            case "Blubbern":
                audioSrc.PlayOneShot(blubbernSound);
                break;
            case "Kaugummi":
                audioSrc.PlayOneShot(kaugummiSound);
                break;
            case "Papiersound":
                audioSrc.PlayOneShot(papierSound);
                break;
            case "Standuhr":
                audioSrc.PlayOneShot(standuhrSound);
                break;
            case "Stinkesocke":
                audioSrc.PlayOneShot(stinkesockeSound);
                break;
            case "Wanduhr":
                audioSrc.PlayOneShot(wanduhrSound);
                break;
            case "Buch":
                audioSrc.PlayOneShot(buchSound);
                break;
            case "Ehering":
                audioSrc.PlayOneShot(eheringSound);
                break;
            case "Kaminfeuer":
                audioSrc.PlayOneShot(kaminfeuerSound);
                break;
            case "Katzenschnurren":
                audioSrc.PlayOneShot(katzenSchnurrenSound);
                break;
            case "Katzenschrei":
                audioSrc.PlayOneShot(katzenSchreiSound);
                break;
            case "Licht":
                audioSrc.PlayOneShot(lichtSound);
                break;
            case "Oma":
                audioSrc.PlayOneShot(omaSound);
                break;
            case "Schlüssel":
                audioSrc.PlayOneShot(schlüsselSound);
                break;
            case "Schraube":
                audioSrc.PlayOneShot(schraubeSound);
                break;
            case "WZ_7Sound":
                audioSrc.PlayOneShot(wz7Sound);
                break;
            case "ClockF":
                audioSrc.PlayOneShot(clockFSound);
                break;
            case "ClockR":
                audioSrc.PlayOneShot(clockRSound);
                break;
            case "ClockT":
                audioSrc.PlayOneShot(clockTSound);
                break;
            case "Stop":
                audioSrc.Stop();
                break;
        }
    }
}
