using UnityEngine;
namespace Artistas
{
	public class ImpactSound : MonoBehaviour
	{
		[SerializeField] private SoundListSO soundList;
		[SerializeField] private float minimumVelocityMagnitude = 2f;

		private Rigidbody rigidBody;

		public void Awake()
		{
			rigidBody = gameObject.GetComponent<Rigidbody>();
		}

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