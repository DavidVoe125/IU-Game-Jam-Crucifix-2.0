using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantManagerUwuBox : MonoBehaviour
{

    public static PersistantManagerUwuBox Instance { get; private set; }

    public bool Value;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
