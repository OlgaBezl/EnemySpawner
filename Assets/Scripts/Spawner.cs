using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _spawnDelay = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _spawnDelay);
    }
   
    private void Spawn()
    {
        foreach (SpawnPoint spawnPoint in _spawnPoints)
        {
            Instantiate(spawnPoint.EnemyPrefab, spawnPoint.transform.position, Quaternion.identity).SetTarget(spawnPoint.Target);
        }
    }
}
