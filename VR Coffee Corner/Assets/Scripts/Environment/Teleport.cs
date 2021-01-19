using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    private GameObject zenPortal;
    private GameObject arcadePortal;
    private GameObject zenlobbyPortal;
    private GameObject arcadelobbyPortal;

    public GameObject xrRig;
    public text Script;

    private void Start()
    {
        zenPortal = GameObject.Find("ZenPortal");
        arcadePortal = GameObject.Find("ArcadePortal");
        zenlobbyPortal = GameObject.Find("PortalToZen");
        arcadelobbyPortal = GameObject.Find("PortalToArcade");

        xrRig = GameObject.Find("XR Rig");
    }

    //Summary
    //if you interact with any of the teleports it would send you to the position of the second teleport
    //technically how a teleport works
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Portal");

            if (this.gameObject == zenlobbyPortal)
            {
               // SceneManager.LoadScene("ZenRoom");
                xrRig.transform.position = new Vector3(zenPortal.transform.position.x, zenPortal.transform.position.y, zenPortal.transform.position.z + 20);
                Script.GetComponent<text>().SetLocationZenGarden();
            }

            if (this.gameObject == arcadelobbyPortal)
            {
                //SceneManager.LoadScene("ArcadeRoom");
                xrRig.transform.position = new Vector3(arcadePortal.transform.position.x - 20, arcadePortal.transform.position.y, arcadePortal.transform.position.z);
                Script.GetComponent<text>().SetLocationArcade();
            }

            if (this.gameObject == zenPortal)
            {
                //SceneManager.LoadScene("MainLobby");
                xrRig.transform.position = new Vector3(zenlobbyPortal.transform.position.x , zenlobbyPortal.transform.position.y, zenlobbyPortal.transform.position.z);
                Script.GetComponent<text>().SetLocationMainLobby();
            }

            if (this.gameObject == arcadePortal)
            {
                //SceneManager.LoadScene("MainLobby");
                xrRig.transform.position = new Vector3(arcadelobbyPortal.transform.position.x + 20, arcadelobbyPortal.transform.position.y, arcadelobbyPortal.transform.position.z);
                Script.GetComponent<text>().SetLocationMainLobby();
            }

        }
        
    }

}
