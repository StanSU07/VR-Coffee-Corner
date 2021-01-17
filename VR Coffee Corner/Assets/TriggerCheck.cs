using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;




public class TriggerCheck : MonoBehaviour
{
    public Animator textAnim;
    public VoiceDialogueTrigger taskGuy;
    public XRController controller;
    public InputHelpers.Button talkButton;
    public float activationThreshold = 0.1f;

    //If talkbutton is pressed then hide the help text and start conversation
    public bool CheckIfTalkButtonIsActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, talkButton, out bool isActivated, activationThreshold);
        if (isActivated)
        {
            textAnim.SetBool("isOpen", false);
            taskGuy.triggertaskDialogue();
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
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            textAnim.SetBool("isOpen", false);
        }
    }
}
