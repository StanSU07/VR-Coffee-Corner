using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player: MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    Vector3 direction;
    public float movingSpeed;
  
   
    
    void Start()
    {
        
    }


    void Update()
    {

        //Moving code
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        direction = new Vector3(moveHorizontal, 0, moveVertical);
        gameObject.transform.Translate(direction.normalized * Time.deltaTime * movingSpeed);



        //Raising Hand code 

         if (Input.GetKey("space"))
        {
           print("Raise your hand!");
        }  
    }
}
