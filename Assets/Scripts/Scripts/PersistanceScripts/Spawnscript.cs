using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscript : MonoBehaviour
{
    public bool isSpawnable = true;
    // Start is called before the first frame update
    void Start()
    {
        if (!isSpawnable)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
