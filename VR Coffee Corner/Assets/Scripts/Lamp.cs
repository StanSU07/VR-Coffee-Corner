using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour {

    [HideInInspector]
    public GameObject LampLight;

    [HideInInspector]
    public GameObject DomeOff;

    [HideInInspector]
    public GameObject DomeOn;

    public bool TurnOn;
    
    

	// Use this for initialization
	public void TurnOnLamp () {
    
            LampLight.SetActive(true);
            DomeOff.SetActive(false);
            DomeOn.SetActive(true);
        

        
    }

    public void TurnoffLamp(){
            LampLight.SetActive(false);
            DomeOff.SetActive(true);
            DomeOn.SetActive(false);
    }
}
