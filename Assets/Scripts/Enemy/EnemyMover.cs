using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform _targetSpot;
    [SerializeField] private float _enemySpeed;
    private Transform _startPosition;

    private void Awake()
    {
        _startPosition = transform;
        EnemyMove(_startPosition, _targetSpot);
    }

    private void Update()
    {
        if (Vector2.Distance(gameObject.transform.position, _targetSpot.position) < 0.2)
        {
            EnemyMove(_targetSpot, _startPosition);
        }
        else if(Vector2.Distance(gameObject.transform.position, _startPosition.position) < 0.2)
        {
            EnemyMove(_startPosition, _targetSpot);
        }
    }

    private void EnemyMove(Transform from, Transform to)
    {
        gameObject.transform.position = Vector2.MoveTowards(from.position, to.position, _enemySpeed * Time.deltaTime);
    }
}
