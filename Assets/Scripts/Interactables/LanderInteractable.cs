using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanderInteractable : MonoBehaviour, IInteractable
{
    public PlayerOxygen playerOxygen;

    public void OnInteract()
    {
        playerOxygen.RefillOxygen();
    }
}
