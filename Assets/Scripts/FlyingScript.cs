using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
    public Transform[] movePoints;
    public Transform flyingObject;
    private Transform newPoint;
    public float minSpeed;
    public float maxSpeed;
    private float speed;

    Vector3 spinDir;

    Transform nextPoint()
    {
        int x = Random.Range(0, movePoints.Length);
        if (movePoints[x] != newPoint)
        {
            return movePoints[x];
        }
        else
        {
            if (x != 0) return movePoints[0];
            if (x != 2) return movePoints[2];
        }

        return null;
    }

    // Start is called before the first frame update
    void Start()
    {
        newPoint = nextPoint();
        speed = Random.Range(minSpeed, maxSpeed);
        spinDir = new Vector3(Random.Range(0, speed), Random.Range(0, speed), Random.Range(0, speed));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(flyingObject.position, newPoint.position) > 0.1f)
        {
            flyingObject.position = Vector3.MoveTowards(flyingObject.position, newPoint.position, speed * Time.deltaTime);
        }
        else
        {
            newPoint = nextPoint();
            speed = Random.Range(minSpeed, maxSpeed);
            spinDir = new Vector3(Random.Range(0, speed), Random.Range(0, speed), Random.Range(0, speed));
        }

        flyingObject.Rotate((spinDir * speed) * Time.deltaTime);
    }
}
