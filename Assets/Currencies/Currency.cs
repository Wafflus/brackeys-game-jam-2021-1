using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Currency", menuName = "Artistas/Currency/New Currency")]
	public class Currency : ScriptableObject
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

		public void Add(int value)
		{
			amount += value;
		}

		public void Subtract(int value)
		{
			amount -= value;
		}

		// Returns true if the sum was not negative.
		public bool AddKeepNonNegative(int value)
		{
			if (this.HasAmount(value))
			{
				amount += value;

				return true;
			}

			amount = 0;

			return false;
		}

		// Returns true if the subtraction was not negative.
		public bool SubtractKeepNonNegative(int value)
		{
			if (this.HasAmount(value))
			{
				amount -= value;

				return true;
			}

			amount = 0;

			return false;
		}
	}
}