using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New List", menuName = "Artistas/Sounds/New Sound List")]
	public class SoundListSO : ScriptableObject
	{
		public AudioClip[] sounds;

		public AudioClip GetRandomSound()
		{
			return sounds[Random.Range(0, sounds.Length)];
		}
	}
}