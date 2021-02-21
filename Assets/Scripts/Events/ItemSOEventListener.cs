using UnityEngine;
using UnityEngine.Events;

namespace Artistas
{
    public class ItemSOEventListener : GenericEventListenerTemplate<ItemSO>
    {
        [field: SerializeField] public override GenericEventTemplate<ItemSO> Event { get; set; }
        [field: SerializeField] public override UnityEvent<ItemSO> Response { get; set; }
    }
}