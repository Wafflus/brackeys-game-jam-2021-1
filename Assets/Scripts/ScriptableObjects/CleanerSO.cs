using System.Collections.Generic;
using UnityEngine;

namespace Artistas
{
    [CreateAssetMenu(fileName = "New Item Cleaner", menuName = "Artistas/Cleaner/New Item Cleaner")]
    public class CleanerSO : ScriptableObject
    {
        [Header("References")]
        public InventorySO inventory;

        public Dictionary<GameObject, ItemSO> spawnedItems = new Dictionary<GameObject, ItemSO>();

        public void Add(ItemSO item, GameObject instantiatedItem)
        {
            if (spawnedItems.ContainsKey(instantiatedItem))
            {
                return;
            }

            spawnedItems.Add(instantiatedItem, item);
        }

        public void Remove(GameObject instantiatedItem)
        {
            if (!spawnedItems.ContainsKey(instantiatedItem))
            {
                return;
            }

            spawnedItems.Remove(instantiatedItem);
        }

        public void Clean()
        {
            foreach (KeyValuePair<GameObject, ItemSO> spawnedItem in spawnedItems)
            {
                inventory.AddItem(spawnedItem.Value, 1);

                Destroy(spawnedItem.Key);
            }

            spawnedItems.Clear();
        }
    }
}