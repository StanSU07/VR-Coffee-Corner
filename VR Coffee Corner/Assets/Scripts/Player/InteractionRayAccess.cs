using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class InteractionRayAccess : MonoBehaviour
{
    public XRController rightcontroller;
    public InputHelpers.Button rayActivationButton;
    public float activationThreshold = 0.1f;

    private bool justPressed = false;


    void Update()
    {
        if (rightcontroller)
        {
            if (ButtonHeldDown(rightcontroller))
            {
                if (!justPressed)
                {
                    justPressed = true;
                    rightcontroller.gameObject.SetActive(!rightcontroller.gameObject.activeSelf);
                }
            }
            else
            {
                if (justPressed)
                {
                    justPressed = false;
                }
            }

        }


    }

    public bool ButtonHeldDown(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, rayActivationButton, out bool heldDown, activationThreshold);

        return heldDown;
    }

}
