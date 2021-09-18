using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KesselRezept : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();

        if (PlayerPrefs.GetInt("KesselItems") == 1)
        {
            renderer.sprite = sprites[1];

            PlayerPrefs.SetInt("KesselItems", 1);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 2)
        {
            renderer.sprite = sprites[2];

            PlayerPrefs.SetInt("KesselItems", 2);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 3)
        {
            renderer.sprite = sprites[3];

            PlayerPrefs.SetInt("KesselItems", 3);
        }
        else if (PlayerPrefs.GetInt("KesselItems") == 5)
        {
            renderer.sprite = sprites[4];
        }
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerStay2D(Collider2D col)
        {
            if (col.name == "Baldrian" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("KesselItems") == 0)
            {
                print("+ Baldrian");

                renderer.sprite = sprites[1];

                PlayerPrefs.SetInt("KesselItems", 1);
            }
            else if (col.name == "Stinkesocke" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("KesselItems") == 1)
            {
                print("+ Stinkesocke");

                renderer.sprite = sprites[2];

                PlayerPrefs.SetInt("KesselItems", 2);
            }
            else if (col.name == "Kaugummi" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("KesselItems") == 2)
            {
                print("+ Kaugummi");

                renderer.sprite = sprites[3];

                PlayerPrefs.SetInt("KesselItems", 3);
            }
            else if (col.name == "Ehering" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("KesselItems") == 3)
            {
                print("+ Ehering");

                renderer.sprite = sprites[4];

                PlayerPrefs.SetInt("KesselItems", 4);
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
