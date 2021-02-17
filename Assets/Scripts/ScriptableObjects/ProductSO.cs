using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Product", menuName = "Artistas/Shop/New Product")]
	public class ProductSO : ScriptableObject
	{
		public DummyItemSO item;
		public int basePrice;
		public float priceModifier;
		public int timesPurchased;

		public int GetPrice()
		{
			return (int)Mathf.Ceil(basePrice * Mathf.Pow(priceModifier, timesPurchased)); // A different formula might be used.
		}
	}
}