using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2f;
    void Update()
    {
        transform.LookAt(target.position);
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
