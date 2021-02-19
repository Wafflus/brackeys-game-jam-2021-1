using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Item", menuName = "Artistas/Items/New Item")]
	public class ItemSO : ScriptableObject
	{
		public ExplosiveSO explosive;
		public GameObject explosivePrefab;
		public int limit;
	}
}