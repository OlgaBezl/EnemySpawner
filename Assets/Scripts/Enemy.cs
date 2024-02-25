using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private float _lifeTime = 20;

    private void Start()
    {
        InvokeRepeating(nameof(Destroy), _lifeTime, 0);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

    public void SetTarget(Target target)
    {
        _mover.SetTarget(target.transform);
    }
}
