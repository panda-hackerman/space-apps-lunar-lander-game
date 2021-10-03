using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtractionPointInteractable : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        Debug.Log("You extracted this point");
    }
}
