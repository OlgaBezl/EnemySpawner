using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private float _lifeTime = 20;

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    public void SetTarget(Target target)
    {
        _mover.SetTarget(target.transform);
    }
}
