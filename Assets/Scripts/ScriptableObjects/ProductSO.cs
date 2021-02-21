using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Product", menuName = "Artistas/Shop/New Product")]
	public class ProductSO : ScriptableObject
	{
		public ItemSO item;
		public CurrencySO currency;
		public int basePrice;
		public int priceIncrease;
		public int timesPurchased;

		public int GetPrice()
		{
			return basePrice + timesPurchased * priceIncrease;
		}
	}
}