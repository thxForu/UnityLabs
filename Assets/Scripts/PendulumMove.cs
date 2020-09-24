using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMove : MonoBehaviour
{
    public Vector3 xAngle;

    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.x);
        transform.Rotate(xAngle,speed*Time.deltaTime);
        
        if (Mathf.Abs(transform.rotation.x) > 0.3)
        {
            xAngle *= -1;
        } 
    }
    
}
