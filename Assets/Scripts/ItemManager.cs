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
    private float minY = -4.8f;
    private float minX = -9f;
    private float maxX;
    public int itemCounter = 2;
    private SpriteRenderer itemRenderer;

    // Start is called before the first frame update
    void Start()
    {
        maxX = -minX;
        // Item-Rigitbody als Variable definieren
        itemRb = GetComponent<Rigidbody2D>();
        // itemGrav als Gravitation des Rigitbody definieren
        itemRb.gravityScale = itemGrav;
        // Item-SpriteRenderer als Variable definieren
        itemRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Wenn die rechte Maustaste gehalten wird
        if (isBeingHeld == true)
        {
            PlayerPrefs.SetInt("isBeingHeld", 1);

            // Maus-Position wird geholt
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            // Item-Position wird zu relativer Maus-Position geupdatet
                this.gameObject.transform.localPosition = 
                new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);

            // Velocity wird auf 0 gehalten, bis Item losgelassen wird
            itemRb.velocity = Vector2.zero;
        }

        // Wenn Item under/gleich Wert A in Y-Richtung
        if (transform.position.y <= minY)
        {
            // Item-Position wird auf Wert A begrenzt und Velocity und Gravity Scale gleich 0 gesetzt
            transform.position = new Vector2(transform.position.x, minY);
            itemRb.velocity = Vector2.zero;
            itemRb.gravityScale = 0;
        }
       
        // Wenn Item under/gleich Wert B in X-Richtung
        if (transform.position.x <= minX)
        {
            // Item-Position wird auf Wert B begrenzt
            transform.position = new Vector2(minX, transform.position.y);
        }

        // Wenn Item under/gleich Wert B in X-Richtung
        if (transform.position.x >= maxX)
        {
            // Item-Position wird auf Wert B begrenzt
            transform.position = new Vector2(maxX, transform.position.y);
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

            //SpriteRenderer[] renderers = FindObjectsOfType<SpriteRenderer>();
            //foreach (SpriteRenderer renderer in renderers)
            //{
            //    renderer.sortingOrder = renderer.sortingOrder - 1;
            //}

            itemRenderer.sortingOrder = 10;
        }
    }

    void OnMouseUp()
    {
        // Anzeigen dass die rechte Maustaste nicht mehr gedrückt wird
        if (Input.GetMouseButtonUp(0))
        { 
            isBeingHeld = false;

            PlayerPrefs.SetInt("isBeingHeld", 0);

            // Gravity Scale wird zurückgesetzt
            itemRb.gravityScale = itemGrav;
        }
    }
}
