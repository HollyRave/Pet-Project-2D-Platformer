using UnityEngine;
using TMPro;


public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _hero.CheckedStartHealthCount += PrintHealthText;
        _hero.HealthChanged += PrintHealthText;
    }

    private void OnDisable()
    {
        _hero.CheckedStartHealthCount -= PrintHealthText;
        _hero.HealthChanged -= PrintHealthText;
    }

    private void PrintHealthText(int health)
    {
        _text.text = health.ToString();
    }
}
