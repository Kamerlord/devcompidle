using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenTap : MonoBehaviour {

    public GameManager GM;
    public float timer = 1;

    public void Update()
    {
        if(GM.screenTapped == true)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                GM.screenTapped = false;
                timer = 10;
            }
        }
    }

    public void ScreenClick()
    {
        
        GM.cash += GM.cashPerClick;
        GM.screenTapped = true;
    }

}
