using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class ItemSaveLoadSystem : MonoBehaviour
{
    private Transform background;

    private Transform parentObj;

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

        // Kamera wird automatisch in Scene gefunden under der Variable "background zugeordnet
        background = GameObject.Find("Main Camera").transform;

        // Transform Komponente wird als Variable gespeichert
        parentObj = GetComponent<Transform>();

        if (sceneName == "Arbeitszimmer1" && baldrianC == 1)
        {
            baldrianItem = GameObject.Find("BaldrianItem");
            Destroy(baldrianItem);
        }

        if (sceneName == "Arbeitszimmer2" && stinkesockeC == 1)
        {
            stinkesockeItem = GameObject.Find("StinkesockeItem");
            Destroy(stinkesockeItem);
        }

        if (sceneName == "Arbeitszimmer1" && kaugummiC == 1)
        {
            kaugummiItem = GameObject.Find("KaugummiItem");
            Destroy(kaugummiItem);
        }

        if (sceneName == "OpenBox" && eheringC == 1)
        {
            eheringItem = GameObject.Find("EheringItem");
            Destroy(eheringItem);
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

        if (bildC == 1)
        {
            var instance = Instantiate(itemPrefabs[bildN],
                new Vector3(bildX, bildY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            bild = instance;
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
                print(baldrian.transform.position.x - background.position.x);
                // X-Position von "baldrian" wird als PlayerPref gespeichert
                PlayerPrefs.SetFloat("baldrianXPos", baldrian.transform.position.x - background.position.x);
                // Y-Position von "baldrian" wird als PlayerPref gespeichert
                PlayerPrefs.SetFloat("baldrianYPos", baldrian.transform.position.y - background.position.y);
            }
        }

        if (stinkesockeC == 1)
        {
            if (stinkesocke != null)
            {
                PlayerPrefs.SetFloat("stinkesockeXPos", stinkesocke.transform.position.x - background.position.x);
                PlayerPrefs.SetFloat("stinkesockeYPos", stinkesocke.transform.position.y - background.position.y);
            }
        }

        if (kaugummiC == 1)
        {
            if (kaugummi != null)
            {
                PlayerPrefs.SetFloat("kaugummiXPos", kaugummi.transform.position.x - background.position.x);
                PlayerPrefs.SetFloat("kaugummiYPos", kaugummi.transform.position.y - background.position.y);
            }
        }

        if (eheringC == 1)
        {
            if (ehering != null)
            {
                PlayerPrefs.SetFloat("eheringXPos", ehering.transform.position.x - background.position.x);
                PlayerPrefs.SetFloat("eheringYPos", ehering.transform.position.y - background.position.y);
            }
        }

        if (bildC == 1)
        {
            if (bild != null)
            {
                PlayerPrefs.SetFloat("bildXPos", bild.transform.position.x - background.position.x);
                PlayerPrefs.SetFloat("bildYPos", bild.transform.position.y - background.position.y);
            }
        }
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

        if (baldrianC == 2)
        {
            // "baldrian"-Prefab wird an den Start-Koordinaten initiert
            var instance = Instantiate(itemPrefabs[baldrianN],
                new Vector3(0, 0, 0),
                transform.rotation);

            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;
            baldrian = instance;

            PlayerPrefs.SetInt("baldrianCheck", 1);
        }
        else if (stinkesockeC == 2)
        {
            var instance = Instantiate(itemPrefabs[stinkesockeN],
                new Vector3(0, 0, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            stinkesocke = instance;

            PlayerPrefs.SetInt("stinkesockeCheck", 1);
        }
        else if (kaugummiC == 2)
        {
            var instance = Instantiate(itemPrefabs[kaugummiN],
                new Vector3(1.367f, -1.53f, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            kaugummi = instance;

            PlayerPrefs.SetInt("kaugummiCheck", 1);
        }
        else if (eheringC == 2)
        {
            var instance = Instantiate(itemPrefabs[eheringN],
                new Vector3(0, 0, 0),
                transform.rotation);

            instance.transform.parent = parentObj;
            ehering = instance;

            PlayerPrefs.SetInt("eheringCheck", 1);
        }

        if (PlayerPrefs.GetInt("KellerItems") == 4)
        {
            // "Bild"-Prefab wird an den Start-Koordinaten initiert
            var instance = Instantiate(itemPrefabs[5],
                new Vector3(0, 0, 0),
                transform.rotation);

            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;
            bild = instance;

            PlayerPrefs.SetInt("bildCheck", 1);
            PlayerPrefs.SetInt("KellerItems", 5);
        }
    }
}

