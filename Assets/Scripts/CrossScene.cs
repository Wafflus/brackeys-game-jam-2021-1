using UnityEngine;

namespace Artistas
{
	public class CrossScene : MonoBehaviour
	{
		void Start()
		{
			DontDestroyOnLoad(gameObject);
		}
	}
}