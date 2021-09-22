using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiegel : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (PlayerPrefs.GetInt("vorhangOpen") == 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("vorhangOpen") == 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }
}
