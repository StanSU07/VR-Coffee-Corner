using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoardPen : MonoBehaviour
{
    public WhiteBoard whiteboard;

    private RaycastHit touch;
    private bool lastTouch;
    private Quaternion lastAngle;

    void Start()
    {
    this.whiteboard =GameObject.Find("White Board").GetComponent<WhiteBoard>();    
    }


    void Update()
    {
        float tipHeight = transform.Find("tip").transform.localScale.y;
        Vector3 tip =transform.Find("tip").transform.position;

        if(lastTouch){
            tipHeight *=1.1f;
        }

        if (Physics.Raycast(tip, transform.up, out touch , tipHeight)){
            if(!(touch.collider.tag == "Whiteboard"))
            return;
            this.whiteboard=touch.collider.GetComponent<WhiteBoard>();

            this.whiteboard.SetColor(Color.blue);
            this.whiteboard.setTouchPosition(touch.textureCoord.x, touch.textureCoord.y);
            this.whiteboard.ToggleTouch(true);
            
            if(!lastTouch){
                lastTouch=true;
                lastAngle=transform.rotation;
            }
            else{
                lastTouch=false;
                this.whiteboard.ToggleTouch(false);
            }
            if(lastTouch){
                transform.rotation = lastAngle;
            }
        }
        
    }
}
