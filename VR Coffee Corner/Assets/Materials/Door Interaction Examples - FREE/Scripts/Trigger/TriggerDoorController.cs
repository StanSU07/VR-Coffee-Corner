using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    private Animator anim;

     void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("closed");
        }
    }

}
