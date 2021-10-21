using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(HeroMover))]
[RequireComponent(typeof(SpriteRenderer))]
public class HeroAnimator : MonoBehaviour
{
    private Animator _animator;
    private HeroMover _heroMover;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _heroMover = GetComponent<HeroMover>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _heroMover.HeroMoved += ChangeAnimation;
    }

    private void OnDisable()
    {
        _heroMover.HeroMoved -= ChangeAnimation;
    }

    private void ChangeAnimation(float speed)
    {
        _animator.SetFloat("Speed", Mathf.Abs(speed));

        if (speed < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (speed > 0)
        {
            _spriteRenderer.flipX = false;
        }
    }
}
