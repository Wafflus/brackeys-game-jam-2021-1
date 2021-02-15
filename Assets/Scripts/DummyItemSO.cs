// This is a temporary file.
using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Item", menuName = "Artistas/Items/New Item")]
	public class DummyItemSO : ScriptableObject
	{
		public string dummyName;
		public GameObject dummyObject;
	}
}