using UnityEngine;
using UnityEngine.UI;

namespace Artistas
{
	public class CurrentProgress : MonoBehaviour
	{
		[SerializeField] Slider progressSlider;

		[SerializeField] GameEventSO OnAllDestructiblesDestructed;

		private int destructibleCount = 0;
		private int currentDestructibleCount = 0;

		public void IncreaseDestructibleCount()
		{
			++destructibleCount;
			++currentDestructibleCount;

			UpdateProgress();
		}

		public void DecreaseCurrentDestructibleCount()
		{
			--currentDestructibleCount;

			UpdateProgress();

			if (destructibleCount == 0)
			{
				return;
			}

			if (currentDestructibleCount == 0)
			{
				OnAllDestructiblesDestructed.Raise();
			}
		}

		public void UpdateProgress()
		{
			if (destructibleCount == 0)
			{
				return;
			}

			progressSlider.value = (float)(destructibleCount - currentDestructibleCount) / (float)destructibleCount;
		}
	}
}