using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanelShowHide : MonoBehaviour {

    public GameObject Panel;
    int counter = 0;

    

    public void showhidePanel()
    {
        if (counter%2==0)
        {
            Panel.SetActive(true);
            counter = 1;
        } else
        {
            Panel.gameObject.SetActive(false);
            counter = 0;
        }
    } 
} 
