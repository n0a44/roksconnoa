using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public GameObject continueButton;

    private Queue<string> sentences;

    private bool isTyping = false;
    private float typingSpeed = 0.05f; 
    private string currentSentence;

    void Start()
    {
        sentences = new Queue<string>();
        continueButton.SetActive(false);
        dialoguePanel.SetActive(false);
       
    }


    public void StartDialogue(Dialogue dialogue)
    {
        
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

        StopAllCoroutines();

        currentSentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(currentSentence));
    }
    private IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        isTyping = true; 

        foreach (char letter in sentence)
        {
            dialogueText.text += letter; 
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }
    public void ContinueDialogue()
    {
      
        if (isTyping)
        {
            StopAllCoroutines();
            dialogueText.text = currentSentence; 
            isTyping = false; 
        }
        else
        {
            DisplayNextSentence(); 
        }
    }

    private void EndDialogue()
    {
            
        dialoguePanel.SetActive(false);
        continueButton.SetActive(false);

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            DisplayNextSentence(); 
        }


    }
}