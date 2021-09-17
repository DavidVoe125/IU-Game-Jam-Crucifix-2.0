using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkeBox : MonoBehaviour
{
    private static LinkeBox _instance = null;
    public static LinkeBox instance
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
