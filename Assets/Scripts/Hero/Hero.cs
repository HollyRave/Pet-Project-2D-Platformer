using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    public event UnityAction<int> HealthChanged;

    [SerializeField] private int _health;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        _health--;

        if (_health == 0)
        {
            Die();
        }
        else
        {
            HealthChanged?.Invoke(_health);
        }
    }

    private void Die()
    {
        Debug.Log("Вы проиграли");
        Time.timeScale = 0;
    }
}
