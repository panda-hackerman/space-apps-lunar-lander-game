using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform A;
    public Transform B;

    void Update()
    {
        lineRenderer.SetPosition(0, A.position);
        lineRenderer.SetPosition(1, B.position);
    }
}
