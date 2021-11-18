using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Vector2 _requireValue;
    [SerializeField] private float _durationAnimation;
    public void OnButtonClick()
    {
        transform.DOScale(_requireValue, _durationAnimation)
            .SetLoops(2, LoopType.Yoyo);
    }
}
