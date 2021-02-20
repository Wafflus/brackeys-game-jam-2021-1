using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Artistas
{
    public class HotbarButton : MonoBehaviour
    {
        [SerializeField] private InputActionReference actionReference;
        [SerializeField] private UnityEvent OnActionSelected;
        [SerializeField] private UnityEvent OnActionDeselected;

        [Header("UI")]
        [SerializeField] private TextMeshProUGUI key;
        [SerializeField] private Color keySelectedColor;
        [SerializeField] private Color keyDeselectedColor;

        private bool selected;

        private void Start()
        {
            actionReference.action.performed += context => OnActionPerformed();
        }

        private void OnEnable()
        {
            actionReference.action.Enable();
        }

        private void OnDisable()
        {
            actionReference.action.Disable();
        }

        public void InvokeOnActionSelected()
        {
            OnActionSelected.Invoke();
        }

        public void InvokeOnActionDeselected()
        {
            OnActionDeselected.Invoke();
        }

        private void OnActionPerformed()
        {
            if (!selected)
            {
                OnActionSelected.Invoke();

                return;
            }

            OnActionDeselected.Invoke();
        }

        public void Select()
        {
            selected = true;

            key.color = keySelectedColor;
        }

        public void Deselect()
        {
            selected = false;

            key.color = keyDeselectedColor;
        }
    }
}