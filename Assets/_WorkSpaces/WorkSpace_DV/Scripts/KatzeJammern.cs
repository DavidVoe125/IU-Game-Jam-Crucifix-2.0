using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatzeJammern : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (PlayerPrefs.GetInt("katzeJammern") == 1)
        {
            anim.SetBool("isSchreck", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("katzeJammern") == 0)
        {
            anim.SetBool("isSchreck", false);
        }
        else if (PlayerPrefs.GetInt("katzeJammern") == 1)
        {
            anim.SetBool("isSchreck", true);
        }
    }
}
