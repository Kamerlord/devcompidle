using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public Text cashText;

    public float cash = 0;
    public float cashPerClick = 1;
    public float cashPerSecond = 0;

    public float worker1Level = 0;
    public bool worker1TimerOn = false;




    

	// Use this for initialization
	void Start () {

        //Screen stays always on, never go to sleep while game is on
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

	}
	
	// Update is called once per frame
	void Update () {
        cashText.text = "Cash: " + cash;

        if(worker1Level >= 1 && worker1TimerOn == false)
        {
            StartCoroutine(time());
            worker1TimerOn = true;
        }
	}

    private void TimeAdd()
    {
        cash += 1;
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
