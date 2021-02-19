using UnityEngine;

namespace Artistas
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float speed = 25f;
        [SerializeField] private float sprintSpeedBonus = 5f;

        [Header("Jump")]
        [SerializeField] private float jumpHeight = 1f;
        [SerializeField] private float gravity = -9.81f;

        [Header("Crouch")]
        [SerializeField] private float crouchHeightPercentage = .5f;
        [SerializeField] private float crouchSpeedReduction = 10f;

        [Header("Free Camera")]
        [SerializeField] private bool goBackToPreviousPosition = true;
        [SerializeField] private float moveUpSpeed = 5f;
        [SerializeField] private float moveDownSpeed = 5f;
        [SerializeField] private float moveFasterSpeed = 5f;

        private Vector3 velocity;
        private bool grounded;

        private bool freeCamera;
        private Vector3 positionBeforeFreeCamera;

        private Transform cameraTransform;

        private CharacterController controller;
        private PlayerInput input;

        public void Initialize(CharacterController characterController, PlayerInput playerInput)
        {
            controller = characterController;
            input = playerInput;

            cameraTransform = Camera.main.transform;

            input.OnPlayerCrouchCancel(() =>
            {
                if (freeCamera)
                {
                    return;
                }

                controller.height /= crouchHeightPercentage;

                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
            });
        }

        private void Update()
        {
            Fly();

            if (freeCamera)
            {
                return;
            }

            grounded = controller.isGrounded;

            if (grounded && velocity.y < 0)
            {
                velocity.y = 0f;
            }

            Crouch();

            Move();

            Jump();
        }

        private void Crouch()
        {
            if (!input.PlayerCrouched() || freeCamera)
            {
                return;
            }

            controller.height *= crouchHeightPercentage;

            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
        }

        private void Fly()
        {
            if (!freeCamera)
            {
                return;
            }

            Vector2 movementInput = input.GetPlayerMovement();

            Vector3 movement = cameraTransform.forward * movementInput.y + cameraTransform.right * movementInput.x;

            movement.y += Mathf.Sqrt(moveUpSpeed * input.GetPlayerJumpHold() * Time.deltaTime);
            movement.y -= Mathf.Sqrt(moveDownSpeed * input.GetPlayerCrouch() * Time.deltaTime);

            controller.Move(movement * (speed + (moveFasterSpeed * input.GetPlayerSprint())) * Time.deltaTime);
        }

        private void Move()
        {
            Vector2 movementInput = input.GetPlayerMovement();

            Vector3 movement = cameraTransform.forward * movementInput.y + cameraTransform.right * movementInput.x;

            movement.y = 0f;

            float sprintSpeed = sprintSpeedBonus * input.GetPlayerSprint();
            float crouchSpeed = crouchSpeedReduction * input.GetPlayerCrouch();

            controller.Move(movement * (speed + sprintSpeed - crouchSpeed) * Time.deltaTime);
        }

        private void Jump()
        {
            if (input.Jumped() && grounded)
            {
                velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }

        public void SetCameraFree(bool free)
        {
            freeCamera = free;

            if (freeCamera)
            {
                positionBeforeFreeCamera = controller.transform.position;

                return;
            }

            if (!goBackToPreviousPosition)
            {
                return;
            }

            controller.enabled = false;
            controller.transform.position = positionBeforeFreeCamera;
            controller.enabled = true;
        }
    }
}