using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Artistas
{
    public class CurrentCurrency : MonoBehaviour
    {
        [SerializeField] private CurrencySO currency;

        [Header("UI")]
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI amount;

        private void Awake()
        {
            SetData();
        }

        private void SetData()
        {
            icon.sprite = currency.icon;

            SetAmount();
        }

        public void SetAmount()
        {
            amount.text = currency.amount.ToString();
        }
    }
}