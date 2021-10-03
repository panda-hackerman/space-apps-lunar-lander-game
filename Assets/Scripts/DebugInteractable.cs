using UnityEngine;

public class DebugInteractable : MonoBehaviour, IInteractable
{
    /* This script is made to test interactions with the InteractionPointer script
     * Interfaces like IInteract can be added after the base class, it can be treated like a tag for scripts but can also have its own methods
     * A camera is needed
     * when a object with this script attatched is in the center of the screen, press E to interact
     * Anything with the IInteractable interface will be able to have it's OnInteract() function called
     */

    // Add ths function to every script using IInteract
    public void OnInteract()
    {
        Debug.Log("Interacted with " + name);
    }
}
