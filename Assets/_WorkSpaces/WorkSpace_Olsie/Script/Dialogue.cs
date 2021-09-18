using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

    //Varriable, welche den namen des NPCs beschreibt (falls nötig)
    public string name;

    //dieMaximale und minimale länge der sätze in der Textbox
    [TextArea (3, 10)]

    //beschreibt den String an sätzen
    public string[] sentences;
}
