using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMove : MonoBehaviour
{
    public Vector3 xAngle;
    public float speed = 3f;

    private void Update()
    {
        transform.Rotate(xAngle,speed*Time.deltaTime);
        if (Mathf.Abs(transform.rotation.x) > 0.3)
            xAngle *= -1;
    }
}
