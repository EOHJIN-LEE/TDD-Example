using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Monster : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Text hpText;
    [SerializeField] private int health = 100;

    private const int Damage = 10;

    public int Health
    {
        get => health;
        set
        {
            health = value;
            RefreshHp();
        }
    }

    void Start()
    {
        RefreshHp();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        TakeDamage();
    }

    private void RefreshHp()
    {
        hpText.text = Health <= 0 ? "Dead!" : Health.ToString();
    }

    private void TakeDamage()
    {
        Health -= Damage;
        RefreshHp();
    }
}
