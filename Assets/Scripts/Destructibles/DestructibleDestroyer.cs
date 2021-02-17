using UnityEngine;

public class DestructibleDestroyer : MonoBehaviour
{
	[SerializeField] private float minimumTimer = 0.5f;
	[SerializeField] private float maximumTimer = 4f;

	public void OnEnable()
	{
		Destroy(gameObject, Random.Range(minimumTimer, maximumTimer));
	}
}