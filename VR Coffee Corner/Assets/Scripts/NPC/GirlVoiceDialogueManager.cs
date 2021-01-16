using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlVoiceDialogueManager : MonoBehaviour
{
    public AudioSource voiceClip;

    public Animator anim;

    public Queue<AudioSource> voicelines;

    public bool isTalking;

    // Start is called before the first frame update
    void Start()
    {
        voicelines = new Queue<AudioSource>();
        isTalking = false;
    }


    public void StartVDialogue(VoiceDialogue vDialogue)
    {
        anim.SetBool("isOpen", true);
        isTalking = true;
        Debug.Log("Started conversation");
        voicelines.Clear();

        foreach (AudioSource source in vDialogue.audioVoice)
        {
            voicelines.Enqueue(source);
        }

        NextVoiceline();
    }

    public void NextVoiceline()
    {
        Debug.Log("Continued Convo");
        if (voicelines.Count == 0)
        {
            EndConversation();
            return;
        }

        if (voicelines.Count == 1)
        {
            isTalking = false;
            anim.SetBool("isOpen", false);
        }

        AudioSource sentence = voicelines.Dequeue();
        voiceClip.clip = sentence.clip;
        voiceClip.Play();

    }

    public void EndConversation()
    {
        Debug.Log("No Conversation Left");
        isTalking = false;
    }
}
