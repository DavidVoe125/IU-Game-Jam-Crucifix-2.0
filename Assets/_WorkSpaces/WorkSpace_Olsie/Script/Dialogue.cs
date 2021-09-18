using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

    //Varriable, welche den namen des NPCs beschreibt (falls n�tig)
    public string name;

    //dieMaximale und minimale l�nge der s�tze in der Textbox
    [TextArea (3, 10)]

    //beschreibt den String an s�tzen
    public string[] sentences;
}
