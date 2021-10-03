using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MinimapController : MonoBehaviour
{
    public Transform minimapCamera;
    public Transform player;
    public RawImage miniMap;

    private void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = minimapCamera.position.y;
        minimapCamera.position = newPosition;
    }

    public void OnEnableMap()
    {
        miniMap.enabled = !miniMap.enabled;
    }
}
