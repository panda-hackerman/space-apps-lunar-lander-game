using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RegolithCount : MonoBehaviour
{
    public int samplesToWin = 3;
    public TMP_Text regolithScore;
    private float regolithCount = 0f;
    public SceneSwitcher sceneSwitcher;

    public void CollectRegolith()
    {
        regolithCount++;
        regolithScore.text = $"Samples: {regolithCount}";

        if (regolithCount == samplesToWin)
        {
            sceneSwitcher.LoadScene("WinScreen");
        }
    }
}
