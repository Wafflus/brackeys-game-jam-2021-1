using UnityEngine;
using System.Collections;

namespace Artistas
{
	public class RandomPopper : MonoBehaviour
	{
		[SerializeField] private float minTimer = 10f;
		[SerializeField] private float maxTimer = 1000f;

		[SerializeField] private GameObject popped;

		private float randomTimer;

		public void Start()
		{
			randomTimer = Random.Range(minTimer, maxTimer);

			StartCoroutine(EnableAtTimer());
		}

		private IEnumerator EnableAtTimer()
		{
			yield return new WaitForSeconds(randomTimer);

			popped.SetActive(true);
		}
	}
}