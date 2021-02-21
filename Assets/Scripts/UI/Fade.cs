using UnityEngine;
using UnityEngine.Events;

namespace Artistas
{
    public class Fade : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnFadeFinish;

        public void OnFadeFinished()
        {
            OnFadeFinish.Invoke();
        }
    }
}