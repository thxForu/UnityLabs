using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private float chaseDistance = 5f;
    [SerializeField] private float speedFraction = 0.8f;
    private GameObject _player;

    private Mover _mover;

    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _mover = GetComponent<Mover>();
    }

    void Update()
    {
        if (InAttackRangeOfPlayer())
        {
            _mover.MoveTo(_player.transform.position, speedFraction);
        }
    }
    private bool InAttackRangeOfPlayer()
    {
        float distance = Vector3.Distance(_player.transform.position, transform.position);
        return distance < chaseDistance;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, chaseDistance);
    }
}
