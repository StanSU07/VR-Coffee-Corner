using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Taskstext : MonoBehaviour
{
    public float time;
    public string task;

    


    IEnumerator Start()    
{

     
        yield return new WaitForSeconds(time);
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText(task);
        
        

    }


}
