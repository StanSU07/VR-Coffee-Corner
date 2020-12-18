using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float speed= 10;

    public Animator animator;
    public Transform modelTransform;

    // UI
    public float MaxEnergy;
    public Slider _slide;
    private float currentEnergy;
    public Gradient _grad;
    public Image barcolor;

    // Start is called before the first frame update
    void Start()
    {
       controller= GetComponent<CharacterController>(); 
       currentEnergy= MaxEnergy;
       _slide.maxValue=MaxEnergy;
       _slide.value=MaxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        float hInput= Input.GetAxis("Horizontal");
        float vInput= Input.GetAxis("Vertical");

        direction.x= hInput*speed;
        direction.z= vInput*speed;
        // this is the rotiation of the model when it is stoped(fix!!!)
        if(hInput!=0 || vInput!=0){
            modelTransform.rotation= Quaternion.LookRotation(new Vector3(hInput,0,vInput));
        }

       

        controller.Move(direction* Time.deltaTime);

        animator.SetFloat("speed", Mathf.Abs(hInput));

        if(Input.GetKeyDown(KeyCode.Space)){
            takeEnergy(25f);
        }
        barcolor.color=_grad.Evaluate(1f);
    }

void takeEnergy(float Energy){
    currentEnergy=currentEnergy-Energy;
    _slide.value=currentEnergy;
    barcolor.color= _grad.Evaluate(_slide.normalizedValue);
}


}
