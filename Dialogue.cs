using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
//not a mono behavior, does not require update/start functions
public class Dialogue {

    [TextArea(2, 6)]
    public string[] sentences;
    

    public string Name;

}
