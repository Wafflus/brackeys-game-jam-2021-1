using UnityEngine;

namespace Artistas
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerItemPlacement))]
    [RequireComponent(typeof(PlayerTrigger))]
    public class PlayerController : MonoBehaviour
    {
        private CharacterController controller;
        private PlayerInput input;
        private PlayerMovement movement;
        private PlayerItemPlacement itemPlacement;
        private PlayerTrigger playerTrigger;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            input = GetComponent<PlayerInput>();
            movement = GetComponent<PlayerMovement>();
            itemPlacement = GetComponent<PlayerItemPlacement>();
            playerTrigger = GetComponent<PlayerTrigger>();
        }

        private void Start()
        {
            movement.Initialize(controller, input);

            itemPlacement.Initialize(input);
            itemPlacement.enabled = false;

            playerTrigger.Initialize(input);
            playerTrigger.enabled = false;
        }
    }
}