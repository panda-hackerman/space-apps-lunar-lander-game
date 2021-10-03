using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RegolithCount : MonoBehaviour
{
    public TMP_Text regolithScore;
    private float regolithCount = 0f;

    public void CollectRegolith()
    {
        regolithCount++;
        regolithScore.text = $"Samples: {regolithCount}";
    }
}
