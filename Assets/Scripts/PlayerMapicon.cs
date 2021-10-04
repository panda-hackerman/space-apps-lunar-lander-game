using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMapicon : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 20f, 0);
    public float rotOffset = 180;

    private void Update()
    {
        transform.position = player.transform.position + offset;
        transform.eulerAngles = transform.eulerAngles.Y(player.eulerAngles.y + rotOffset);
    }
}
