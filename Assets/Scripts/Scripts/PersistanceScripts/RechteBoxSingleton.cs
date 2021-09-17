using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechteBoxSingleton : MonoBehaviour
{
    private static RechteBoxSingleton _instance = null;
    public static RechteBoxSingleton instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            //DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
