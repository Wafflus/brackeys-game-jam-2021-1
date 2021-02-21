using UnityEngine;

namespace Artistas
{
	public class ImpactSound : MonoBehaviour
	{
		[SerializeField] private SoundListSO soundList;
		[SerializeField] private float minimumVelocityMagnitude = 2f;

		void OnCollisionEnter(Collision collision)
		{
			if (collision.relativeVelocity.magnitude >= minimumVelocityMagnitude)
			{
				// This might be changed to a single audio source.
				AudioSource.PlayClipAtPoint(soundList.GetRandomSound(), collision.transform.position, 1f);
			}
		}
	}
}