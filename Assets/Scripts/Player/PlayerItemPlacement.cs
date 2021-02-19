using UnityEngine;

namespace Artistas
{
	public class PlayerItemPlacement : MonoBehaviour
	{
		[SerializeField] private Placer itemPlacer;

		private PlayerInput input;

		public void Update()
		{
			PlaceItem();
		}

		public void Initialize(PlayerInput playerInput)
		{
			input = playerInput;
		}

		private void PlaceItem()
		{
			if (input.PlacedItem())
			{
				itemPlacer.PlaceItem();
			}
		}
	}
}