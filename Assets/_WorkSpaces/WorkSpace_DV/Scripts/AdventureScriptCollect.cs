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
                else if (hit.collider.gameObject.name == "BuchItem(Clone)")
                {
                    PlayerPrefs.SetInt("regalRepair", 3);
                    PlayerPrefs.SetInt("wz_4Check", 1);
                    PlayerPrefs.SetInt("katzeJammern", 0);
                    SoundManagerScript.PlaySound("Katzenschnurren");

                    buchItem = hit.collider.gameObject;
                    Destroy(buchItem);
                }
                else if (hit.collider.gameObject.name == "SchlüsselItem(Clone)")
                {
                    PlayerPrefs.SetInt("schlüsselCheck", 2);
                    PlayerPrefs.SetInt("schlüsselFreigabe", 0);

                    schlüsselItem = hit.collider.gameObject;
                    Destroy(schlüsselItem);
                }
                else if (hit.collider.gameObject.name == "SchraubeItem")
                {
                    PlayerPrefs.SetInt("schraubeCheck", 2);
                    
                    schlüsselItem = hit.collider.gameObject;
                    Destroy(schlüsselItem);
                }
                else if (hit.collider.gameObject.name == "Standuhr" && PlayerPrefs.GetInt("StanduhrRätsel") == 0)
                {
                    SceneManager.LoadScene("Clock");
                }
                else if (hit.collider.gameObject.name == "Wohnzimmer2" && PlayerPrefs.GetInt("WohnzimmerOpen") == 1)
                {
                    SceneManager.LoadScene("Wohnzimmer2");
                }
                else if (hit.collider.gameObject.name == "Kleiderständer")
                {
                    SceneManager.LoadScene("Postkarte");
                }
                else if (hit.collider.gameObject.name == "Notiz3" && PlayerPrefs.GetInt("eh_2Check") == 0)
                {
                    PlayerPrefs.SetInt("eh_2Check", 1);
                    SceneManager.LoadScene("Notiz3");
                }
                else if (hit.collider.gameObject.name == "Notiz3" && PlayerPrefs.GetInt("eh_2Check") == 2)
                {
                    SceneManager.LoadScene("Notiz3");
                }
                else if (hit.collider.gameObject.name == "EinArbTür" && PlayerPrefs.GetInt("einArbTürOpen") == 1)
                {
                    SceneManager.LoadScene("Arbeitszimmer1");
                }
                else if (hit.collider.gameObject.name == "ArbEinTür" && PlayerPrefs.GetInt("einArbTürOpen") == 1)
                {
                    SceneManager.LoadScene("Eingangshalle3");
                }
                else if (hit.collider.gameObject.name == "EinWohTür" && PlayerPrefs.GetInt("einWohTürOpen") == 1)
                {
                    SceneManager.LoadScene("Wohnzimmer2");
                }
                else if (hit.collider.gameObject.name == "WohEinTür" && PlayerPrefs.GetInt("einWohTürOpen") == 1)
                {
                    SceneManager.LoadScene("Eingangshalle4");
                }
                else if (hit.collider.gameObject.name == "ArbWohTür" && PlayerPrefs.GetInt("arbWohTürOpen") == 1)
                {
                    SceneManager.LoadScene("Wohnzimmer3");
                }
                else if (hit.collider.gameObject.name == "WohArbTür" && PlayerPrefs.GetInt("arbWohTürOpen") == 1)
                {
                    SceneManager.LoadScene("Arbeitszimmer1");
                }
                else if (hit.collider.gameObject.name == "EH_1(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("Junge(Clone)"));
                    Destroy(GameObject.Find("Maedchen(Clone)"));
                }
                else if (hit.collider.gameObject.name == "EH_2(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("JungeF(Clone)"));
                    Destroy(GameObject.Find("MaedchenF(Clone)"));
                }
                else if (hit.collider.gameObject.name == "EH_3(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("JungeF(Clone)"));
                    Destroy(GameObject.Find("MaedchenF(Clone)"));
                }
                else if (hit.collider.gameObject.name == "WZ_1(Clone)")
                {
                    PlayerPrefs.SetInt("wz_1Check", 1);
                    PlayerPrefs.SetInt("wz_2Check", 1);

                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("Oma(Clone)"));
                }
                else if (hit.collider.gameObject.name == "WZ_2(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("Oma(Clone)"));
                }
                else if (hit.collider.gameObject.name == "WZ_3(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider.gameObject.name == "WZ_4(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider.gameObject.name == "Lampe" && PlayerPrefs.GetInt("lampRepair") == 1)
                {
                    PlayerPrefs.SetInt("lampRepair", 2);
                    PlayerPrefs.SetInt("wz_5Check", 1);

                    SoundManagerScript.PlaySound("Stop");
                    SoundManagerScript.PlaySound("Wohnzimmer");

                    Destroy(hit.collider.gameObject.GetComponent<Animator>());
                }
                else if (hit.collider.gameObject.name == "WZ_5(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("KatzeIdle(Clone)"));
                }
                else if (hit.collider.gameObject.name == "Spiegel" && PlayerPrefs.GetInt("vorhangFreigabe") == 0 && PlayerPrefs.GetInt("wz_6Check") == 0)
                {
                    PlayerPrefs.SetInt("wz_6Check", 1);
                }
                else if (hit.collider.gameObject.name == "WZ_6(Clone)")
                {
                    PlayerPrefs.SetInt("wz_6Check", 0);

                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("Oma(Clone)"));
                }
                else if (hit.collider.gameObject.name == "Notiz")
                {
                    SceneManager.LoadScene("Notiz");
                }
                else if (hit.collider.gameObject.name == "Spiegel" && PlayerPrefs.GetInt("vorhangFreigabe") == 1 && PlayerPrefs.GetInt("ende") == 0)
                {
                    PlayerPrefs.SetInt("wz_7Check", 1);
                    PlayerPrefs.SetInt("vorhangOpen", 1);
                }
                else if (hit.collider.gameObject.name == "WZ_7(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(GameObject.Find("Oma(Clone)"));
                }
                else if (hit.collider.gameObject.name == "Spiegel" && PlayerPrefs.GetInt("vorhangFreigabe") == 1 && PlayerPrefs.GetInt("ende") == 1)
                {
                    SceneManager.LoadScene("Outro");
                }
            }
            else
            {
                print("Kein Collider erkannt");
            }
        }
    }
}
