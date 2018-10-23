using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Text textshowed = null;
    public void changeWord(string word)
    {
        textshowed.text = word;
    }
}
