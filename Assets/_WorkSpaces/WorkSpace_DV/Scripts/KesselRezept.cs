using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KesselRezept : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (PlayerPrefs.GetInt("KesselItems") == 1)
        {
            spriteRenderer.sprite = sprites[1];

            PlayerPrefs.SetInt("KesselItems", 1);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 2)
        {
            spriteRenderer.sprite = sprites[2];

            PlayerPrefs.SetInt("KesselItems", 2);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 3)
        {
            spriteRenderer.sprite = sprites[3];

            PlayerPrefs.SetInt("KesselItems", 3);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 5)
        {
            spriteRenderer.sprite = sprites[4];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.name == "Baldrian(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 &&
            PlayerPrefs.GetInt("KesselItems") == 0)
        {
            print("+ Baldrian");

            spriteRenderer.sprite = sprites[1];

            PlayerPrefs.SetInt("KesselItems", 1);

            Destroy(col.gameObject);
            PlayerPrefs.SetInt("baldrianCheck", 3);
        }
        else if (col.name == "Stinkesocke(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 &&
                 PlayerPrefs.GetInt("KesselItems") == 1)
        {
            print("+ Stinkesocke");

            spriteRenderer.sprite = sprites[2];

            PlayerPrefs.SetInt("KesselItems", 2);

            Destroy(col.gameObject);
            PlayerPrefs.SetInt("stinkesockeCheck", 3);
        }
        else if (col.name == "Kaugummi(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 &&
                 PlayerPrefs.GetInt("KesselItems") == 2)
        {
            print("+ Kaugummi");

            spriteRenderer.sprite = sprites[3];

            PlayerPrefs.SetInt("KesselItems", 3);
            Destroy(col.gameObject);
            PlayerPrefs.SetInt("kaugummiCheck", 3);
        }
        else if (col.name == "Ehering(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 &&
                 PlayerPrefs.GetInt("KesselItems") == 3)
        {
            print("+ Ehering");

            spriteRenderer.sprite = sprites[4];

            PlayerPrefs.SetInt("KesselItems", 4);
            Destroy(col.gameObject);
            PlayerPrefs.SetInt("eheringCheck", 3);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 5)
        {
            print("Hier gibt es nichts mehr zu tun.");
        }
        else
        {
            print("Das gehört hier nicht hin.");
        }
    }
}
