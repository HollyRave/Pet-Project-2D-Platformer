using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GemSpawner : MonoBehaviour
{
    public event UnityAction SpawnedGem;

    [SerializeField] private GameObject _gemPrefab;
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime;

    private void Awake()
    {
        //CheckPossibilitySpawnGem();

        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            SpawnGem(_spawnPoints[i].transform);
        }
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;
            CheckPossibilitySpawnGem();
        }
    }

    private void CheckPossibilitySpawnGem()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            Debug.Log("ѕошла проверка на возможность спавна. " + i + " " + _spawnPoints[i].IsBusyForSpawn);
            if (_spawnPoints[i].IsBusyForSpawn == false)
            {
                SpawnGem(_spawnPoints[i].transform);
            }
        }
    }

    private void SpawnGem(Transform position)
    {
        Instantiate(_gemPrefab, position);
        SpawnedGem?.Invoke();
    }
}
