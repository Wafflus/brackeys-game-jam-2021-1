using UnityEngine;

namespace Artistas
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerItemPlacement))]
    public class PlayerController : MonoBehaviour
    {
        private CharacterController controller;
        private PlayerInput input;
        private PlayerMovement movement;
        private PlayerItemPlacement itemPlacement;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            input = GetComponent<PlayerInput>();
            movement = GetComponent<PlayerMovement>();
            itemPlacement = GetComponent<PlayerItemPlacement>();
        }

        private void Start()
        {
            movement.Initialize(controller, input);
            itemPlacement.Initialize(input);
        }
    }
}