using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class MainMovement : MonoBehaviour
{
    public float speed =1;
    public XRNode inputSource;
    public float gravity = -9.81f;
    public LayerMask groundLayer;
    public float additionalHeight = 0.2f;
    public bool sitting=false;

    private float fallingSpeed;
    private XRRig rig;
    private Vector2 inputAxis;
    private CharacterController character;
    private GameObject chair; 
    
    void Awake()
    {
        character = GetComponent<CharacterController>();
        rig = GetComponent<XRRig>();
        DontDestroyOnLoad(gameObject);
        chair = GameObject.Find("Chair");

    }

    
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);

        
    }
    
  
    public void FixedUpdate()
    {
        CapsuleFollowedHeadSet();

        
        //Moving Code 
        Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y,0);
        if(sitting==false){
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);
        character.Move(direction * Time.fixedDeltaTime *speed);
        }
        if(sitting==true){
        Vector3 direction = headYaw * new Vector3(0, 0,0);
        character.Move(direction * Time.fixedDeltaTime *0);
        }
        if (Input.GetKeyDown("space")){
        sitting=false;
         }

        //Gravity
        bool isGrounded = checkIfGrounded();

        if(isGrounded){
            fallingSpeed=0;
        }
        else{
        fallingSpeed += gravity * Time.fixedDeltaTime;
        character.Move(Vector3.up * fallingSpeed *Time.fixedDeltaTime);
    }
    }

    void CapsuleFollowedHeadSet(){
        character.height = rig.cameraInRigSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.cameraGameObject.transform.position);
        character.center = new Vector3(capsuleCenter.x, character.height / 2 + character.skinWidth, capsuleCenter.z);
    }

    bool checkIfGrounded(){
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "portal")
        {
            SceneManager.LoadScene("Zen Garden");
            gameObject.transform.position = new Vector3(3, 0, 3);
        }

         if (collision.gameObject.name == "Chair")
        {
            gameObject.transform.position = chair.transform.position;
            sitting=true;
          
        }
}
    public void chairSit(){
            gameObject.transform.position = chair.transform.position;
            sitting=true;
    }
}
