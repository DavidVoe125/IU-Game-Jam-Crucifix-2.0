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
    public GameObject bild; //5
    public int bildN = 5;

    public GameObject[] itemPrefabs;

    public int baldrianC;
    public float baldrianX;
    public float baldrianY;

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

        bildC = PlayerPrefs.GetInt("bildCheck");
        bildX = PlayerPrefs.GetFloat("bildXPos");
        bildY = PlayerPrefs.GetFloat("bildYPos");

        // Kamera wird automatisch in Scene gefunden under der Variable "background zugeordnet
        background = GameObject.Find("Main Camera").transform;

        // Transform Komponente wird als Variable gespeichert
        parentObj = GetComponent<Transform>();
        
        baldrianItem = GameObject.Find("BaldrianItem");

        if (sceneName == "Arbeitszimmer1" && baldrianC == 1)
        {
            Destroy(baldrianItem);
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

        if (bildC == 1)
        {
            var instance = Instantiate(itemPrefabs[bildN],
                new Vector3(bildX, bildY, 0),
                transform.rotation);
            instance.transform.parent = parentObj;
            bild = instance;
        }
        else
        {
            print("Baldrian existiert nicht");
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

        if (baldrianC == 1)
        {
            if (baldrian != null)
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

        bildC = PlayerPrefs.GetInt("bildCheck");
        bildX = PlayerPrefs.GetFloat("bildXPos");
        bildY = PlayerPrefs.GetFloat("bildYPos");

        if (baldrianC == 2)
        {
            // "baldrian"-Prefab wird an den Start-Koordinaten initiert
            var instance = Instantiate(itemPrefabs[1],
                new Vector3(0, 0, 0),
                transform.rotation);

            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;
            baldrian = instance;

            PlayerPrefs.SetInt("baldrianCheck", 1);
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

