using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycloid : MonoBehaviour
{
    public float rm;
    public float theta;
    public float speed;
    
    private float t;
    private Vector3 _direction;

    private void Start()
    {
        _direction = transform.forward;
    }

    private void Update()
    {
        t += Time.deltaTime * speed;
        if (Mathf.Abs(transform.position.x) > 10)
            _direction *= -1;
        
        transform.Translate(_direction*speed*Time.deltaTime);
        transform.position = new Vector3(transform.position.x,CycloidY(rm,t),transform.position.z);
    }
    private float CycloidY(float rm, float theta)
    {
        return rm * (1 - Mathf.Cos(theta));
    }
}
