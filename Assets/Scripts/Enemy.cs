using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime, Space.World);
    }
}
