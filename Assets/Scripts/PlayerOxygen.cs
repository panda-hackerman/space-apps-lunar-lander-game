using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOxygen : MonoBehaviour
{
    public float oxygenLossRate = 1f;
    public float currentOxygen;

    private float maxOxygen = 100f;
    private float oxygenLossTimer;

    void Start()
    {
        // Setting values
        currentOxygen = maxOxygen;
        oxygenLossTimer = oxygenLossRate;
    }

    void Update()
    {
        // Timer
        if (oxygenLossTimer <= 0)
        {
            // Decreases oxygen while keeping it in bounds
            // Shouldn't have -1 oxygen because that's silly
            currentOxygen -= 1;
            currentOxygen = Mathf.Clamp(currentOxygen, 0, maxOxygen);

            // Reset Timer
            oxygenLossTimer = oxygenLossRate;
        }
        else
        {
            oxygenLossTimer -= Time.deltaTime;
        }
    }
    public void RefillOxygen()
    {
        // Call from a different script like a refill station
        currentOxygen = maxOxygen;
    }
}
