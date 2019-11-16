using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanAnimation : MonoBehaviour {

    public Animator playerAnimation;

    private float inputH;
    private float inputV;

    // Use this for initialization
    void Start ()
    {
        playerAnimation = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update ()
    {

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        playerAnimation.SetFloat("inputH", inputH);
        playerAnimation.SetFloat("inputV", inputV);
    }

    
}
