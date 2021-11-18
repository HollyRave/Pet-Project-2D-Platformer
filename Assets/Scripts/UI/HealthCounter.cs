using UnityEngine;
using TMPro;


public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _hero.CheckedCurrentHealthCount += PrintHealthText;
        _hero.ChangedHealth += PrintHealthText;
    }

    private void OnDisable()
    {
        _hero.CheckedCurrentHealthCount -= PrintHealthText;
        _hero.ChangedHealth -= PrintHealthText;
    }

    private void PrintHealthText(int health)
    {
        _text.text = health.ToString();
    }
}
