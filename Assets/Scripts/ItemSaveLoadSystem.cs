using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class ItemSaveLoadSystem : MonoBehaviour
{
    private Transform background;

    private Transform parentObj; 
    
    public GameObject[] itemPrefabs;
    
    private GameObject apple; //0

    private const string appleCKey = "AppleCheck";
    private const string appleXKey = "AppleXPos";
    private const string appleYKey = "AppleYPos";

    public int appleC = PlayerPrefs.GetInt(appleCKey);
    public float appleX = PlayerPrefs.GetInt(appleXKey);
    public float appleY = PlayerPrefs.GetInt(appleYKey);

    // Start is called before the first frame update
    void Start()
    {
        // Kamera wird automatisch in Scene gefunden under der Variable "background zugeordnet
        background = GameObject.Find("Main Camera").transform;

        // Transform Komponente wird als Variable gespeichert
        parentObj = GetComponent<Transform>();

        // Wenn "appleC" aussagt, dass "apple" existiert
        if (appleC == 1)
        {
            // "apple"-Prefab wird an den Koordinaten "appleX" und "appleY" initiert
            var instance = Instantiate(itemPrefabs[0], 
                new Vector3(appleX, appleY, 0), 
                transform.rotation);
            // "apple"-Objekt wird "Inventory"-Objekt untergeordnet
            instance.transform.parent = parentObj;
        }
        // Wenn "appleC" aussagt, dass "apple" nicht existiert
        else
        {
            // Nur zum Test!
            var instance = Instantiate(itemPrefabs[0], Vector3.zero,
                transform.rotation);
            instance.transform.parent = parentObj;
        }
    }

    void OnDestroy()
    {
        // Wenn "appleC" aussagt, dass "apple" existiert
        if (appleC == 1)
        {
            // Item "Apfel" wird in der Scene gesucht und als "apple"-Variable gespeichert
            apple = GameObject.Find("Apfel");
            //Wenn "apple"-Variable nicht leer ist
            if (apple != null)
            {
                // X-Position von "apple" wird als PlayerPref gespeichert
                PlayerPrefs.SetFloat(appleXKey, apple.transform.position.x - background.position.x);
                // Y-Position von "apple" wird als PlayerPref gespeichert
                PlayerPrefs.SetFloat(appleYKey, apple.transform.position.y - background.position.y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
