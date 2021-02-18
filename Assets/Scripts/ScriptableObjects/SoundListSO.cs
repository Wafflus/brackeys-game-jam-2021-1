using UnityEngine;

namespace Artistas
{
	[CreateAssetMenu(fileName = "New Sound List", menuName = "Artistas/Sounds/New Sound List")]
	public class SoundListSO : ScriptableObject
	{
		public AudioClip[] sounds;

		public AudioClip GetRandomSound()
		{
			int randomSoundIndex = Random.Range(0, sounds.Length);

			return sounds[randomSoundIndex];
		}
	}
}