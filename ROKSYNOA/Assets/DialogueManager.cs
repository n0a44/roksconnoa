using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public GameObject panel;
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public GameObject continueButton;

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
        continueButton.SetActive(false);
        panel.SetActive(false);
    }


    public void StartDialogue(Dialogue dialogue)
    {
        panel.SetActive(true);
        dialoguePanel.SetActive(true);
        continueButton.SetActive(true);

        sentences.Clear();


        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }


    private void EndDialogue()
    {
        panel.SetActive(false);
        dialoguePanel.SetActive(false);
        continueButton.SetActive(false);
    }
}
