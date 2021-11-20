using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Button))]
public class ExitButton : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _durationAnimation;

    private Button _button;
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
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

    private void OnClick()
    {
        _image.DOColor(_targetColor, _durationAnimation)
            .SetLoops(2, LoopType.Yoyo);
    }
}
