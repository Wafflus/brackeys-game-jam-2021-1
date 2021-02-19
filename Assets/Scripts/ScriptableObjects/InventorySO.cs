using System;
using System.Collections.Generic;
using UnityEngine;

namespace Artistas
{
	[Serializable]
	struct InspectorItemListEntry
	{
		public ItemSO item;
		public int initialQuantity;
	}

	[CreateAssetMenu(fileName = "New Inventory", menuName = "Artistas/Inventory/New Inventory")]
	public class InventorySO : ScriptableObject
	{
		private Dictionary<ItemSO, int> items;

		// Used to add initial values using the inspector.
		[SerializeField] private InspectorItemListEntry[] inspectorItemList;

		public void OnEnable()
		{
			items = new Dictionary<ItemSO, int>();

			for (int i = 0; i < inspectorItemList.Length; ++i)
			{
				items[inspectorItemList[i].item] = inspectorItemList[i].initialQuantity;
			}
		}

		public bool AddItem(ItemSO newItem, int quantity)
		{
			if (ContainsItem(newItem))
			{
				items[newItem] += quantity;

				return false;
			}

			items[newItem] = quantity;

			return true;
		}

		public bool RemoveItem(ItemSO item)
		{
			return items.Remove(item);
		}

		public bool ContainsItem(ItemSO item)
		{
			return items.ContainsKey(item);
		}

		// Uses the same name convention as the dictionary method.
		public bool TryGetQuantity(ItemSO item, out int quantity)
		{
			return items.TryGetValue(item, out quantity);
		}

		public bool SetQuantity(ItemSO item, int newQuantity)
		{
			if (!ContainsItem(item))
			{
				return false;
			}

			items[item] = newQuantity;

			return true;
		}

		// Returns false if the quantity was not changed.
		public bool IncreaseQuantity(ItemSO item, int quantity)
		{
			if (!ContainsItem(item) || quantity < 0)
			{
				return false;
			}

			items[item] += quantity;

			return true;
		}

		// Returns false if the quantity was not changed.
		public bool DecreaseQuantity(ItemSO item, int quantity)
		{
			if (!ContainsItem(item) || quantity < 0)
			{
				return false;
			}

			items[item] -= quantity;

			return true;
		}
	}
}