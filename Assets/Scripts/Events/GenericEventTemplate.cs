using System.Collections.Generic;
using UnityEngine;

namespace Artistas
{
    public class GenericEventTemplate<T> : ScriptableObject
    {
        private readonly List<IEventListener<T>> eventListeners = new List<IEventListener<T>>();

        public void Raise(T value)
        {
            for (int i = eventListeners.Count - 1; i >= 0; --i)
            {
                eventListeners[i].OnEventRaised(value);
            }
        }

        public void RegisterListener(GenericEventListenerTemplate<T> listener)
        {
            if (eventListeners.Contains(listener))
            {
                return;
            }

            eventListeners.Add(listener);
        }

        public void UnregisterListener(GenericEventListenerTemplate<T> listener)
        {
            if (!eventListeners.Contains(listener))
            {
                return;
            }

            eventListeners.Remove(listener);
        }
    }
}