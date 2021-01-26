using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer trailer;
    public Animator anim;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!trailer.isPlaying)
            {
                trailer.Play();
                anim.SetBool("isOpen", true);
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (trailer.isPlaying || !trailer.isPlaying)
            {
                trailer.Pause();
                anim.SetBool("isOpen", false);
            }
        }
    }

    public void VideoManager()
    {
        if (trailer.isPlaying)
        {
            trailer.Pause();
        }
        else
        {
            trailer.Play();
        }
    }

    public void Restart()
    {
        trailer.Stop();
        trailer.Play();
    }
}
