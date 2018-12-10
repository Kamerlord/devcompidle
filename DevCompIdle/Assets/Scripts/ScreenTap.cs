using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenTap : MonoBehaviour {

    public GameManager GM;

    public void ScreenClick()
    {
        
        GM.cash += GM.cashPerClick;
    }

}
