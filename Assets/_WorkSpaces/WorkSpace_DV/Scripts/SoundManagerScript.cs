using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip türSound, baldrianSound, blubbernSound, kaugummiSound, papierSound, standuhrSound, stinkesockeSound, 
        clockFSound, clockRSound, wanduhrSound, buchSound, eheringSound, kaminfeuerSound, katzenSchnurrenSound, katzenSchreiSound, 
        lichtSound, omaSound, schlüsselSound, schraubeSound, wz7Sound, clockTSound;
    private static AudioSource audioSrc;
    private string sceneName;
    private static GameObject SoundManagerBackgroundOld;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;

        audioSrc = GetComponent<AudioSource>();

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

        if (sceneName == "Arbeitszimmer1")
        {
            SoundManagerScript.PlaySound("WanduhrLoop");
        }
        else if (sceneName == "Notiz" || sceneName == "Notiz3")
        {
            SoundManagerScript.PlaySound("Papiersound");
        }
        else if (sceneName == "Eingangshalle1" && PlayerPrefs.GetInt("ClockR") == 1)
        {
            PlayerPrefs.SetInt("ClockR", 0);

            SoundManagerScript.PlaySound("ClockR");
        }
        if (sceneName == "Wohnzimmer2")
        {
            SoundManagerScript.PlaySound("KaminfeuerLoop");
        }
        else if (sceneName == "Wohnzimmer4" && PlayerPrefs.GetInt("lampRepair") != 2)
        {
            SoundManagerScript.PlaySound("LichtLoop");
        }
        if (sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("regalRepair") != 2)
        {
            SoundManagerScript.PlaySound("KatzenschnurrenLoop");
        }
        else if (sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("regalRepair") == 2)
        {
            SoundManagerScript.PlaySound("KatzenschreiLoop");
        }
        else if (sceneName == "Wohnzimmer1" && PlayerPrefs.GetInt("ende") == 1)
        {
            SoundManagerScript.PlaySound("WZ_7Sound");
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
            case "WanduhrLoop":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = wanduhrSound;
                audioSrc.Play();
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
            case "KaminfeuerLoop":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = kaminfeuerSound;
                audioSrc.Play();
                break;
            case "Katzenschnurren":
                audioSrc.PlayOneShot(katzenSchnurrenSound);
                break;
            case "KatzenschnurrenLoop":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = katzenSchnurrenSound;
                audioSrc.Play();
                break;
            case "Katzenschrei":
                audioSrc.PlayOneShot(katzenSchreiSound);
                break;
            case "KatzenschreiLoop":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = katzenSchreiSound;
                audioSrc.Play();
                break;
            case "Licht":
                audioSrc.PlayOneShot(lichtSound);
                break;
            case "LichtLoop":
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = lichtSound;
                audioSrc.Play();
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
                SoundManagerBackgroundOld = GameObject.Find("SoundManagerBackground(Clone)");
                Destroy(SoundManagerBackgroundOld);
                audioSrc.Stop();
                audioSrc.loop = true;
                audioSrc.clip = wz7Sound;
                audioSrc.Play();
                audioSrc.PlayOneShot(omaSound);
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
