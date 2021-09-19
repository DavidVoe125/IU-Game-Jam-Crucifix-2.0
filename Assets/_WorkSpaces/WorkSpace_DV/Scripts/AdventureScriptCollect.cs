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
    private GameObject stinkesockeItem;
    private GameObject kaugummiItem;
    private GameObject eheringItem;
    private GameObject buchItem;
    private GameObject schlüsselItem;

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
                    PlayerPrefs.SetInt("baldrianCheck", 2);
                    print("Playerpref wurde erstellt");
                    print(PlayerPrefs.GetInt("baldrianCheck"));

                    baldrianItem = hit.collider.gameObject;
                    Destroy(baldrianItem);
                }
                else if (hit.collider.gameObject.name == "StinkesockeItem")
                {
                    PlayerPrefs.SetInt("stinkesockeCheck", 2);

                    stinkesockeItem = hit.collider.gameObject;
                    Destroy(stinkesockeItem);
                }
                else if (hit.collider.gameObject.name == "KaugummiItem")
                {
                    PlayerPrefs.SetInt("kaugummiCheck", 2);

                    kaugummiItem = hit.collider.gameObject;
                    Destroy(kaugummiItem);
                }
                else if (hit.collider.gameObject.name == "EheringItem")
                {
                    PlayerPrefs.SetInt("eheringCheck", 2);

                    eheringItem = hit.collider.gameObject;
                    Destroy(eheringItem);
                }
                else if (hit.collider.gameObject.name == "BuchItem")
                {
                    PlayerPrefs.SetInt("regalRepair", 4);
                    PlayerPrefs.SetInt("schlüsselFreigabe", 1);

                    buchItem = hit.collider.gameObject;
                    Destroy(buchItem);
                }
                else if (hit.collider.gameObject.name == "SchlüsselItem(Clone)")
                {
                    PlayerPrefs.SetInt("schlüsselCheck", 2);
                    PlayerPrefs.SetInt("schlüsselFreigabe", 2);

                    schlüsselItem = hit.collider.gameObject;
                    Destroy(schlüsselItem);
                }
                else if (hit.collider.gameObject.name == "SchraubeItem")
                {
                    PlayerPrefs.SetInt("schraubeCheck", 2);
                    
                    schlüsselItem = hit.collider.gameObject;
                    Destroy(schlüsselItem);
                }

            }
            else
            {
                print("Kein Collider erkannt");
            }
        }
    }
}
