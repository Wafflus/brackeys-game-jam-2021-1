using UnityEngine;
using UnityEngine.Events;

namespace Artistas
{
    public abstract class GenericEventListenerTemplate<T> : MonoBehaviour, IEventListener<T>
    {
        public abstract GenericEventTemplate<T> Event { get; set; }
        public abstract UnityEvent<T> Response { get; set; }

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T value)
        {
            Response.Invoke(value);
        }
    }
}
