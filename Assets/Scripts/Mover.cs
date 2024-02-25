using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private float _speed = 5;

    private void Update()
    {
        Vector3 direction = _targetTransform.position - transform.position;
        transform.Translate(_speed * Time.deltaTime * direction.normalized, Space.World);
        transform.LookAt(_targetTransform);
    }

    public void SetTarget(Transform targetTransform)
    {
        _targetTransform = targetTransform;
    }
}
