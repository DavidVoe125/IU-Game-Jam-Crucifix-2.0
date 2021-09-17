using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private Rigidbody2D itemRb;
    public float itemGrav = 3;
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    private Vector2 mousePos;
    private Transform background;
    private float backgroundStart;
    private float backgroundUpdate;
    public float minY = -10;
    public float maxY = 10;
    public int itemCounter = 2;
    private SpriteRenderer itemRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Item-Rigitbody als Variable definieren
        itemRb = GetComponent<Rigidbody2D>();
        // itemGrav als Gravitation des Rigitbody definieren
        itemRb.gravityScale = itemGrav;
        // "Main Camera" finden und zuordnen
        background = GameObject.Find("Main Camera").transform;
        // Startpunkt der Cam beim Laden der Scene speichern
        backgroundStart = background.position.x;
        // Item-SpriteRenderer als Variable definieren
        itemRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Wenn die rechte Maustaste gehalten wird
        if (isBeingHeld == true)
        {
            // Maus-Position wird geholt
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            // Item-Position wird zu relativer MMaus-Position geupdatet
            this.gameObject.transform.localPosition = 
                new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);

            // Velocity wird auf 0 gehalten, bis Item losgelassen wird
            itemRb.velocity = Vector2.zero;
        }

        // Wenn die Kamera ihre Position in der x-Achse verändert
        if (backgroundStart != background.position.x)
        {
            // Veränderung der x-Achse der Kamera als Variable
            backgroundUpdate = backgroundStart - background.position.x;
            // Anpassung der Item-Position um die Veränderung der Kamera in x-Richtung
            transform.position = new Vector2(transform.position.x 
                                             - backgroundUpdate, transform.position.y);
            // backgroundStart wird mit der aktuellen Position der Kamera geupdated
            backgroundStart = background.position.x;
        }

        // Wenn Item under/gleich Wert A in Y-Richtung
        if (transform.position.y <= minY)
        {
            // Item-Position wird auf Wert A begrenzt und Velocity gleich 0 gesetzt
            transform.position = new Vector2(transform.position.x, minY);
            itemRb.velocity = Vector2.zero;

        }

        // Wenn Item über/gleich Wert B in Y-Richtung
        if (transform.position.y >= maxY)
        {
            // Item-Position wird auf Wert B begrenzt und Velocity gleich 0 gesetzt
            transform.position = new Vector2(transform.position.x, maxY);
            itemRb.velocity = Vector2.zero;
        }
    }

    void OnMouseDown()
    {
        // Überprüfen ob die rechte Maustaste gedrückt wird
        if (Input.GetMouseButtonDown(0))
        {
            // Maus-Position wird geholt
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            // Maus-Position in Relation zur Objektmitte wird festgehalten
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            // Anzeigen dass die rechte Maustaste gedrückt wird
            isBeingHeld = true;

            //TODO: Renderer Sortierung fertig machen

            SpriteRenderer[] renderers = FindObjectsOfType<SpriteRenderer>();
            foreach (SpriteRenderer renderer in renderers)
            {
                renderer.sortingOrder = renderer.sortingOrder - 1;
            }

            itemRenderer.sortingOrder = 100 + itemCounter;
        }
    }

    void OnMouseUp()
    {
        // Anzeigen dass die rechte Maustaste nicht mehr gedrückt wird
        if (Input.GetMouseButtonUp(0))
        { 
            isBeingHeld = false;
        }
    }
}
