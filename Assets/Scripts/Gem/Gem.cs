using UnityEngine;
using UnityEngine.Events;

public class Gem : MonoBehaviour
{
    public event UnityAction CollectedGem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Hero>(out Hero hero))
        {
            Debug.Log("Собрали гем");
            CollectedGem?.Invoke();
            Destroy(gameObject);
        }
    }
}
