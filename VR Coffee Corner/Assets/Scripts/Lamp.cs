using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    [HideInInspector]
    public GameObject LampLight;

    [HideInInspector]
    public GameObject DomeOff;

    [HideInInspector]
    public GameObject DomeOn;

    public bool TurnOn=false;
    
    

	// Use this for initialization
	public void LampSwitch () {
        if(TurnOn==false){
            LampLight.SetActive(true);
            DomeOff.SetActive(false);
            DomeOn.SetActive(true);
        }
        else if(TurnOn==true){
            LampLight.SetActive(false);
            DomeOff.SetActive(true);
            DomeOn.SetActive(false);
        }

        
    }


}
