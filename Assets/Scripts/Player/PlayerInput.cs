using UnityEngine;

namespace Artistas
{
    public class PlayerInput : MonoBehaviour
    {
        public PlayerInputActions InputActions { get; private set; }

        private void Awake()
        {
            InputActions = new PlayerInputActions();

            Cursor.lockState = CursorLockMode.Locked;
            Screen.fullScreen = true;
        }

        private void OnEnable()
        {
            InputActions.Enable();
        }

        private void OnDisable()
        {
            InputActions.Disable();
        }

        public Vector2 GetPlayerMovement()
        {
            return InputActions.Player.Move.ReadValue<Vector2>();
        }

        public Vector2 GetMouseDelta()
        {
            return InputActions.Player.Look.ReadValue<Vector2>();
        }

        public bool Jumped()
        {
            return InputActions.Player.Jump.triggered;
        }
    }
}