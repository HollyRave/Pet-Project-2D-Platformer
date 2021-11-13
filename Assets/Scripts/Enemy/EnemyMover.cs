using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform _targetSpot;
    [SerializeField] private float _moveDuration;

    private void Start()
    {
        transform.DOMove(_targetSpot.position, _moveDuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}
