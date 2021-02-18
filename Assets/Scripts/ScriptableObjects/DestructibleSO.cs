using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Destructible", menuName = "Artistas/Destructibles/New Destructible")]
	public class DestructibleSO : ScriptableObject
	{
		public float maxHP;
		public float healingFactor;
		public int reward;
	}
}