using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairCode : MonoBehaviour
{
    public Transform player;
    public MainMovement Script;
    public bool sitting;
  

   
    public void ChairSit()
    {
            sitting = true; 
            player.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Script.GetComponent<MainMovement>().FixedUpdate();
        Debug.Log("Sit");
            
        
    }
}
