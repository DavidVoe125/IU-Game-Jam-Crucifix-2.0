using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("AdventureManager");
        if (go == null)
        {
            Debug.LogError("Failed to find an Adventuremanager");
            this.enabled = false;
            return;
        }
        AdventureScript gs = go.GetComponent<AdventureScript>();
    }
}
