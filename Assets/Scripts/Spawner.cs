using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _spawnDelay = 2f;

    private float _timeUntilSpawn= 0f;

    private void Update()
    {
        if (_timeUntilSpawn <= 0)
        {
            Spawn();
            _timeUntilSpawn = _spawnDelay;
        }

        _timeUntilSpawn -= Time.deltaTime;
    }

    private void Spawn()
    {
        Debug.Log(gameObject.name + " " + transform.rotation);
        Instantiate(_enemyPrefab, transform.position, transform.rotation);
    }
}
