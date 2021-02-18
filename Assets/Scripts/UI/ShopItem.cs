using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Artistas
{
    public class ShopItem : MonoBehaviour
    {
        [SerializeField] private ProductSO product;

        [Header("UI")]
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI title;
        [SerializeField] private TextMeshProUGUI description;
        [SerializeField] private TextMeshProUGUI limit;
        [SerializeField] private TextMeshProUGUI price;

        [Header("Events")]
        [SerializeField] private UnityEvent<ProductSO> OnBuy;

        private void Awake()
        {
            SetData();
        }

        public void Buy()
        {
            OnBuy.Invoke(product);

            SetLimitAndPriceText();
        }

        private void SetData()
        {
            icon.sprite = product.item.explosive.icon;
            title.text = product.item.explosive.title;
            description.text = product.item.explosive.description;

            SetLimitAndPriceText();
        }

        private void SetLimitAndPriceText()
        {
            limit.text = product.item.limit.ToString();
            price.text = product.GetPrice().ToString() + product.currency.symbolString;
        }
    }
}