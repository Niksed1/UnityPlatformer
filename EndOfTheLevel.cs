using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfTheLevel : MonoBehaviour {

    public Text congratzText;

    public float timer;
	// Use this for initialization
	void Start () {
        timer = 5f;
        congratzText.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    string congratz = "Congratz.U done.";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameManager.Instance.CurrentFlags > 0) //check if the player has got the flag
        {

            //pull out the dialog window 
            congratzText.enabled = true; //use of singletons
            /*timer -= Time.deltaTime;
            if (timer<0)
            {
                GameManager.Instance.congratzText.enabled = false;
            } */
            StopAllCoroutines();
            StartCoroutine(TypeSentence(congratz));
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        congratzText.text = "";
        foreach (char let in sentence.ToCharArray())
        {
            congratzText.text+= let;
            yield return null;
        }
    }
}
