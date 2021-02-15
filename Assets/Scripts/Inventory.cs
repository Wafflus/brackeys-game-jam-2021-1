using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Artistas
{
	[System.Serializable]
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

		// Is awaken the best method for this?
		public void Awake()
		{
			for (int i = 0; i < inspectorItemList.Length; ++i)
			{
				items[inspectorItemList[i].item] = inspectorItemList[i].initialQuantity;
			}
		}

		public void AddItem(DummyItemSO newItem, int quantity)
		{
			items[newItem] = quantity;
		}

		public bool RemoveItem(DummyItemSO item)
		{
			return items.Remove(item);
		}

		public bool HasItem(DummyItemSO item)
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

		public bool IncreaseQuantity(DummyItemSO item, int quantity)
		{
			if (!items.ContainsKey(item))
			{
				return false;
			}

			items[item] += quantity;

			return true;
		}

		public bool DecreaseQuantity(DummyItemSO item, int quantity)
		{
			if (!items.ContainsKey(item))
			{
				return false;
			}

			items[item] -= quantity;

			return true;
		}
	}
}