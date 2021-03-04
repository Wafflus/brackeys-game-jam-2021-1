// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Artistas
{
    public class @PlayerInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2f361f31-fce9-49fa-b2ca-1cea67b62323"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2c6dcc0c-c04b-4c64-9da8-003652142bad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""44301329-2d75-4236-9a44-287cc2ecd50a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b21d035d-9550-493a-9d60-a761da3ad2ab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""ef6b8541-8b35-4596-af81-7c310afd5175"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""a09f239a-8307-473c-8ab4-bfe1a8d69411"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlaceItem"",
                    ""type"": ""Button"",
                    ""id"": ""ad00b302-166f-415f-9c5e-19b9fd126bf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerBomb"",
                    ""type"": ""Button"",
                    ""id"": ""149646af-9a89-4404-bd44-0b7c6134dca7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerCleaner"",
                    ""type"": ""Button"",
                    ""id"": ""4b6e3659-b4d3-4ce7-b489-7d3a457a0926"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keys"",
                    ""id"": ""7849a3bd-8d84-49e6-985a-e05f8738196b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6bfbae79-2c90-421e-b64b-b6cc91b4ed1c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""040f1f60-cc70-4f2d-bca2-32bb5e666870"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""76d9276c-fd59-4f60-9cbe-97fc0a47b78a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""10b61a91-4d48-418a-87f4-ab50a2896f10"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8a3d7455-8626-4296-8f00-2fbeb2668b78"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""759d7e91-8ecd-4c2e-b61e-9def4b8b30e9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faca2d10-df22-4332-8b62-8cca443df8f6"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f1b6cfc-6010-4c1f-964f-3cd9d9335d10"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""465ac363-abcc-4c01-b0c0-a7d3bc52cc78"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a99f0127-c735-4ffe-924d-7ed9c68ba9de"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerBomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e38ef4b-a8e3-4855-9f65-59f0c3f3b274"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerCleaner"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
            m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
            m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
            m_Player_PlaceItem = m_Player.FindAction("PlaceItem", throwIfNotFound: true);
            m_Player_TriggerBomb = m_Player.FindAction("TriggerBomb", throwIfNotFound: true);
            m_Player_TriggerCleaner = m_Player.FindAction("TriggerCleaner", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Look;
        private readonly InputAction m_Player_Sprint;
        private readonly InputAction m_Player_Crouch;
        private readonly InputAction m_Player_PlaceItem;
        private readonly InputAction m_Player_TriggerBomb;
        private readonly InputAction m_Player_TriggerCleaner;
        public struct PlayerActions
        {
            private @PlayerInputActions m_Wrapper;
            public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @Look => m_Wrapper.m_Player_Look;
            public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
            public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
            public InputAction @PlaceItem => m_Wrapper.m_Player_PlaceItem;
            public InputAction @TriggerBomb => m_Wrapper.m_Player_TriggerBomb;
            public InputAction @TriggerCleaner => m_Wrapper.m_Player_TriggerCleaner;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                    @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                    @PlaceItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceItem;
                    @PlaceItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceItem;
                    @PlaceItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceItem;
                    @TriggerBomb.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriggerBomb;
                    @TriggerBomb.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriggerBomb;
                    @TriggerBomb.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriggerBomb;
                    @TriggerCleaner.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriggerCleaner;
                    @TriggerCleaner.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriggerCleaner;
                    @TriggerCleaner.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriggerCleaner;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                    @Crouch.started += instance.OnCrouch;
                    @Crouch.performed += instance.OnCrouch;
                    @Crouch.canceled += instance.OnCrouch;
                    @PlaceItem.started += instance.OnPlaceItem;
                    @PlaceItem.performed += instance.OnPlaceItem;
                    @PlaceItem.canceled += instance.OnPlaceItem;
                    @TriggerBomb.started += instance.OnTriggerBomb;
                    @TriggerBomb.performed += instance.OnTriggerBomb;
                    @TriggerBomb.canceled += instance.OnTriggerBomb;
                    @TriggerCleaner.started += instance.OnTriggerCleaner;
                    @TriggerCleaner.performed += instance.OnTriggerCleaner;
                    @TriggerCleaner.canceled += instance.OnTriggerCleaner;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnPlaceItem(InputAction.CallbackContext context);
            void OnTriggerBomb(InputAction.CallbackContext context);
            void OnTriggerCleaner(InputAction.CallbackContext context);
        }
    }
}
