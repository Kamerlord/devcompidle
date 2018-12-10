using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanelShowHide : MonoBehaviour {

    public GameObject UpgradePanel;
    int counter = 0;

    

    public void ShowhidePanel()
    {
        if (counter == 0)
        {
            UpgradePanel.SetActive(true);
            counter = 1;
        }
        else
        {
            UpgradePanel.SetActive(false);
            counter = 0;
        }
    }
    
    public void CloseUpgradePanel()
    {
        UpgradePanel.SetActive(false);
        counter = 0;
    }
} 
