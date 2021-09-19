using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenBox : MonoBehaviour
{
    public GameObject ButtonOpenBox;
    private Transform parentObj;

    // Start is called before the first frame update
    void Start()
    {
        // Transform Komponente wird als Variable gespeichert
        parentObj = GetComponent<Transform>();

        if (PlayerPrefs.GetInt("boxOpen") == 1)
        {
            var instance = Instantiate(ButtonOpenBox,
                new Vector3(transform.position.x, transform.position.y, 0),
                transform.rotation);
            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.name == "Schlüssel" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("boxOpen") == 0)
        {
            print("Box geöffnet");
            
            var instance = Instantiate(ButtonOpenBox,
                new Vector3(transform.position.x, transform.position.y, 0),
                transform.rotation);
            // "baldrian" - Objekt wird "Inventory" - Objekt untergeordnet
            instance.transform.parent = parentObj;

            PlayerPrefs.SetInt("boxOpen", 1);
        }
    }
}
