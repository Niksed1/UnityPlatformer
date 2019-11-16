using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DialogueManager2 : MonoBehaviour
{

    public Text dialogueText;
    public Text nameText;
    //public Text continueText;

    //public Button continueButton;
    public GameObject button;

    //public GameObject yes;
   // public GameObject no;

    //public float Timer = 0.1f;

    public Queue<string> sentences;

    //replace singleton with static gameobjects
    public static DialogueManager2 Instance { get; private set; }

    public void Awake()
    {
        Instance = this;
        //continueButton.enabled = false;
        //continueText.enabled = false;
        button.SetActive(false);
        nameText.enabled = false;
        dialogueText.enabled = false;
       // yes.SetActive(false);
       // no.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartDialogue(Dialogue2 dialogue) //make it follow the begin button
    {
        //Debug.Log(dialogue.Name);
        nameText.text = dialogue.Name;
        nameText.enabled = true;
		dialogueText.enabled = true;
		if(sentences == null) {
			sentences = new Queue<string>();
		}
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence); //enter the queue
        }

        //continueButton.enabled = true;
        //continueText.enabled = true;
        button.SetActive(true);
        NextSentence();
    }

    public void NextSentence()
    {
        //if parsed through all sentences
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue(); //exit the queue when done
        dialogueText.text = sentence;
        //Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char let in sentence.ToCharArray())
        {
            dialogueText.text += let;
            yield return null;
        }
    }

    //ending the dialogue
    public void EndDialogue()
    {
       // yes.SetActive(true);
        // no.SetActive(true);


        Debug.Log("The End of the dialogue");
        SceneManager.LoadScene(4);
    }

    public static void LoadNextScene(int s)
    {
        SceneManager.LoadScene(s);
    }
}
