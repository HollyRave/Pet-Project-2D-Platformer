using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    public event UnityAction<int> CheckedCurrentHealthCount;

    [SerializeField] private int _health;
    [SerializeField] private List<Enemy> _enemies;


    private void Start()
    {
        CheckedCurrentHealthCount?.Invoke(_health);
    }

    private void OnEnable()
    {
        foreach (var item in _enemies)
        {
            item.HeroAttacked += TakeDamage;
        }
    }

    private void OnDisable()
    {
        foreach (var item in _enemies)
        {
            item.HeroAttacked -= TakeDamage;
        }
    }

    private void TakeDamage()
    {
        if (_health == 0)
        {
            Death();
        }
        else
        {
            _health--;
            CheckedCurrentHealthCount?.Invoke(_health);
        }
    }

    private void Death()
    {
        Debug.Log("Вы проиграли");
        Time.timeScale = 0;
    }
}
