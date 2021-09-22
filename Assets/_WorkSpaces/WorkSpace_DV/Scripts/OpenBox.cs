using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.name == "Schlüssel(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("boxOpen") == 0)
        {
            print("Box geöffnet");

            PlayerPrefs.SetInt("boxOpen", 1);
            PlayerPrefs.SetInt("eheringCheck", 2);
        }
    }
}
