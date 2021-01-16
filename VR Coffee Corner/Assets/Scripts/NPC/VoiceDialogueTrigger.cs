using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VoiceDialogueTrigger : MonoBehaviour
{
    public VoiceDialogue vDialogue;
    public bool GirlTalking;
    public bool DudeTalking;

    private void Start()
    {
    }
    public void Update()
    {
        GirlTalking = FindObjectOfType<GirlVoiceDialogueManager>().isTalking;
        DudeTalking = FindObjectOfType<DudeVoiceDialogueManager>().isTalking;

        if (this.gameObject.name == "FoodGirl")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "FoodGirl")
                    {
                        if (!GirlTalking)
                        {
                            FindObjectOfType<GirlVoiceDialogueManager>().StartVDialogue(vDialogue);
                        }
                    }
                }
            }
        }
        if (this.gameObject.name == "TaskDude")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "TaskDude")
                    {
                        if (!DudeTalking)
                        {
                            FindObjectOfType<DudeVoiceDialogueManager>().StartVDialogue(vDialogue);

                        }
                    }
                }
            }
        }
    }

    public void triggerfoodDialogue()
    {
        if (this.gameObject.name == "FoodGirl")
        {
            if (!GirlTalking)
            {
                FindObjectOfType<GirlVoiceDialogueManager>().StartVDialogue(vDialogue);
            }
        }
    }

    public void triggertaskDialogue()
    {
        if (this.gameObject.name == "TaskDude")
        {
            if (!DudeTalking)
            {
                FindObjectOfType<DudeVoiceDialogueManager>().StartVDialogue(vDialogue);

            }
        }
    }

    public void test()
    {
        Debug.Log("test");
    }
}
