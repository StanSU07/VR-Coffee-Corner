using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public GameObject LampLight;

    public GameObject DomeOff;

    public GameObject DomeOn;

    public bool TurnOn;

    private void Start()
    {
        TurnOn = false;
    }


    public void LampSwitch () {

        if (!TurnOn)
        {
            LampLight.SetActive(true);
            DomeOn.SetActive(true);
            DomeOff.SetActive(false);
            TurnOn = true;
        }
        else
        {
            LampLight.SetActive(false);
            DomeOn.SetActive(false);
            DomeOff.SetActive(true);
            TurnOn = false;
        } 

    }
}
