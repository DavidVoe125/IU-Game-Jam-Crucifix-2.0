using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KuckuckRepair : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("kuckucksuhrRepair") == 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.name == "Kuckuck(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0)
        {
            print("Kuckucksuhr repariert");

            PlayerPrefs.SetInt("kuckuckCheck", 0);
            PlayerPrefs.SetInt("kuckucksuhrRepair", 1);
            PlayerPrefs.SetInt("schlüsselTürCheck", 2);
            PlayerPrefs.SetInt("eh_3Check", 1);

            spriteRenderer.sprite = sprites[1];

            Destroy(col.gameObject);
        }
    }
}
