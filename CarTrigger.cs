using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarTrigger : MonoBehaviour {

    public PlayerMovement player;
    private bool isCollision;

    public Text sitText;

    // Use this for initialization
    void Start () {

        //player = FindObjectOfType<PlayerMovement>();
        sitText.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        //Load Next scene
        if (isCollision && Input.GetKey(KeyCode.F))
        {
            if(FinalDecision.Good > FinalDecision.Bad)
            SceneManager.LoadScene(2);
            else
            {
                SceneManager.LoadScene(3);
            }

        }
    }

    string pressF = "Press  F  to sit ";
    //make it temporary
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") //&& GameManager.Instance.CurrentFlags > 0  ) //check if the player has got the flag
        {

            FindObjectOfType<EndOfTheLevel>().congratzText.enabled = false;
            //pull out the dialog window 
            sitText.enabled = true;

            StopAllCoroutines();
            StartCoroutine(TypeSentence(pressF));
            // enable is collision to be able to change the scene when needed
            isCollision = true;

            

        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        sitText.text = "";
        foreach (char let in sentence.ToCharArray())
        {
            sitText.text += let;
            yield return null;
        }
    }

}
