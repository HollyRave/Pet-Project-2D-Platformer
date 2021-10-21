using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public event UnityAction HeroAttacked;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(TryGetComponent<Hero>(out Hero hero))
        {
            HeroAttacked?.Invoke();
        }
    }
}
