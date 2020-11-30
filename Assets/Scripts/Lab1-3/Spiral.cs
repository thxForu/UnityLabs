using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{
    public float angle;
    public float speed;

    private void FixedUpdate()
    {
        angle += 0.25f;
        transform.Rotate(Vector3.up, angle * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
