using UnityEngine;
using UnityEngine.Events;

namespace Artistas
{
	public class Placer : MonoBehaviour
	{
		// This is temporary, it should be replaced when integrating it with the other systems.
		[SerializeField] private ItemSO item;
		[SerializeField] private Material allowedMaterial;
		[SerializeField] private Material blockedMaterial;

		[SerializeField] private InventorySO inventory;

		[SerializeField] private UnityEvent OnPlacement;

		private Collider previewCollider;
		private MeshRenderer previewRenderer;

		private bool preview;

		private int collisionCount = 0;

		public void EnablePreview()
		{
			preview = true;

			if (previewRenderer != null)
			{
				previewRenderer.enabled = true;
			}
		}

		public void DisablePreview()
		{
			preview = false;

			if (previewRenderer != null)
			{
				previewRenderer.enabled = false;
			}
		}

		public bool IsPreviewing()
		{
			return preview;
		}

		public bool CanPlace()
		{
			if (item == null)
			{
				return false;
			}

			// Quantity should never be less than 0.
			if (!inventory.TryGetQuantity(item, out int quantity) || quantity <= 0)
			{
				return false;
			}

			return collisionCount == 0;
		}

		public void SetItem(ItemSO newItem)
		{
			item = newItem;

			if (item == null)
			{
				ClearItem();

				return;
			}

			SetPreviewComponents();
		}

		public void ClearItem()
		{
			item = null;

			DisablePreview();
		}

		// This might manage the inventory quantities.
		public bool PlaceItem()
		{
			if (item == null)
			{
				return false;
			}

			if (!CanPlace())
			{
				return false;
			}

			inventory.DecreaseQuantity(item, 1);
			OnPlacement.Invoke();

			Instantiate(item.explosivePrefab, transform.position, transform.rotation);

			return true;
		}

		private void Awake()
		{
			previewRenderer = gameObject.GetComponent<MeshRenderer>();
		}

		private void OnTriggerEnter(Collider collider)
		{
			previewRenderer.material = blockedMaterial;
			++collisionCount;
		}

		private void OnTriggerExit(Collider collider)
		{
			previewRenderer.material = allowedMaterial;
			--collisionCount;
		}

		private void SetPreviewComponents()
		{
			if (item == null)
			{
				return;
			}

			gameObject.GetComponent<MeshFilter>().mesh = item.explosivePrefab.GetComponent<MeshFilter>().sharedMesh;

			previewRenderer.material = allowedMaterial;

			CreateColliderComponent();

			collisionCount = 0;
		}

		private void CreateColliderComponent()
		{
			if (item == null)
			{
				return;
			}

			if (previewCollider != null)
			{
				Destroy(GetComponent<Collider>());
			}

			// These checks are not very nice.
			if (item.explosivePrefab.GetComponent<Collider>().GetType() == typeof (BoxCollider))
			{
				BoxCollider itemBoxCollider = item.explosivePrefab.GetComponent<BoxCollider>();
				BoxCollider newCollider = gameObject.AddComponent<BoxCollider>() as BoxCollider;

				newCollider.center = itemBoxCollider.center;
				newCollider.size = itemBoxCollider.size;

				previewCollider = newCollider;
			}
			else if (item.explosivePrefab.GetComponent<Collider>().GetType() == typeof (SphereCollider))
			{
				SphereCollider itemSphereCollider = item.explosivePrefab.GetComponent<SphereCollider>();
				SphereCollider newCollider = gameObject.AddComponent<SphereCollider>() as SphereCollider;

				newCollider.center = itemSphereCollider.center;
				newCollider.radius = itemSphereCollider.radius;

				previewCollider = newCollider;
			}
			else if (item.explosivePrefab.GetComponent<Collider>().GetType() == typeof (CapsuleCollider))
			{
				CapsuleCollider itemCapsuleCollider = item.explosivePrefab.GetComponent<CapsuleCollider>();
				CapsuleCollider newCollider = gameObject.AddComponent<CapsuleCollider>() as CapsuleCollider;

				newCollider.center = itemCapsuleCollider.center;
				newCollider.radius = itemCapsuleCollider.radius;
				newCollider.height = itemCapsuleCollider.height;
				newCollider.direction = newCollider.direction;

				previewCollider = newCollider;
			}

			previewCollider.isTrigger = true;
		}
	}
}