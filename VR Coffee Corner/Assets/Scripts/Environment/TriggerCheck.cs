using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;




public class TriggerCheck : MonoBehaviour
{
    public Animator textAnim;
    [SerializeField]
    private GameObject FoodUI;
    public VoiceDialogueTrigger taskGuy;
    public XRController controller;
    public InputHelpers.Button talkButton;
    public float activationThreshold = 0.1f;

    private void Start()
    {
        FoodUI.SetActive(false);
    }

    //If talkbutton is pressed then hide the help text and start conversation
    public bool CheckIfTalkButtonIsActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, talkButton, out bool isActivated, activationThreshold);
        if (isActivated)
        {
            textAnim.SetBool("isOpen", false);

            taskGuy.TriggerFoodDialogue();
            
            taskGuy.TriggerTaskDialogue();

            taskGuy.TriggerBoothDialogue();
        }
        return isActivated;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("col");
        if (collision.gameObject.CompareTag("Player"))
        {
            textAnim.SetBool("isOpen", true);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (controller)
            {
                CheckIfTalkButtonIsActivated(controller);
            }
            if (CheckIfTalkButtonIsActivated(controller) && this.gameObject.name == "FoodTrigger")
            {
                if (!FoodUI.activeSelf)
                {
                    FoodUI.SetActive(true);
                }
            }
        }
    }

    public void DeactivateFoodUI()
    {
        FoodUI.SetActive(false);
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textAnim.SetBool("isOpen", false);
        }

        if (FoodUI.activeSelf)
        {
            FoodUI.SetActive(false);
        }
    }
}
