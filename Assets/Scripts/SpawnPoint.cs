using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;
    
    public void Spawn()
    {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity).SetTarget(_target);
    }
}
