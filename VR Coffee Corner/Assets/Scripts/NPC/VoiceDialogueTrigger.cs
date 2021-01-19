using UnityEngine;

public class VoiceDialogueTrigger : MonoBehaviour
{
    public VoiceDialogue vDialogue;
    public bool GirlTalking;
    public bool DudeTalking;
    public bool BoothTalking;
    public void Update()
    {
        GirlTalking = FindObjectOfType<GirlVoiceDialogueManager>().isTalking;
        DudeTalking = FindObjectOfType<DudeVoiceDialogueManager>().isTalking;
        BoothTalking = FindObjectOfType<BoothDialogueManager>().isTalking;
    }

    public void TriggerFoodDialogue()
    {
        if (this.gameObject.name == "FoodGirl" && ! GirlTalking) 
        {
          FindObjectOfType<GirlVoiceDialogueManager>().StartVDialogue(vDialogue);
        }
    }

    public void TriggerTaskDialogue()
    {
        if (this.gameObject.name == "TaskDude" && !DudeTalking)
        {
          FindObjectOfType<DudeVoiceDialogueManager>().StartConversation();
        }
    }

    public void TriggerBoothDialogue()
    {
        if (this.gameObject.name == "BoothNPC" && !BoothTalking)
        {
          FindObjectOfType<BoothDialogueManager>().StartVDialogue(vDialogue);
        }
    }
}
