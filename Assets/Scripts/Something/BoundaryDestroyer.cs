using UnityEngine;

namespace Artistas
{
	public class BoundaryDestroyer : MonoBehaviour
	{
		[SerializeField] private Vector3 minimumPoint;
		[SerializeField] private Vector3 maximumPoint;

		public void Update()
		{
			Vector3 currentPosition = transform.position;

			if (currentPosition.x < minimumPoint.x || currentPosition.y < minimumPoint.y || currentPosition.z < minimumPoint.z || currentPosition.x > maximumPoint.x || currentPosition.y > maximumPoint.y || currentPosition.z > maximumPoint.z)
			{
				Destroy(gameObject);
			}
		}
	}
}