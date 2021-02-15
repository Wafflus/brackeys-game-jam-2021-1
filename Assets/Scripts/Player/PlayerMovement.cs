using UnityEngine;

namespace Artistas
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float speed = 2f;

        [Header("Jump")]
        [SerializeField] private float height = 1f;
        [SerializeField] private float gravity = -9.81f;

        private Vector3 velocity;
        private bool grounded;

        private Transform cameraTransform;

        private CharacterController controller;
        private PlayerInput input;

        public void Initialize(CharacterController characterController, PlayerInput playerInput)
        {
            controller = characterController;
            input = playerInput;

            cameraTransform = Camera.main.transform;
        }

        private void Update()
        {
            grounded = controller.isGrounded;

            if (grounded && velocity.y < 0)
            {
                velocity.y = 0f;
            }

            Move();

            Jump();
        }

        private void Move()
        {
            Vector2 movementInput = input.GetPlayerMovement();

            Vector3 movement = cameraTransform.forward * movementInput.y + cameraTransform.right * movementInput.x;

            movement.y = 0f;

            controller.Move(movement * speed * Time.deltaTime);
        }

        private void Jump()
        {
            if (input.Jumped() && grounded)
            {
                velocity.y += Mathf.Sqrt(height * -3.0f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }
}