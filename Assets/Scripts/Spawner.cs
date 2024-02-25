using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

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
            spawnPoint.Spawn();
        }
    }
}
