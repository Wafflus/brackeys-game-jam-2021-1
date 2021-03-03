using UnityEngine;

namespace Artistas
{
    public class PlayerMovement : MonoBehaviour
    {
        [field: Header("Movement")]
        [field: SerializeField] public float Speed { get; set; } = 25f;
        [field: SerializeField] public float SprintSpeedBonus { get; set; } = 5f;

        [field: Header("Jump")]
        [field: SerializeField] public float JumpHeight { get; set; } = 1f;
        [field: SerializeField] public float Gravity { get; set; } = -9.81f;

        [Header("Crouch")]
        [SerializeField] private float crouchHeightPercentage = .5f;
        [field: Range(0, 1)] [field: SerializeField] public float CrouchSpeedReduction { get; set; } = .5f;

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

            controller.Move(movement * (Speed + (moveFasterSpeed * input.GetPlayerSprint())) * Time.deltaTime);
        }

        private void Move()
        {
            Vector2 movementInput = input.GetPlayerMovement();

            Vector3 movement = cameraTransform.forward * movementInput.y + cameraTransform.right * movementInput.x;

            movement.y = 0f;

            float sprintSpeed = SprintSpeedBonus * input.GetPlayerSprint();
            float crouchSpeed = CrouchSpeedReduction * input.GetPlayerCrouch();
            float moveSpeed = Speed + sprintSpeed;

            controller.Move(movement * (moveSpeed - (moveSpeed * crouchSpeed)) * Time.deltaTime);
        }

        private void Jump()
        {
            if (input.Jumped() && grounded)
            {
                velocity.y += Mathf.Sqrt(JumpHeight * -3.0f * Gravity);
            }

            velocity.y += Gravity * Time.deltaTime;

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