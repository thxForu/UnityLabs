using System;
using UnityEngine;

public class Ball : MonoBehaviour

{
    public float thrust = 1.0f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        _rigidbody.AddForce(-transform.forward * thrust);
        _rigidbody.useGravity = true;
    }
}