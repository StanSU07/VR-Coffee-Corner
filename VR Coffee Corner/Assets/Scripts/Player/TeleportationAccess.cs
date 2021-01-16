using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class TeleportationAccess : MonoBehaviour
{
    public XRController teleportRay;
    public InputHelpers.Button tpActivationButton;
    public float activationThreshold = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (teleportRay)
        {
            teleportRay.gameObject.SetActive(CheckIfActivated(teleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, tpActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
