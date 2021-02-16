using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Shop", menuName = "Artistas/Shop/New Shop")]
	public class ShopSO : ScriptableObject
	{
		public ProductSO[] products;
		public CurrencySO currency;
		public InventorySO inventory; // Possibly temporary.

		// Use of the products' array index might be temporary.
		public bool BuyProduct(int productIndex)
		{
			if (productIndex < 0 || productIndex >= products.Length)
			{
				return false;
			}

			ProductSO product = products[productIndex];
			int price = product.GetPrice();

			if (!currency.HasAmount(price))
			{
				return false;
			}

			currency.Subtract(price);
			inventory.AddItem(product.item, 1);
			++product.timesPurchased;

			return true;
		}
	}
}