using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int CurrentFlags;

    public Text mapText;

    public RawImage yesImage;
    public RawImage noImage;

    
    

    // Static singleton property
    public static GameManager Instance { get; private set; }

    public void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
        yesImage.enabled = false;
        noImage.enabled = true;
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FlagsCollected(int flag) //collecting flags on the map
    {
        CurrentFlags += flag;
        // yes image enabled no image disabled
        yesImage.enabled = true;
        noImage.enabled = false;
    }

    public void EndOfTheLevel()
    {

    }
}
