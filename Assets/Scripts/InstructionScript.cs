using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{
    public GameObject panel;
    public AstronautController playerController;
    public PlayerOxygen pO;

    void Awake()
    {
        panel.SetActive(true);
        pO.enabled = false;
        playerController.enabled = false;
    }

    public void OnInteract()
    {
        panel.SetActive(false);
        pO.enabled = true;
        playerController.enabled = true;

        this.enabled = false;
    }
}
