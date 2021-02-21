using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Currency", menuName = "Artistas/Currency/New Currency")]
	public class CurrencySO : ScriptableObject
	{
		public string currencyName;
		public string pluralName;
		public string symbolString;
		public string description;
		public Sprite icon;

		public int amount = 0;

		public string GetName()
		{
			if (amount == -1 || amount == 1)
			{
				return currencyName;
			}

			return pluralName;
		}

		public bool HasAmount(int targetAmount)
		{
			return amount >= targetAmount;
		}

		public bool Add(int value)
		{
			if (value < 0)
			{
				return false;
			}

			amount += value;

			return true;
		}

		public bool Subtract(int value)
		{
			if (value < 0)
			{
				return false;
			}

			amount -= value;

			return true;
		}
	}
}