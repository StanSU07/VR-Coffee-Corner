using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeTest : MonoBehaviour
{
    public Material[] skyboxes;
    public Material currentSkybox;
    public Material ZenSkybox;
    public Material LobbySkybox;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyboxes[Random.Range(0, skyboxes.Length)];
        currentSkybox = RenderSettings.skybox;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RenderSettings.skybox = skyboxes[Random.Range(0, skyboxes.Length)];
            currentSkybox = RenderSettings.skybox;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RenderSettings.skybox = ZenSkybox;
            currentSkybox = RenderSettings.skybox;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            RenderSettings.skybox = LobbySkybox;
            currentSkybox = RenderSettings.skybox;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RenderSettings.skybox = skyboxes[Random.Range(0, skyboxes.Length)];
            currentSkybox = RenderSettings.skybox;
        }
    }
}
