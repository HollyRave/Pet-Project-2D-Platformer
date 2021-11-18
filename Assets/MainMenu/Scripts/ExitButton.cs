using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _durationAnimation;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void OnButtonClick()
    {
        image.DOColor(_targetColor, _durationAnimation)
            .SetLoops(2, LoopType.Yoyo);
    }
}
