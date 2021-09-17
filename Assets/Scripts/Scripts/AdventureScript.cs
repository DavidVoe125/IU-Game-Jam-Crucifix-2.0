using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdventureScript : MonoBehaviour
{
    public Vector3 mousePosition;
    public Vector3 mousePositionWorld;
    public Vector2 mousePositionWorld2D;
    public Camera mainCamera;
    RaycastHit2D hit;
    public GameObject player;

    private GameObject Box;
    public Vector2 targetPos;
    public float speed;
    public bool isMoving;
    public bool key;

    //Alle löschbaren Sprites:
    bool linkeBox;


    // Start is called before the first frame update
    void Start()
    {
        //Box is Active
        

    }

    // Update is called once per frame
    void Update()
    {
        setPlayerScale(player.transform.position.y);

        if (Input.GetMouseButtonDown(0))
        { //0=linke Taste
           // print("Maustaste wurde gedrückt");
            //Mausposition
            mousePosition=Input.mousePosition;

            //Koordinaten von Screenspace auf Worldspace umwandeln
            mousePositionWorld=mainCamera.ScreenToWorldPoint(mousePosition);

            //Screen Space ausgeben
            print("ScreenSpace:"+ mousePosition);

            //World Space ausgeben
            print("WorldSpace:" + mousePositionWorld);

            //Umwandlung Vector3 in Vector2
            mousePositionWorld2D = new Vector2(mousePositionWorld.x,mousePositionWorld.y);

            //Raycast für Ojekte
            hit = Physics2D.Raycast(mousePositionWorld2D, Vector2.zero);

            //Hat hit einen Collider?
            if (hit.collider != null)
            {
                print("Object mit Collider getroffen");

                print(hit.collider.gameObject.tag);

                //Ground?
                if (hit.collider.gameObject.tag == "Ground")
                {
                    //Position der Spielers verändern
                    //player.transform.position = hit.point;

                    targetPos = hit.point;

                    //is moving damit Spieler sich bewegt
                    isMoving = true;
                    //Überprüfe ob Spriteflip notwendig ist
                    CheckSpriteFlip();
                }
                
                else if (hit.collider.gameObject.tag == "Key")
                {
                    //=ist Schlüssel

                    //Schlüssel deaktivieren
                    hit.collider.gameObject.SetActive(false);
                    PlayerPrefs.SetFloat("Testfloat", 2.5f);
                    print("Playerpref wurde erstellt");
                    Box = hit.collider.gameObject;

                    //Schlüssel speichern
                    key = true;

                }
               
            }
            else
            {
                print("Kein Collider erkannt");
            }
        }
    }

    private void FixedUpdate()
    {

        //Überprüfe ob Spieler sich bewegt
        if (isMoving) {
            //Spieler an Zielort befördern
            player.transform.position = Vector3.MoveTowards(player.transform.position, targetPos, speed);

            //Spieler am Zielort?
            if ((player.transform.position.x == targetPos.x)&& (player.transform.position.y == targetPos.y))
            {
                isMoving = false;
            }
        }
    }

    void CheckSpriteFlip()
    {
        if (player.transform.position.x > targetPos.x)
        {
            //nach links
            player.GetComponent<SpriteRenderer>().flipX = false;
                }
        else
        {
            //nach rechts
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
    }


    private static AdventureScript _instance = null;
    public static AdventureScript instance
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


    //Spritegröße je nach ort auf dem Bild
    private void setPlayerScale(float y)
    {
        float playerscale = -0.023f * y + 0.034f;
        player.transform.localScale=new Vector3(playerscale,playerscale,0);
    }
}
