using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistancezweiteBox : MonoBehaviour
{
    public static PersistancezweiteBox Instance { get; private set; }

    public bool Value;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            print("lädt das Objekt");
            
        }
        else
        {
            Destroy(gameObject);
            print("zerstört das Objekt");
        }
    }
}
