using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
    private Camera cam;
    private Vector3 posToMove;
    private NavMeshAgent _navMeshAgent;
    [SerializeField] private float maxSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        InteractWithMovement();
    }

    private bool InteractWithMovement()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit)
        {
            if (Input.GetMouseButton(0))
            {
                MoveTo(hit.point, 1f);
            }
            return true;
        }
        return false;
    }
    private Ray GetMouseRay()
    {
        return cam.ScreenPointToRay(Input.mousePosition);
    }
    public void MoveTo(Vector3 destination, float speedFraction)
    {
        _navMeshAgent.destination = destination;
        _navMeshAgent.speed = maxSpeed * Mathf.Clamp01(speedFraction);
        _navMeshAgent.isStopped = false;
    }
}
