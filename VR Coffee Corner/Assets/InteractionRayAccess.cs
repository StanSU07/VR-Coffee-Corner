using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class InteractionRayAccess : MonoBehaviour
{
    public XRController rightcontroller;
    public XRController leftcontroller;
    public InputHelpers.Button rayActivationButton;
    public float activationThreshold = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (rightcontroller)
        {
            rightcontroller.gameObject.SetActive(CheckIfActivated(rightcontroller));
        }
        if (leftcontroller)
        {
            leftcontroller.gameObject.SetActive(CheckIfActivated(leftcontroller));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, rayActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
