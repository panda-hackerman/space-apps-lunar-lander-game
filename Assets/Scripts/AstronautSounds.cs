using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautSounds : MonoBehaviour
{
    public AstronautController astronautController;
    public PlayerOxygen pO;

    private bool oxygenWarning;

    public AudioSource OxygenRefill;
    public AudioSource OxygenWarning;

    // Update is called once per frame
    void Update()
    {
        if (pO.refiiled)
        {
            OxygenRefill.Play();
            pO.refiiled = false;
            oxygenWarning = false;
        }

        if (pO.currentOxygen == 30)
        {
            if (!oxygenWarning)
            {
                OxygenWarning.Play();
                oxygenWarning = true;
            }
        }
    }


}
