using UnityEngine;

// This script should not exist.
namespace Artistas
{
	public class RotationCopier : MonoBehaviour
	{
		[SerializeField] private Transform source;
		[SerializeField] private Vector3 rotationModifier;

		public void Update()
		{
			Vector3 newRotation = source.rotation.eulerAngles;

			newRotation.x *= rotationModifier.x;
			newRotation.y *= rotationModifier.y;
			newRotation.z *= rotationModifier.z;

			transform.rotation = Quaternion.Euler(newRotation);
		}
	}
}