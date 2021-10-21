using System.Collections;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _gem;
    [SerializeField] private float _secondsBetweenSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Hero>(out Hero hero))
        {
            CollectGem();
        }
    }

    private void CollectGem()
    {
        _gem.SetActive(false);
        StartCoroutine(SpawnGem());
    }

    private IEnumerator SpawnGem()
    {
        yield return new WaitForSeconds(_secondsBetweenSpawn);
        _gem.SetActive(true);
    }
}
