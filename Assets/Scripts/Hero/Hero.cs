using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    public event UnityAction<int> CheckedCurrentHealthCount;
    public event UnityAction<int> ChangedHealth;

    [SerializeField] private int _health;

    private void Start()
    {
        CheckedCurrentHealthCount?.Invoke(_health);
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
            Death();
        }
        else
        {
            ChangedHealth?.Invoke(_health);
        }
    }

    private void Death()
    {
        Debug.Log("Вы проиграли");
        Time.timeScale = 0;
    }
}
