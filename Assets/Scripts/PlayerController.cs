using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedFraction = 1f;
    [SerializeField] private string selectableTab = "Enemy";
    [SerializeField] private GameObject FireBoll;
    
    private Camera cam;
    private Vector3 posToMove;
    private Mover _mover;

    void Start()
    {
        cam = Camera.main;
        _mover = GetComponent<Mover>();
    }
    void Update()
    {
        InteractWithMovement();
    }

    private void InteractWithMovement()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit)
        {
            var selection = hit.transform;
            if (Input.GetMouseButtonDown(0)&& selection.CompareTag(selectableTab))
            {
                GameObject fireball = Instantiate(FireBoll, transform.position, Quaternion.identity);
                fireball.GetComponent<Fireball>().SetTarget(selection);
                return;
            }
            if (Input.GetMouseButtonDown(0))
            {
                _mover.MoveTo(hit.point, speedFraction);
            }
        }
    }
    private Ray GetMouseRay()
    {
        return cam.ScreenPointToRay(Input.mousePosition);
    }
}
