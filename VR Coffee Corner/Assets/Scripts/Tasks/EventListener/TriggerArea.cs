using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public string id;

    private void OnTriggerStay(Collider other)
    {
        Events.current.PlaceTriggerEnter(id);
    }

    private void OnTriggerExit(Collider other)
    {
        Events.current.PlaceTriggerExit(id);
    }
}
