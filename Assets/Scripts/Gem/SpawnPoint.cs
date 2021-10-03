using UnityEngine;

[RequireComponent(typeof(Gem))]
public class SpawnPoint : MonoBehaviour
{
    public bool IsBusyForSpawn { get; private set; } = false;

    [SerializeField] private GemSpawner _gemSpawner;
    private Gem _gem;

    private void Awake()
    {
        _gem = GetComponent<Gem>();
    }

    private void OnEnable()
    {
        _gem.CollectedGem += MakeFreeForSpawn;
        _gemSpawner.SpawnedGem += MakeBusyForSpawn;
    }

    private void OnDisable()
    {
        _gem.CollectedGem -= MakeFreeForSpawn;
        _gemSpawner.SpawnedGem -= MakeBusyForSpawn;
    }


    private void MakeFreeForSpawn()
    {
        IsBusyForSpawn = false;
    }

    private void MakeBusyForSpawn()
    {
        IsBusyForSpawn = true;
    }
}
