using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Die Queue lässt die sätze in der vorgegebenen reihenfolge abspielen
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue conversation)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = conversation.name;

        //cleared den letzten dialog aus der Queue (falls vorhanden)
        sentences.Clear();

        //sucht sich alle sentences welche dem script zugefügt wurden
        foreach (string sentence in conversation.sentences)
        {

            //Queued die eben gesuchten sentences
            sentences.Enqueue(sentence);
        }
        //spielt die funktion NextSentence ab
        NextSentence();
    }

    public void NextSentence()
    {
        //wenn keine sentences im dialog sind, beende den dialog
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        //nimmt den nun gezeigten satz aus der Queue
        string sentence = sentences.Dequeue();

        //displayed den eben entnommenen sentence
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("Conversation Endet");
    }
}
