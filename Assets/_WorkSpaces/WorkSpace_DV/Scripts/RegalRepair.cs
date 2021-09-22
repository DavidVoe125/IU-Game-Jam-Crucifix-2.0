using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegalRepair : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("regalRepair") == 1 || PlayerPrefs.GetInt("regalRepair") == 2 || PlayerPrefs.GetInt("regalRepair") == 3)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("regalRepair") == 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.name == "Schraube(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("RegalRepair") == 0)
        {
            print("Regal Repariert");

            spriteRenderer.sprite = sprites[1];

            PlayerPrefs.SetInt("regalRepair", 1);

            Destroy(col.gameObject);
            PlayerPrefs.SetInt("schraubeCheck", 3);

            PlayerPrefs.SetInt("wz_3Check", 1);

            SoundManagerScript.PlaySound("Schraube");
            SoundManagerScript.PlaySound("Buch");
            SoundManagerScript.PlaySound("Katzenschrei");
        }
    }
}
