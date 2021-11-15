using UnityEngine;
using UnityEngine.Events;

public class Gem : MonoBehaviour
{
    public event UnityAction Collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Hero>(out Hero hero))
        {
            Collected?.Invoke();
            gameObject.SetActive(false);
        }
    }
}
