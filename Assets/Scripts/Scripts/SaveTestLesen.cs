using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTestLesen : MonoBehaviour
{
    public float wert;

    // Start is called before the first frame update
    void Start()
    {
        wert = PlayerPrefs.GetFloat("Testfloat");
        print("Wert wurde beschrieben");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            
            PlayerPrefs.DeleteAll();
            print("Wert wurde gelöscht");

        }

    }
}
