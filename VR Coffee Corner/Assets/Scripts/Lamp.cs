using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    
    public GameObject LampLight;

    
    public GameObject DomeOff;

    
    public GameObject DomeOn;

    public bool TurnOn=false;




    public void LampSwitch () {
        if(TurnOn==true){
            LampLight.SetActive(true);
            DomeOff.SetActive(false);
            DomeOn.SetActive(true);
            TurnOn = false;
        }
        else if(TurnOn==false){
            LampLight.SetActive(false);
            DomeOff.SetActive(true);
            DomeOn.SetActive(false);
            TurnOn = true;
        }

        
    }


}
