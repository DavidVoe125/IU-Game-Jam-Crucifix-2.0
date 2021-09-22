using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private float timer;
    public int roundedTimer;
    private int sceneNum;
    public GameObject Intro2;
    public GameObject Intro3;
    public GameObject Intro4;

    void Start()
    {
        SoundManagerScript.PlaySound("Intro");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        roundedTimer = (int) Math.Round(timer);

        if (roundedTimer == 18 && timer < 18 && sceneNum == 0)
        {
            var instance = Instantiate(Intro2,
                new Vector3(0, 0, 0),
                transform.rotation);
            
            sceneNum = 1;
        }
        else if (roundedTimer == 30 && timer < 30 && sceneNum == 1)
        {
            var instance = Instantiate(Intro3,
                new Vector3(0, 0, 0),
                transform.rotation);

            sceneNum = 2;
        }
        else if (roundedTimer == 38 && timer < 38 && sceneNum == 2)
        {
            var instance = Instantiate(Intro4,
                new Vector3(0, 0, 0),
                transform.rotation);

            sceneNum = 3;
        }
        else if (sceneNum == 3 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Eingangshalle1");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Eingangshalle1");
        }
    }
}
