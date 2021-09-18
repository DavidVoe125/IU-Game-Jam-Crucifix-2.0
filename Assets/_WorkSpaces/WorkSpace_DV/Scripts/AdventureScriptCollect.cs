using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdventureScriptCollect : MonoBehaviour
{
    public Vector3 mousePosition;
    public Vector3 mousePositionWorld;
    public Vector2 mousePositionWorld2D;
    public GameObject mainCameraObj;
    public Camera mainCamera;
    private RaycastHit2D hit;
    private GameObject baldrianItem;


    void Start()
    {
        mainCameraObj = GameObject.Find("Main Camera");
        mainCamera = mainCameraObj.GetComponent<Camera>();

        //(Camera) GameObject.FindObjectOfType(typeof(Camera))
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { //0=linke Taste
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
                print("Object mit Collider getroffen");

                print(hit.collider.gameObject.name);

                if (hit.collider.gameObject.name == "BaldrianItem")
                {
                    
                    // hit.collider.gameObject.SetActive(false);

                    PlayerPrefs.SetInt("baldrianCheck", 2);
                    print("Playerpref wurde erstellt");
                    print(PlayerPrefs.GetInt("baldrianCheck"));

                    baldrianItem = hit.collider.gameObject;
                    Destroy(baldrianItem);
                }

            }
            else
            {
                print("Kein Collider erkannt");
            }
        }
    }
}
