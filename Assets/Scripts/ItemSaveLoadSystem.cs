using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class ItemSaveLoadSystem : MonoBehaviour
{ 
    private Transform parentObj;

    public int buchN = 0;
    public GameObject baldrianItem;
    public GameObject baldrian; //1
    public int baldrianN = 1;
    public GameObject stinkesockeItem;
    public GameObject stinkesocke; //2
    public int stinkesockeN = 2;
    public GameObject kaugummiItem;
    public GameObject kaugummi; //3
    public int kaugummiN = 3;
    public GameObject eheringItem;
    public GameObject ehering; //4
    public int eheringN = 4;
    public GameObject bild; //5
    public int bildN = 5;
    public GameObject schlüssel; //7
    public int schlüsselItemN = 6;
    public int schlüsselN = 7;
    public GameObject schraubeItem;
    public GameObject schraube; //8
    public int schraubeN = 8;
    public GameObject kuckuck; //9
    public int kuckuckN = 9;
    public GameObject schlüsselTür; //10
    public int schlüsselTürN = 10;
    public GameObject EH_1; //11
    public int EH_1N = 11;
    public GameObject EH_2; //12
    public int EH_2N = 12;
    public GameObject EH_3; //13
    public int EH_3N = 13;
    public GameObject WZ_1; //14
    public int WZ_1N = 14;
    public GameObject WZ_2; //15
    public int WZ_2N = 15;
    public GameObject WZ_3; //16
    public int WZ_3N = 16;
    public GameObject WZ_4; //17
    public int WZ_4N = 17;
    public GameObject WZ_5; //18
    public int WZ_5N = 18;
    public GameObject WZ_6; //19
    public int WZ_6N = 19;
    public GameObject WZ_7; //20
    public int WZ_7N = 20;
    public GameObject Oma; //21
    public int OmaN = 21;
    public GameObject Katze; //22
    public int KatzeN = 22;
    public GameObject Mädchen; //23
    public int MädchenN = 23;
    public GameObject Junge; //24
    public int JungeN = 24;
    public GameObject MädchenF; //25
    public int MädchenFN = 25;
    public GameObject JungeF; //26
    public int JungeFN = 26;


    public GameObject[] itemPrefabs;

    public int baldrianC;
    public float baldrianX;
    public float baldrianY;

    public int stinkesockeC;
    public float stinkesockeX;
    public float stinkesockeY;

    public int kaugummiC;
    public float kaugummiX;
    public float kaugummiY;

    public int eheringC;
    public float eheringX;
    public float eheringY;

    public int bildC;
    public float bildX;
    public float bildY;

    public int schlüsselC;
    public float schlüsselX;
    public float schlüsselY;

    public int schlüsselTürC;
    public float schlüsselTürX;
    public float schlüsselTürY;

    public int schraubeC;
    public float schraubeX;
    public float schraubeY;

    public int kuckuckC;
    public float kuckuckX;
    public float kuckuckY;

    public int eh_1C;
    public int eh_2C;
    public int eh_3C;

    public int wz_1C;
    public int wz_2C;
    public int wz_3C;
    public int wz_4C;
    public int wz_5C;
    public int wz_6C;
    public int wz_7C;

    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        
        baldrianC = PlayerPrefs.GetInt("baldrianCheck");
        baldrianX = PlayerPrefs.GetFloat("baldrianXPos");
        baldrianY = PlayerPrefs.GetFloat("baldrianYPos");

        stinkesockeC = PlayerPrefs.GetInt("stinkesockeCheck");
        stinkesockeX = PlayerPrefs.GetFloat("stinkesockeXPos");
        stinkesockeY = PlayerPrefs.GetFloat("stinkesockeYPos");

        kaugummiC = PlayerPrefs.GetInt("kaugummiCheck");
        kaugummiX = PlayerPrefs.GetFloat("kaugummiXPos");
        kaugummiY = PlayerPrefs.GetFloat("kaugummiYPos");

        eheringC = PlayerPrefs.GetInt("eheringCheck");
        eheringX = PlayerPrefs.GetFloat("eheringXPos");
        eheringY = PlayerPrefs.GetFloat("eheringYPos");

        bildC = PlayerPrefs.GetInt("bildCheck");
        bildX = PlayerPrefs.GetFloat("bildXPos");
        bildY = PlayerPrefs.GetFloat("bildYPos");

        schlüsselC = PlayerPrefs.GetInt("schlüsselCheck");
        schlüsselX = PlayerPrefs.GetFloat("schlüsselXPos");
        schlüsselY = PlayerPrefs.GetFloat("schlüsselYPos");

        schlüsselTürC = PlayerPrefs.GetInt("schlüsselTürCheck");
        schlüsselTürX = PlayerPrefs.GetFloat("schlüsselTürXPos");
        schlüsselTürY = PlayerPrefs.GetFloat("schlüsselTürYPos");

        schraubeC = PlayerPrefs.GetInt("schraubeCheck");
        schraubeX = PlayerPrefs.GetFloat("schraubeXPos");
        schraubeY = PlayerPrefs.GetFloat("schraubeYPos");

        kuckuckC = PlayerPrefs.GetInt("kuckuckCheck");
        kuckuckX = PlayerPrefs.GetFloat("kuckuckXPos");
        kuckuckY = PlayerPrefs.GetFloat("kuckuckYPos");

        eh_1C = PlayerPrefs.GetInt("eh_1Check");
        eh_2C = PlayerPrefs.GetInt("eh_2Check");
        eh_3C = PlayerPrefs.GetInt("eh_3Check");

        wz_1C = PlayerPrefs.GetInt("wz_1Check");
        wz_2C = PlayerPrefs.GetInt("wz_2Check");
        wz_3C = PlayerPrefs.GetInt("wz_3Check");
        wz_4C = PlayerPrefs.GetInt("wz_4Check");
        wz_5C = PlayerPrefs.GetInt("wz_5Check");
        wz_6C = PlayerPrefs.GetInt("wz_6Check");
        wz_7C = PlayerPrefs.GetInt("wz_7Check");

        // Transform Komponente wird als Variable gespeichert
        parentObj = GetComponent<Transform>();

        if (sceneName == "Arbeitszimmer3" && baldrianC > 0)
        {
            baldrianItem = GameObject.Find("BaldrianItem");
            Destroy(baldrianItem);
        }

        if (sceneName == "Arbeitszimmer4" && stinkesockeC > 0)
        {
            stinkesockeItem = GameObject.Find("StinkesockeItem");
            Destroy(stinkesockeItem);
        }

        if (sceneName == "Arbeitszimmer4" && kaugummiC > 0)
        {
            kaugummiItem = GameObject.Find("KaugummiItem");
            Destroy(kaugummiItem);
        }

        if (sceneName == "OpenBox" && eheringC > 0)
        {
            eheringItem = GameObject.Find("EheringItem");
            Destroy(eheringItem);
        }

        if (sceneName == "Wohnzimmer2" && schraubeC > 0)
        {
            eheringItem = GameObject.Find("SchraubeItem");
            Destroy(eheringItem);
        }

        if (PlayerPrefs.GetInt("regalRepair") == 2 && sceneName == "Wohnzimmer3")
        {
            var instance = Instantiate(itemPrefabs[buchN],
                new Vector3(0, 0, 0),
                transform.rotation);
        }

        if(PlayerPrefs.GetInt("schlüsselFreigabe") == 2)
        {
            var instance = Instantiate(itemPrefabs[schlüsselItemN],
                new Vector3(2.48f, -2.85f, 0),
                transform.rotation);
        }

        if (sceneName == "Eingangshalle1" && PlayerPrefs.GetInt("eh_1Check") == 0)
        {
            PlayerPrefs.SetInt("eh_1Check", 1);

            var instance = Instantiate(itemPrefabs[EH_1N],
                new Vector3(0.15f, -2.16f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[JungeN],
                new Vector3(-5.28f, -2.05f, 0),
                transform.rotation);
            var instance3 = Instantiate(itemPrefabs[MädchenN],
                new Vector3(-4.16f, -2.74f, 0),
                transform.rotation);
        }

        if (sceneName == "Eingangshalle4" && PlayerPrefs.GetInt("eh_2Check") == 1)
        {
            PlayerPrefs.SetInt("eh_2Check", 2);

            var instance = Instantiate(itemPrefabs[EH_2N],
                new Vector3(-4.79f, -0.67f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[JungeFN],
                new Vector3(1.37f, -3.3f, 0),
                transform.rotation);
            var instance3 = Instantiate(itemPrefabs[MädchenFN],
                new Vector3(-0.49f, -2.96f, 0),
                transform.rotation);
        }
        
        if (sceneName == "Wohnzimmer2" && PlayerPrefs.GetInt("wz_1Check") == 0 || sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("wz_1Check") == 0)
        {
            var instance = Instantiate(itemPrefabs[WZ_1N],
                new Vector3(4.19f, -0.68f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[OmaN],
                new Vector3(-2.19f, -2.36f, 0),
                transform.rotation);

            SoundManagerScript.PlaySound("Oma");
        }

        // Wenn "baldrianC" aussagt, dass "baldrian" existiert
        if (baldrianC == 1)
        {
            // "baldrian"-Prefab wird an den Koordinaten "baldrianX" und "baldrianY" initiert
            var instance = Instantiate(itemPrefabs[baldrianN],
                new Vector3(baldrianX, baldrianY, 0),
                transform.rotation);
            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;
            baldrian = instance;
        }
        // Wenn "baldrianC" aussagt, dass "baldrian" nicht existiert
        else
        {
            print("Baldrian existiert nicht");
        }

        if (stinkesockeC == 1)
        {
            var instance = Instantiate(itemPrefabs[stinkesockeN],
                new Vector3(stinkesockeX, stinkesockeY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            stinkesocke = instance;
        }

        if (kaugummiC == 1)
        {
            print("Kaugummi erstellt");
            var instance = Instantiate(itemPrefabs[kaugummiN],
                new Vector3(kaugummiX, kaugummiY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            kaugummi = instance;
        }

        if (eheringC == 1)
        {
            var instance = Instantiate(itemPrefabs[eheringN],
                new Vector3(eheringX, eheringY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            ehering = instance;
        }

        if (schraubeC == 1)
        {
            var instance = Instantiate(itemPrefabs[schraubeN],
                new Vector3(schraubeX, schraubeY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            schraube = instance;
        }

        if (schlüsselC == 1)
        {
            var instance = Instantiate(itemPrefabs[schlüsselN],
                new Vector3(schlüsselX, schlüsselY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            schlüssel = instance;
        }

        if (schlüsselTürC == 1)
        {
            var instance = Instantiate(itemPrefabs[schlüsselTürN],
                new Vector3(schlüsselTürX, schlüsselTürY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            schlüsselTür = instance;
        }

        if (bildC == 1)
        {
            var instance = Instantiate(itemPrefabs[bildN],
                new Vector3(bildX, bildY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            bild = instance;
        }

        if (kuckuckC == 1)
        {
            var instance = Instantiate(itemPrefabs[kuckuckN],
                new Vector3(kuckuckX, kuckuckY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            kuckuck = instance;
        }
    }

    void OnDestroy()
    {
        // Wenn "baldrianC" aussagt, dass "baldrian" existiert
        if (baldrianC == 1)
        {
            print("Baldrian gespeichert");

            //Wenn "baldrian"-Variable nicht leer ist
            if (baldrian != null)
            {
                print(baldrian.transform.position.x);
                // X-Position von "baldrian" wird als PlayerPref gespeichert
                PlayerPrefs.SetFloat("baldrianXPos", baldrian.transform.position.x);
                // Y-Position von "baldrian" wird als PlayerPref gespeichert
                PlayerPrefs.SetFloat("baldrianYPos", baldrian.transform.position.y);
            }
        }

        if (stinkesockeC == 1)
        {
            if (stinkesocke != null)
            {
                PlayerPrefs.SetFloat("stinkesockeXPos", stinkesocke.transform.position.x);
                PlayerPrefs.SetFloat("stinkesockeYPos", stinkesocke.transform.position.y);
            }
        }

        if (kaugummiC == 1)
        {
            if (kaugummi != null)
            {
                PlayerPrefs.SetFloat("kaugummiXPos", kaugummi.transform.position.x);
                PlayerPrefs.SetFloat("kaugummiYPos", kaugummi.transform.position.y);
            }
        }

        if (eheringC == 1)
        {
            if (ehering != null)
            {
                PlayerPrefs.SetFloat("eheringXPos", ehering.transform.position.x);
                PlayerPrefs.SetFloat("eheringYPos", ehering.transform.position.y);
            }
        }

        if (schraubeC == 1)
        {
            if (schraube != null)
            {
                PlayerPrefs.SetFloat("schraubeXPos", schraube.transform.position.x);
                PlayerPrefs.SetFloat("schraubeYPos", schraube.transform.position.y);
            }
        }

        if (schlüsselC == 1)
        {
            if (schlüssel != null)
            {
                PlayerPrefs.SetFloat("schlüsselXPos", schlüssel.transform.position.x);
                PlayerPrefs.SetFloat("schlüsselYPos", schlüssel.transform.position.y);
            }
        }

        if (schlüsselTürC == 1)
        {
            if (schlüsselTür != null)
            {
                PlayerPrefs.SetFloat("schlüsselTürXPos", schlüsselTür.transform.position.x);
                PlayerPrefs.SetFloat("schlüsselTürYPos", schlüsselTür.transform.position.y);
            }
        }

        if (bildC == 1)
        {
            if (bild != null)
            {
                PlayerPrefs.SetFloat("bildXPos", bild.transform.position.x);
                PlayerPrefs.SetFloat("bildYPos", bild.transform.position.y);
            }
        }

        if (kuckuckC == 1)
        {
            if (kuckuck != null)
            {
                PlayerPrefs.SetFloat("kuckuckXPos", kuckuck.transform.position.x);
                PlayerPrefs.SetFloat("kuckuckYPos", kuckuck.transform.position.y);
            }
        }

        PlayerPrefs.SetInt("wz_6Check", 0);
    }

    // Update is called once per frame
    void Update()
    {
        baldrianC = PlayerPrefs.GetInt("baldrianCheck");
        baldrianX = PlayerPrefs.GetFloat("baldrianXPos");
        baldrianY = PlayerPrefs.GetFloat("baldrianYPos");

        baldrianC = PlayerPrefs.GetInt("baldrianCheck");
        baldrianX = PlayerPrefs.GetFloat("baldrianXPos");
        baldrianY = PlayerPrefs.GetFloat("baldrianYPos");

        stinkesockeC = PlayerPrefs.GetInt("stinkesockeCheck");
        stinkesockeX = PlayerPrefs.GetFloat("stinkesockeXPos");
        stinkesockeY = PlayerPrefs.GetFloat("stinkesockeYPos");

        kaugummiC = PlayerPrefs.GetInt("kaugummiCheck");
        kaugummiX = PlayerPrefs.GetFloat("kaugummiXPos");
        kaugummiY = PlayerPrefs.GetFloat("kaugummiYPos");

        eheringC = PlayerPrefs.GetInt("eheringCheck");
        eheringX = PlayerPrefs.GetFloat("eheringXPos");
        eheringY = PlayerPrefs.GetFloat("eheringYPos");

        bildC = PlayerPrefs.GetInt("bildCheck");
        bildX = PlayerPrefs.GetFloat("bildXPos");
        bildY = PlayerPrefs.GetFloat("bildYPos");

        schlüsselC = PlayerPrefs.GetInt("schlüsselCheck");
        schlüsselX = PlayerPrefs.GetFloat("schlüsselXPos");
        schlüsselY = PlayerPrefs.GetFloat("schlüsselYPos");

        schlüsselTürC = PlayerPrefs.GetInt("schlüsselTürCheck");
        schlüsselTürX = PlayerPrefs.GetFloat("schlüsselTürXPos");
        schlüsselTürY = PlayerPrefs.GetFloat("schlüsselTürYPos");

        schraubeC = PlayerPrefs.GetInt("schraubeCheck");
        schraubeX = PlayerPrefs.GetFloat("schraubeXPos");
        schraubeY = PlayerPrefs.GetFloat("schraubeYPos");

        eh_3C = PlayerPrefs.GetInt("eh_3Check");

        wz_2C = PlayerPrefs.GetInt("wz_2Check");

        if (baldrianC == 2)
        {
            // "baldrian"-Prefab wird an den Start-Koordinaten initiert
            var instance = Instantiate(itemPrefabs[baldrianN],
                new Vector3(2.9f, -1.5f, 0),
                transform.rotation);

            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;
            baldrian = instance;

            PlayerPrefs.SetInt("baldrianCheck", 1);

            SoundManagerScript.PlaySound("Baldrian");
        }
        else if (stinkesockeC == 2)
        {
            var instance = Instantiate(itemPrefabs[stinkesockeN],
                new Vector3(0, 0, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            stinkesocke = instance;

            PlayerPrefs.SetInt("stinkesockeCheck", 1);

            SoundManagerScript.PlaySound("Stinkesocke");
        }
        else if (kaugummiC == 2)
        {
            var instance = Instantiate(itemPrefabs[kaugummiN],
                new Vector3(1.367f, -1.53f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            kaugummi = instance;

            PlayerPrefs.SetInt("kaugummiCheck", 1);

            SoundManagerScript.PlaySound("Kaugummi");
        }
        else if (eheringC == 2)
        {
            var instance = Instantiate(itemPrefabs[eheringN],
                new Vector3(1.76f, -1.13f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            ehering = instance;

            PlayerPrefs.SetInt("eheringCheck", 1);

            SoundManagerScript.PlaySound("Ehering");
        }
        else if (schlüsselC == 2)
        {
            var instance = Instantiate(itemPrefabs[schlüsselN],
                new Vector3(4.34f, 0.95f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            schlüssel = instance;

            PlayerPrefs.SetInt("schlüsselCheck", 1);

            SoundManagerScript.PlaySound("Schlüssel");
        }
        else if (schlüsselTürC == 2)
        {
            var instance = Instantiate(itemPrefabs[schlüsselTürN],
                new Vector3(4.34f, 0.95f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            schlüsselTür = instance;

            PlayerPrefs.SetInt("schlüsselTürCheck", 1);

            SoundManagerScript.PlaySound("Schlüssel");
        }
        else if (schraubeC == 2)
        {
            var instance = Instantiate(itemPrefabs[schraubeN],
                new Vector3(3.1f, -4.8f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            schraube = instance;

            PlayerPrefs.SetInt("schraubeCheck", 1);

            SoundManagerScript.PlaySound("Schlüssel");
        }

        if (PlayerPrefs.GetInt("KellerItems") == 4)
        {
            var instance = Instantiate(itemPrefabs[bildN],
                new Vector3(4.73f, -1.71f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            bild = instance;

            PlayerPrefs.SetInt("bildCheck", 1);
            PlayerPrefs.SetInt("KellerItems", 5);
            PlayerPrefs.SetInt("vorhangFreigabe", 1);
        }

        if (PlayerPrefs.GetInt("regalRepair") == 1)
        {
            var instance = Instantiate(itemPrefabs[buchN],
                new Vector3(0, 0, 0),
                transform.rotation);

            PlayerPrefs.SetInt("regalRepair", 2);
            SoundManagerScript.PlaySound("Buch");
        }

        if (PlayerPrefs.GetInt("schlüsselTürUsed") == 3)
        {
            PlayerPrefs.SetInt("schlüsselTürUsed", 4);
            PlayerPrefs.SetInt("schlüsselTürCheck", 0);

            Destroy(schlüsselTür);
        }

        if (sceneName == "Eingangshalle3" && PlayerPrefs.GetInt("eh_3Check") == 1)
        {
            PlayerPrefs.SetInt("eh_3Check", 0);

            var instance = Instantiate(itemPrefabs[EH_3N],
                new Vector3(-2.23f, 0.1f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[JungeFN],
                new Vector3(1.93f, -2.12f, 0),
                transform.rotation);
            var instance3 = Instantiate(itemPrefabs[MädchenFN],
                new Vector3(3.79f, -2.46f, 0),
                transform.rotation);
        }

        if (sceneName == "Wohnzimmer2" && PlayerPrefs.GetInt("wz_2Check") == 1 || sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("wz_2Check") == 1)
        {
            PlayerPrefs.SetInt("wz_2Check", 0);

            var instance = Instantiate(itemPrefabs[WZ_2N],
                new Vector3(4.19f, -0.68f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[OmaN],
                new Vector3(-2.19f, -2.36f, 0),
                transform.rotation);

            SoundManagerScript.PlaySound("Oma");
        }

        if (sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("wz_3Check") == 1)
        {
            PlayerPrefs.SetInt("wz_3Check", 0);
            PlayerPrefs.SetInt("katzeJammern", 1);

            var instance = Instantiate(itemPrefabs[WZ_3N],
                new Vector3(1.42f, -1.05f, 0),
                transform.rotation);
        }

        if (sceneName == "Wohnzimmer3" && PlayerPrefs.GetInt("wz_4Check") == 1)
        {
            PlayerPrefs.SetInt("wz_4Check", 0);
            PlayerPrefs.SetInt("lampRepair", 1);

            var instance = Instantiate(itemPrefabs[WZ_4N],
                new Vector3(1.42f, -1.05f, 0),
                transform.rotation);
        }

        if (sceneName == "Wohnzimmer4" && PlayerPrefs.GetInt("wz_5Check") == 1)
        {
            PlayerPrefs.SetInt("wz_5Check", 0);
            PlayerPrefs.SetInt("schlüsselFreigabe", 1);

            var instance = Instantiate(itemPrefabs[WZ_5N],
                new Vector3(3.5593f, -0.1582f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[KatzeN],
                new Vector3(-3.29f, -3.01f, 0),
                transform.rotation);
        }

        if (sceneName == "Wohnzimmer1" && PlayerPrefs.GetInt("wz_6Check") == 1)
        {
            var instance = Instantiate(itemPrefabs[WZ_6N],
                new Vector3(2.2853f, -1.2053f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[OmaN],
                new Vector3(-3.3f, -2.4f, 0),
                transform.rotation);

            SoundManagerScript.PlaySound("Oma");
        }

        if (sceneName == "Wohnzimmer1" && PlayerPrefs.GetInt("wz_7Check") == 1)
        {
            PlayerPrefs.SetInt("wz_7Check", 0);
            PlayerPrefs.SetInt("ende", 1);

            SoundManagerScript.PlaySound("Stop");
            SoundManagerScript.PlaySound("WZ_7Sound");

            var instance = Instantiate(itemPrefabs[WZ_7N],
                new Vector3(2.69f, -0.7869f, 0),
                transform.rotation);

            var instance2 = Instantiate(itemPrefabs[OmaN],
                new Vector3(-3.3f, -2.4f, 0),
                transform.rotation);

            SoundManagerScript.PlaySound("Oma");
        }

        if (PlayerPrefs.GetInt("schlüsselFreigabe") == 1)
        {
            var instance = Instantiate(itemPrefabs[schlüsselItemN],
                new Vector3(2.48f, -2.85f, 0),
                transform.rotation);

            PlayerPrefs.SetInt("schlüsselFreigabe", 2);
        }
    }
}

