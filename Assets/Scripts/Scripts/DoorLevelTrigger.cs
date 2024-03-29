using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLevelTrigger : MonoBehaviour
{
    private Vector3 mousePosition;
    public Vector3 mousePositionWorld;
    public Vector2 mousePositionWorld2D;
    public GameObject CameraObj;
    public Camera mainCamera;
    public string nextLevel;
    RaycastHit2D hit;
    private string sceneName;

    private string lastSceneName;
    // Start is called before the first frame update
    void Start()
    {
        CameraObj = GameObject.Find("Main Camera");
        mainCamera = CameraObj.GetComponent<Camera>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { //0=linke Taste
            print("Maustaste wurde gedr�ckt");
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

            //Raycast f�r Ojekte
            hit = Physics2D.Raycast(mousePositionWorld2D, Vector2.zero);

            //Hat hit einen Collider?
            if (hit.collider.gameObject.tag == "Door" && sceneName == "Settings")
            {
                lastSceneName = PlayerPrefs.GetString("lastSceneName", "MainMenu");
                SceneManager.LoadScene(lastSceneName);
            }
            else if (hit.collider.gameObject.tag == "Door" && sceneName != "Settings")
            { 
                //=ist T�r
                //print("loadnextlvl");
                    
                SceneManager.LoadScene(nextLevel);
                    
                print(nextLevel);
            }
            
            else
            {
                print("Kein Collider erkannt");
            }
        }
    }
}
