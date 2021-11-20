using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class AuthorsButton : MonoBehaviour
{
    [SerializeField] private Vector3 _requireValue;
    [SerializeField] private float _durationAnimation;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    public void OnClick()
    {
        transform.DORotate(_requireValue, _durationAnimation, RotateMode.FastBeyond360);
    }
}
