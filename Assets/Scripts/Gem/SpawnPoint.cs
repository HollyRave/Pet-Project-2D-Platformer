using System.Collections;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Gem _gem;
    [SerializeField] private float _secondsBetweenSpawn;

    private void OnEnable()
    {
        _gem.Collected += StartSpawnGem;
    }

    private void OnDisable()
    {
        _gem.Collected -= StartSpawnGem;
    }

    private void StartSpawnGem()
    {
        StartCoroutine(SpawnGem());
    }

    private IEnumerator SpawnGem()
    {
        yield return new WaitForSeconds(_secondsBetweenSpawn);
        _gem.gameObject.SetActive(true);
    }
}
