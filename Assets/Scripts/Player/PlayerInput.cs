using Cinemachine;
using System;
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
            Unlock();
        }

        private void OnDisable()
        {
            Lock();
        }

        public void Lock()
        {
            InputActions.Disable();

            Cursor.lockState = CursorLockMode.None;
        }

        public void Unlock()
        {
            InputActions.Enable();

            Cursor.lockState = CursorLockMode.Locked;
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

        public float GetPlayerJumpHold()
        {
            return InputActions.Player.Jump.ReadValue<float>();
        }

        public float GetPlayerSprint()
        {
            return InputActions.Player.Sprint.ReadValue<float>();
        }

        public bool PlayerCrouched()
        {
            return InputActions.Player.Crouch.triggered;
        }

        public float GetPlayerCrouch()
        {
            return InputActions.Player.Crouch.ReadValue<float>();
        }

        public void OnPlayerCrouchCancel(Action action)
        {
            InputActions.Player.Crouch.canceled += context => action();
        }

        public bool PlacedItem()
        {
            return InputActions.Player.PlaceItem.triggered;
        }

        public bool TriggerBomb()
        {
            return InputActions.Player.TriggerBomb.triggered;
        }
    }
}