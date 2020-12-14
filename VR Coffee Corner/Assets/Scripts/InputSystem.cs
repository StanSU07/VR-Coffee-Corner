using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class InputSystem : MonoBehaviour
{

    private bool _leftTriggerDown;
    private bool _leftGripDown;
    // and other left hand buttons

    private bool _rightTriggerDown;
    private bool _rightGripDown;
    // and other right hand buttons


    // Start is called before the first frame update
    void Start()
    {

    }

    /*
        private void Update()
        {
            foreach (InputDevice inputDevice in _inputDevices)
            {
                if (inputDevice.characteristic.HasFlag(InputDeviceCharacteristic.Left))
                {
                    // Left hand, grip button
                    ProcessInputDeviceButton(inputDevice, InputHelpers.Button.Grip, ref _leftTriggerDown,
                    () => // On Button Down
                {
                        Debug.Log("Left hand trigger down");
                    // Your functionality
                },
                    () => // On Button Up
                {
                        Debug.Log("Left hand trigger up");
                    });
                    // Repeat ProcessInputDeviceButton for other buttons
                }
                // Repeat for right hand
            }
        }

        private void ProcessInputDeviceButton(InputDevice inputDevice, InputHelpers.Button button, ref bool _wasPressedDownPreviousFrame, Action onButtonDown = null, Action onButtonUp = null, Action onButtonHeld = null)
        {
            if (inputDevice.IsPressed(button, out bool isPressed) && isPressed)
            {
                if (!_wasPressedDownPreviousFrame) // // this is button down
                {
                    onButtonDown?.Invoke();
                }

                _wasPressedDownPreviousFrame = true;
                onButtonHeld?.Invoke();
            }
            else
            {
                if (_wasPressedDownPreviousFrame) // this is button up
                {
                    onButtonUp?.Invoke();
                }

                _wasPressedDownPreviousFrame = false;
            }*/
}
