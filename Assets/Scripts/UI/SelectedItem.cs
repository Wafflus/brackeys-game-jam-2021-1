using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Artistas
{
    public class SelectedItem : MonoBehaviour
    {
        [SerializeField] private ItemSO item;
        [SerializeField] private InventorySO inventory;

        [Header("UI")]
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI limit;

        private void Awake()
        {
            SetData();
        }

        public void Select(ItemSO newItem)
        {
            item = newItem;

            SetData();
        }

        private void SetData()
        {
            icon.sprite = item.explosive.icon;

            SetLimit();
        }

        public void SetLimit()
        {
            inventory.TryGetQuantity(item, out int itemQuantity);

            limit.text = itemQuantity.ToString() + "/" + item.limit.ToString();
        }

        public void BombExplosionHandling(ItemSO explodingItem)
        {
            if (explodingItem == item)
            {
                SetLimit();
            }
        }
    }
}