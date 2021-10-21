using UnityEngine;
using TMPro;


public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _hero = GetComponent<Hero>();
    }

    private void OnEnable()
    {
        Debug.Log("Включили HealthCounter");
        _hero.CheckedCurrentHealthCount += PrintHealthText;
    }

    private void OnDisable()
    {
        _hero.CheckedCurrentHealthCount -= PrintHealthText;
    }

    private void PrintHealthText(int health)
    {
        _text.text = health.ToString();
    }
}
