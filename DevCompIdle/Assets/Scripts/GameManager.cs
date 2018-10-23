using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text cashText;

    public float cash = 0;
    public float cashPerClick = 1;
    public float cashPerSecond = 0;

    public int hours = 0;
    public int days = 0;


    

	// Use this for initialization
	void Start () {
 

	}
	
	// Update is called once per frame
	void Update () {
        cashText.text = "Cash: " + cash;

	}

    private void TimeAdd()
    {
        hours += 1;
        if(hours >= 24)
        {
            cash += 1;
            hours = 0;
        }
    }

    IEnumerator time()
    {
        while(true)
        {
            TimeAdd();
            yield return new WaitForSeconds(1);
        }
    }
}
