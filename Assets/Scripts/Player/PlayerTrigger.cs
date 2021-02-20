using UnityEngine;

namespace Artistas
{
	public class PlayerTrigger : MonoBehaviour
	{
		[SerializeField] private GameEventSO OnBombTrigger;

		private PlayerInput input;

		public void Update()
		{
			TriggerBomb();
		}

		public void Initialize(PlayerInput playerInput)
		{
			input = playerInput;
		}

		private void TriggerBomb()
		{
			if (input.TriggerBomb())
			{
				OnBombTrigger.Raise();
			}
		}
	}
}