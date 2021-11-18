using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AuthorsButton : MonoBehaviour
{
    [SerializeField] private Vector3 _requireValue;
    [SerializeField] private float _durationAnimation;
    public void OnButtonClick()
    {
        transform.DORotate(_requireValue, _durationAnimation, RotateMode.FastBeyond360);
    }
}
