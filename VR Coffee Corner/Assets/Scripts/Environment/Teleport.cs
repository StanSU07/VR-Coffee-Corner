using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    public GameObject player;
    private GameObject zenPortal;
    private GameObject arcadePortal;
    private GameObject zenlobbyPortal;
    private GameObject arcadelobbyPortal;

    private void Awake()
    {
       // DontDestroyOnLoad(this);
    }
    private void Start()
    {
        player = GameObject.Find("XrRig");
        zenPortal = GameObject.Find("ZenPortal");
        arcadePortal = GameObject.Find("ArcadePortal");
        zenlobbyPortal = GameObject.Find("PortalToZen");
        arcadelobbyPortal = GameObject.Find("PortalToArcade");

    }

    //Summary
    //if you interact with any of the teleports it would send you to the position of the second teleport
    //technically how a teleport works
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Portal");
            // SceneManager.LoadScene("ZenRoom");
            //collision.gameObject.transform.position = new Vector3(23, 0, 0);

            if (this.gameObject == zenlobbyPortal)
            {
                SceneManager.LoadScene("ZenRoom");
                player.transform.position = new Vector3(zenPortal.transform.position.x, zenPortal.transform.position.y, zenPortal.transform.position.z + 20);
                //player.transform.position = new Vector3(23, 0, 0);
            }
            if (this.gameObject == arcadelobbyPortal)
            {
                SceneManager.LoadScene("ArcadeRoom");
                player.transform.position = new Vector3(arcadePortal.transform.position.x + 20, arcadePortal.transform.position.y, arcadePortal.transform.position.z);
                //player.transform.position = new Vector3(0, -7, 0);
            }
            if (this.gameObject == zenPortal)
            {
                SceneManager.LoadScene("MainLobby");
                player.transform.position = new Vector3(zenlobbyPortal.transform.position.x , zenlobbyPortal.transform.position.y, zenlobbyPortal.transform.position.z);
               // player.transform.position = new Vector3(12, -20, 0);
            }
            if (this.gameObject == arcadePortal)
            {
                SceneManager.LoadScene("MainLobby");
                player.transform.position = new Vector3(arcadelobbyPortal.transform.position.x + 20, arcadelobbyPortal.transform.position.y, arcadelobbyPortal.transform.position.z);
               // player.transform.position = new Vector3(6, -20, 0);
            }

        }
        
    }

}
