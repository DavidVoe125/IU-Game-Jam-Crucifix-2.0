using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampRepair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("lampRepair") == 2)
        {
            Destroy(this.gameObject.GetComponent<Animator>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
