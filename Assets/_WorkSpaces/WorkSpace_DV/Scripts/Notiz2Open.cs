using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notiz2Open : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Notiz2Open") == 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
