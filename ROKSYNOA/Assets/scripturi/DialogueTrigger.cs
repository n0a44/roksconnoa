using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
    public GameObject task1;
    public Dialogue dialogue;
    private DialogueManager dialogueManager;

    void Start()
    {
        task1.SetActive(true);
        dialogueManager = FindObjectOfType<DialogueManager>();
    }


    private void OnMouseDown()
    {

        if (dialogueManager != null)
        {
            dialogueManager.StartDialogue(dialogue);
            task1.SetActive(false);
        }
        else
        {
            Debug.LogError("DialogueManager not found!");
        }
    }

}