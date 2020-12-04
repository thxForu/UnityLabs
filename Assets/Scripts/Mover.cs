using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    public void MoveTo(Vector3 destination, float speedFraction)
    {
        _navMeshAgent.destination = destination;
        _navMeshAgent.speed = maxSpeed * Mathf.Clamp01(speedFraction);
        _navMeshAgent.isStopped = false;
    }
}
