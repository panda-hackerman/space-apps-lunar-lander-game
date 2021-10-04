using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionPointer : MonoBehaviour
{
    public Camera playerCam;
    public Transform reticle;
    public GameObject ActionSprite;
    private RaycastHit hit;
    public float pointerDistance = 13.5f;

    // Update is called once per frame
    void Update()
    {
        // Debugging

        // Shoots a ray from the camera to the center of the screen with some vertical offset so it overshoots the player
        Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5F, 0.6f, 0));

        // Checks if whatever the ray hits is in a acceptable distance
        if(Physics.Raycast(ray, out hit, pointerDistance))
        {
            IInteractable interactable = hit.transform.GetComponent<IInteractable>();
            if (interactable != null)
            {
                ActionSprite.SetActive(true);
            }
            else ActionSprite.SetActive(false);

            // The reticle is for testing, it can be replaced with a crosshair probably or just made nicer looking
            // moves reticle to that position
            reticle.position = hit.point;
            reticle.gameObject.SetActive(true);
        }
        else reticle.gameObject.SetActive(false); // disables reticle when out of range
    }

    public void OnInteract()
    {
        // Same stuff as in update
        Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5F, 0.6f, 0));
        if (Physics.Raycast(ray, out hit, pointerDistance))
        {
            // Checks if hit collider has an interactable interface attatched to it's class
            IInteractable interactable = hit.transform.GetComponent<IInteractable>();
            if(interactable != null)
            {
                // calls interact method if it does
                interactable.OnInteract();
            }
        }
    }
}
