using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class schlüsselTürUsed : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("schlüsselTürUsed") < 3)
        {
            if (PlayerPrefs.GetInt("schlüsselTürUsed") == 1)
            {
                spriteRenderer.sprite = sprites[1];
            }
            else if (PlayerPrefs.GetInt("schlüsselTürUsed") == 2)
            {
                spriteRenderer.sprite = sprites[2];
            }
            else if (PlayerPrefs.GetInt("schlüsselTürUsed") == 3)
            {
                // Sound

                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
