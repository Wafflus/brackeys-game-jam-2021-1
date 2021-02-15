using UnityEngine;

namespace Artistas
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerController : MonoBehaviour
    {
        private CharacterController controller;
        private PlayerInput input;
        private PlayerMovement movement;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            input = GetComponent<PlayerInput>();
            movement = GetComponent<PlayerMovement>();
        }

        private void Start()
        {
            movement.Initialize(controller, input);
        }
    }
}