using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _spawnDelay = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _spawnDelay);
    }
   
    private void Spawn()
    {
        Instantiate(_enemyPrefab, transform.position, transform.rotation);
    }
}
