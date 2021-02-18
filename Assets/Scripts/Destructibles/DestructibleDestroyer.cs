using UnityEngine;

public class DestructibleDestroyer : MonoBehaviour
{
	[SerializeField] private float minimumTimer = 0.5f;
	[SerializeField] private float maximumTimer = 4f;

	public void OnEnable()
	{
		float randomTimer = Random.Range(minimumTimer, maximumTimer);

		Destroy(gameObject, randomTimer);
	}
}