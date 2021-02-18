using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Shop", menuName = "Artistas/Shop/New Shop")]
	public class ShopSO : ScriptableObject
	{
		public CurrencySO currency;
		public InventorySO inventory;

		public void Buy(ProductSO product)
        {
			int price = product.GetPrice();

			if (!product.currency.HasAmount(product.GetPrice()))
			{
				return;
            }

			product.currency.Subtract(price);

			++product.item.limit;
			++product.timesPurchased;

			inventory.AddItem(product.item, 1);
		}
	}
}