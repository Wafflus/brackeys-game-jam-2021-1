using UnityEngine;

namespace Artistas
{
	public class TruthController : MonoBehaviour
	{
		[SerializeField] Vector3 defaultVelocity;
		[SerializeField] Vector3 fastVelocity;
		[SerializeField] Vector3 rotationVelocity;

		bool flyingAway = false;

		public void Update()
		{
			Fly();
			Rotate();
		}

		public void OnTriggerEnter(Collider collider)
		{
			flyingAway = true;
		}

		private void Fly()
		{
			Vector3 currentSpeed;

			if (flyingAway)
			{
				currentSpeed = fastVelocity;
			}
			else
			{
				currentSpeed = defaultVelocity;
			}

			transform.Translate(currentSpeed * Time.deltaTime, Space.World);
		}

		private void Rotate()
		{
			transform.Rotate(rotationVelocity);
		}
	}
}