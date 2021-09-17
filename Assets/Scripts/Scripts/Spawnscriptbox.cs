using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscriptbox : MonoBehaviour
{
    public GameObject playerprefs;
    //public GameObject Background;
    // Start is called before the first frame update
    void Start()
    {
        print("level gestartet");
        
       
        if (PlayerPrefs.GetFloat("Testfloat") == 2.5)
        {
            print("Wert ist bei 2.5");
            Destroy(this.gameObject);
            print("Box wurde zerstört");

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("Testfloat") == 2.5)
        {
                     
        }
    }
}
