using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Destructible", menuName = "Artistas/Destructibles/New Destructible")]
	public class DestructibleSO : ScriptableObject
	{
		public float maxHP;
		public float healingFactor;
		public int reward;
		public CurrencySO currency;
		public GameEventSO OnDestructibleDestruction;

		public void AddReward()
		{
			currency.Add(reward);
		}
	}
}