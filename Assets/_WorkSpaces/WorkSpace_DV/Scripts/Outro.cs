using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outro : MonoBehaviour
{
    public Vector3 mousePosition;
    public Vector3 mousePositionWorld;
    public Vector2 mousePositionWorld2D;
    public GameObject mainCameraObj;
    public Camera mainCamera;
    private RaycastHit2D hit;
    private float timer;
    public int roundedTimer;
    private int sceneNum;
    public GameObject Endscene2;
    public GameObject Endscene3;
    public GameObject Endscene4;
    public GameObject Endscene5;
    public GameObject Endscene6;
    public GameObject Outro1;
    public GameObject Outro2;
    public GameObject Outro3;

    void Start()
    {
        mainCameraObj = GameObject.Find("Main Camera");
        mainCamera = mainCameraObj.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //0=linke Taste
            // print("Maustaste wurde gedrückt");
            //Mausposition
            mousePosition = Input.mousePosition;

            //Koordinaten von Screenspace auf Worldspace umwandeln
            mousePositionWorld = mainCamera.ScreenToWorldPoint(mousePosition);

            //Screen Space ausgeben
            print("ScreenSpace:" + mousePosition);

            //World Space ausgeben
            print("WorldSpace:" + mousePositionWorld);

            //Umwandlung Vector3 in Vector2
            mousePositionWorld2D = new Vector2(mousePositionWorld.x, mousePositionWorld.y);

            //Raycast für Ojekte
            hit = Physics2D.Raycast(mousePositionWorld2D, Vector2.zero);

            //Hat hit einen Collider?
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Endscene1")
                {
                    Destroy(hit.collider.gameObject);

                    var instance = Instantiate(Endscene2,
                        new Vector3(0, -0, 0),
                        transform.rotation);
                }
                else if (hit.collider.gameObject.name == "Endscene2(Clone)")
                {
                    Destroy(hit.collider.gameObject);

                    var instance = Instantiate(Endscene3,
                        new Vector3(0, -0, 0),
                        transform.rotation);

                    SoundManagerBackgroundScript.PlaySound("Endscene34");
                }
                else if (hit.collider.gameObject.name == "Endscene3(Clone)")
                {
                    Destroy(hit.collider.gameObject);

                    var instance = Instantiate(Endscene4,
                        new Vector3(0, -0, 0),
                        transform.rotation);
                }
                else if (hit.collider.gameObject.name == "Endscene4(Clone)")
                {
                    Destroy(hit.collider.gameObject);

                    var instance = Instantiate(Endscene5,
                        new Vector3(0, -0, 0),
                        transform.rotation);

                    SoundManagerBackgroundScript.PlaySound("Endscene56");
                }
                else if (hit.collider.gameObject.name == "Endscene5(Clone)")
                {
                    Destroy(hit.collider.gameObject);

                    var instance = Instantiate(Endscene6,
                        new Vector3(0, -0, 0),
                        transform.rotation);
                }
                else if (hit.collider.gameObject.name == "Endscene6(Clone)" && PlayerPrefs.GetInt("startOutro") == 0)
                {
                    Destroy(hit.collider.gameObject);

                    PlayerPrefs.SetInt("startOutro", 1);
                    var instance = Instantiate(Outro1,
                        new Vector3(0, 0, 0),
                        transform.rotation);

                    SoundManagerBackgroundScript.PlaySound("Outro");
                }
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && PlayerPrefs.GetInt("startOutro") == 0)
        { 
            PlayerPrefs.SetInt("startOutro", 1);
            var instance = Instantiate(Outro1, 
                new Vector3(0, 0, 0),
                transform.rotation);

            SoundManagerBackgroundScript.PlaySound("Outro");
        }

        if (PlayerPrefs.GetInt("instanceOutro") == 1)
        {
            PlayerPrefs.SetInt("instanceOutro", 0);

            var instance = Instantiate(Outro1,
                new Vector3(0, 0, 0),
                transform.rotation);
        }

        if (PlayerPrefs.GetInt("startOutro") == 1)
        { 
            timer += Time.deltaTime;
            roundedTimer = (int)Math.Round(timer);

            if (roundedTimer == 18 && timer < 18 && sceneNum == 0)
            {
                var instance = Instantiate(Outro2,
                    new Vector3(0, 0, 0),
                    transform.rotation);

                sceneNum = 1;
            }
            else if (roundedTimer == 32 && timer < 32 && sceneNum == 1)
            {
                var instance = Instantiate(Outro3,
                    new Vector3(0, 0, 0),
                    transform.rotation);

                sceneNum = 2;
            }
            else if (sceneNum == 2 && Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Credits");
                PlayerPrefs.DeleteAll();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Credits");
                PlayerPrefs.DeleteAll();
            }
        }
    }
}
