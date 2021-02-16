using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Artistas
{
	[Serializable]
	struct InspectorItemListEntry
	{
		public DummyItemSO item;
		public int initialQuantity;
	}

	public class Inventory : MonoBehaviour
	{
		private Dictionary<DummyItemSO, int> items;

		[SerializeField]
		private InspectorItemListEntry[] inspectorItemList; // Used to add initial values using the inspector.

		// Might not be the best method for this initialization.
		public void Awake()
		{
			items = new Dictionary<DummyItemSO, int>();

			for (int i = 0; i < inspectorItemList.Length; ++i)
			{
				items[inspectorItemList[i].item] = inspectorItemList[i].initialQuantity;
			}
		}

		// If the item already exists in the inventory, the quantity is added to it.
		// It returns true if the item was added as a new element in the dictionary.
		public bool AddItem(DummyItemSO newItem, int quantity)
		{
			if (items.ContainsKey(newItem))
			{
				items[newItem] += quantity;

				return false;
			}

			items[newItem] = quantity;

			return true;
		}

		public bool RemoveItem(DummyItemSO item)
		{
			return items.Remove(item);
		}

		public bool ContainsItem(DummyItemSO item)
		{
			return items.ContainsKey(item);
		}

		// Uses the same name convention as the dictionary method.
		public bool TryGetQuantity(DummyItemSO item, out int quantity)
		{
			return items.TryGetValue(item, out quantity);
		}

		public bool SetQuantity(DummyItemSO item, int newQuantity)
		{
			if (!items.ContainsKey(item))
			{
				return false;
			}

			items[item] = newQuantity;

			return true;
		}

		// Returns false if the quantity was not changed.
		public bool IncreaseQuantity(DummyItemSO item, int quantity)
		{
			if (!items.ContainsKey(item) || quantity < 0)
			{
				return false;
			}

			items[item] += quantity;

			return true;
		}

		// Returns false if the quantity was not changed.
		public bool DecreaseQuantity(DummyItemSO item, int quantity)
		{
			if (!items.ContainsKey(item) || quantity < 0)
			{
				return false;
			}

			items[item] -= quantity;

			return true;
		}
	}
}