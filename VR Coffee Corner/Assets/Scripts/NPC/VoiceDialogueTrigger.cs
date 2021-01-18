using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VoiceDialogueTrigger : MonoBehaviour
{
    public VoiceDialogue vDialogue;
    public bool GirlTalking;
    public bool DudeTalking;

    public void Update()
    {
        GirlTalking = FindObjectOfType<GirlVoiceDialogueManager>().isTalking;
        DudeTalking = FindObjectOfType<DudeVoiceDialogueManager>().isTalking;
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
                FindObjectOfType<DudeVoiceDialogueManager>().StartConversation();

            }
        }
    }

    public void test()
    {
        Debug.Log("test");
    }
}
