using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtractionWaypoint : MonoBehaviour, IInteractable
{
    public bool extracted;
    public RegolithCount player;
    public GameObject drillPrefab;

    public void OnInteract()
    {
        Debug.Log("You extracted this regolith");
        extracted = true;
        player.CollectRegolith();
        Instantiate(drillPrefab, transform.position, new Quaternion());
        gameObject.SetActive(false);
    }
}
