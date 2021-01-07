using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{

    public string id;

    public void Collect()
    {
        this.gameObject.SetActive(false);

        Events.current.ItemCollected(id);
    }
    public void ResetItems()
    {
        this.gameObject.SetActive(true);
    }
}
