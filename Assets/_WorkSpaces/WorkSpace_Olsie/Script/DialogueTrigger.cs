using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        //Der trigger called den Dialog Manager und started die "dialogue" varriable
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
