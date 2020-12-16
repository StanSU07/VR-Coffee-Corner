using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    public GameObject player;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Portal");
            SceneManager.LoadScene("ZenRoom");
            collision.gameObject.transform.position = new Vector3(0, 10, -34);
           

            
        }
        
    }

    public void NewScene()
    {
 SceneManager.LoadScene("ZenRoom");
    }
}
