using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private DialogueManager dialogueManager;

    void Start()
    {

        dialogueManager = FindObjectOfType<DialogueManager>();
    }


    private void OnMouseDown()
    {

        if (dialogueManager != null)
        {
            dialogueManager.StartDialogue(dialogue);
        }
        else
        {
            Debug.LogError("DialogueManager not found!");
        }
    }
}