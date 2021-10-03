using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOxygenUI : MonoBehaviour
{
    // UI for the PlayerOxygen is kept here so that it can function without it

    public PlayerOxygen pO;
    public TMP_Text textOxygen;

    void Update()
    {
        textOxygen.text = "" + pO.currentOxygen;
    }
}
