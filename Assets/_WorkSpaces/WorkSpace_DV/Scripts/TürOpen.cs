using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TürOpen : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;

        if (PlayerPrefs.GetInt("einArbTürOpen") == 1 && sceneName == "Eingangshalle1")
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (PlayerPrefs.GetInt("einArbTürOpen") == 1 && sceneName == "Arbeitszimmer3" && this.gameObject.name == "ArbEinTür")
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (PlayerPrefs.GetInt("einWohTürOpen") == 1 && sceneName == "Eingangshalle2")
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (PlayerPrefs.GetInt("einWohTürOpen") == 1 && sceneName == "Wohnzimmer4")
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (PlayerPrefs.GetInt("arbWohTürOpen") == 1 && sceneName == "Arbeitzimmer3" && this.gameObject.name == "ArbWohTür")
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (PlayerPrefs.GetInt("arbWohTürOpen") == 1 && sceneName == "Wohnzimmer1")
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
        if (col.name == "SchlüsselTür(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("einArbTürOpen") == 0 && sceneName == "Eingangshalle1")
        {
            PlayerPrefs.SetInt("einArbTürOpen", 1);
            PlayerPrefs.SetInt("schlüsselTürUsed", (PlayerPrefs.GetInt("schlüsselTürUsed") + 1));

            spriteRenderer.sprite = sprites[1];

            SoundManagerScript.PlaySound("Türsound");
        }
        else if (col.name == "SchlüsselTür(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("einArbTürOpen") == 0 && sceneName == "Arbeitszimmer3")
        {
            PlayerPrefs.SetInt("einArbTürOpen", 1);
            PlayerPrefs.SetInt("schlüsselTürUsed", (PlayerPrefs.GetInt("schlüsselTürUsed") + 1));

            spriteRenderer.sprite = sprites[1];

            SoundManagerScript.PlaySound("Türsound");
        }
        else if (col.name == "SchlüsselTür(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("einWohTürOpen") == 0 && sceneName == "Eingangshalle2")
        {
            PlayerPrefs.SetInt("einWohTürOpen", 1);
            PlayerPrefs.SetInt("schlüsselTürUsed", (PlayerPrefs.GetInt("schlüsselTürUsed") + 1));

            spriteRenderer.sprite = sprites[1];

            SoundManagerScript.PlaySound("Türsound");
        }
        else if (col.name == "SchlüsselTür(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("einWohTürOpen") == 0 && sceneName == "Wohnzimmer4")
        {
            PlayerPrefs.SetInt("einWohTürOpen", 1);
            PlayerPrefs.SetInt("schlüsselTürUsed", (PlayerPrefs.GetInt("schlüsselTürUsed") + 1));

            spriteRenderer.sprite = sprites[1];

            SoundManagerScript.PlaySound("Türsound");
        }
        else if (col.name == "SchlüsselTür(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("arbWohTürOpen") == 0 && sceneName == "Arbeitszimmer3")
        {
            PlayerPrefs.SetInt("arbWohTürOpen", 1);
            PlayerPrefs.SetInt("schlüsselTürUsed", (PlayerPrefs.GetInt("schlüsselTürUsed") + 1));

            spriteRenderer.sprite = sprites[1];

            SoundManagerScript.PlaySound("Türsound");
        }
        else if (col.name == "SchlüsselTür(Clone)" && PlayerPrefs.GetInt("isBeingHeld") == 0 && PlayerPrefs.GetInt("arbWohTürOpen") == 0 && sceneName == "Wohnzimmer1")
        {
            PlayerPrefs.SetInt("arbWohTürOpen", 1);
            PlayerPrefs.SetInt("schlüsselTürUsed", (PlayerPrefs.GetInt("schlüsselTürUsed") + 1));

            spriteRenderer.sprite = sprites[1];

            SoundManagerScript.PlaySound("Türsound");
        }
    }
}
