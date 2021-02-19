// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/HotbarInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Artistas
{
    public class @HotbarInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @HotbarInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""HotbarInputActions"",
    ""maps"": [
        {
            ""name"": ""Window"",
            ""id"": ""a9f043f8-1196-4d3d-9b93-73c49372ae16"",
            ""actions"": [
                {
                    ""name"": ""Shop"",
                    ""type"": ""Button"",
                    ""id"": ""bd49bd03-ddbb-490a-950e-32a34113cd2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""036d9bd4-d13b-4d05-aea9-bc3874e46b84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""22425a22-c2ec-4b7b-8e6f-bb2c74d0461c"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db5d3d8d-4d30-4925-bbdf-4afe296857fa"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Explosives"",
            ""id"": ""0f78984d-2d4b-40f5-a2b2-241407aaddc2"",
            ""actions"": [
                {
                    ""name"": ""Barrel"",
                    ""type"": ""Button"",
                    ""id"": ""df9829d3-bec4-4e3c-beed-4cb6a90e78de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gas"",
                    ""type"": ""Button"",
                    ""id"": ""f711c60c-f6c1-430f-93da-411613bc62f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Box"",
                    ""type"": ""Button"",
                    ""id"": ""97de45ca-d00a-4863-8ef5-15e5da0bbcff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6fb70047-99ec-4212-b623-f5d880803089"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Barrel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac9301a4-fa3c-49b6-995f-c9037ba94263"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e9b98ed-ca34-4246-8831-42aac940528d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Box"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Detonator"",
            ""id"": ""0273f60e-2ec7-42f2-bc8c-47e2f062fcbc"",
            ""actions"": [
                {
                    ""name"": ""Explosive"",
                    ""type"": ""Button"",
                    ""id"": ""e9c972b4-144b-48d4-9a0c-69b620910549"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button"",
                    ""type"": ""Button"",
                    ""id"": ""7d6dffe5-2acc-4760-807c-2141e765ec1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a86a2d6-d877-4ad7-9ef1-7422991ede29"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Explosive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53b635e4-9d65-4af5-aa73-fbd92910d224"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Window
            m_Window = asset.FindActionMap("Window", throwIfNotFound: true);
            m_Window_Shop = m_Window.FindAction("Shop", throwIfNotFound: true);
            m_Window_Menu = m_Window.FindAction("Menu", throwIfNotFound: true);
            // Explosives
            m_Explosives = asset.FindActionMap("Explosives", throwIfNotFound: true);
            m_Explosives_Barrel = m_Explosives.FindAction("Barrel", throwIfNotFound: true);
            m_Explosives_Gas = m_Explosives.FindAction("Gas", throwIfNotFound: true);
            m_Explosives_Box = m_Explosives.FindAction("Box", throwIfNotFound: true);
            // Detonator
            m_Detonator = asset.FindActionMap("Detonator", throwIfNotFound: true);
            m_Detonator_Explosive = m_Detonator.FindAction("Explosive", throwIfNotFound: true);
            m_Detonator_Button = m_Detonator.FindAction("Button", throwIfNotFound: true);
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

        // Window
        private readonly InputActionMap m_Window;
        private IWindowActions m_WindowActionsCallbackInterface;
        private readonly InputAction m_Window_Shop;
        private readonly InputAction m_Window_Menu;
        public struct WindowActions
        {
            private @HotbarInputActions m_Wrapper;
            public WindowActions(@HotbarInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Shop => m_Wrapper.m_Window_Shop;
            public InputAction @Menu => m_Wrapper.m_Window_Menu;
            public InputActionMap Get() { return m_Wrapper.m_Window; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(WindowActions set) { return set.Get(); }
            public void SetCallbacks(IWindowActions instance)
            {
                if (m_Wrapper.m_WindowActionsCallbackInterface != null)
                {
                    @Shop.started -= m_Wrapper.m_WindowActionsCallbackInterface.OnShop;
                    @Shop.performed -= m_Wrapper.m_WindowActionsCallbackInterface.OnShop;
                    @Shop.canceled -= m_Wrapper.m_WindowActionsCallbackInterface.OnShop;
                    @Menu.started -= m_Wrapper.m_WindowActionsCallbackInterface.OnMenu;
                    @Menu.performed -= m_Wrapper.m_WindowActionsCallbackInterface.OnMenu;
                    @Menu.canceled -= m_Wrapper.m_WindowActionsCallbackInterface.OnMenu;
                }
                m_Wrapper.m_WindowActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Shop.started += instance.OnShop;
                    @Shop.performed += instance.OnShop;
                    @Shop.canceled += instance.OnShop;
                    @Menu.started += instance.OnMenu;
                    @Menu.performed += instance.OnMenu;
                    @Menu.canceled += instance.OnMenu;
                }
            }
        }
        public WindowActions @Window => new WindowActions(this);

        // Explosives
        private readonly InputActionMap m_Explosives;
        private IExplosivesActions m_ExplosivesActionsCallbackInterface;
        private readonly InputAction m_Explosives_Barrel;
        private readonly InputAction m_Explosives_Gas;
        private readonly InputAction m_Explosives_Box;
        public struct ExplosivesActions
        {
            private @HotbarInputActions m_Wrapper;
            public ExplosivesActions(@HotbarInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Barrel => m_Wrapper.m_Explosives_Barrel;
            public InputAction @Gas => m_Wrapper.m_Explosives_Gas;
            public InputAction @Box => m_Wrapper.m_Explosives_Box;
            public InputActionMap Get() { return m_Wrapper.m_Explosives; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ExplosivesActions set) { return set.Get(); }
            public void SetCallbacks(IExplosivesActions instance)
            {
                if (m_Wrapper.m_ExplosivesActionsCallbackInterface != null)
                {
                    @Barrel.started -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnBarrel;
                    @Barrel.performed -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnBarrel;
                    @Barrel.canceled -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnBarrel;
                    @Gas.started -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnGas;
                    @Gas.performed -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnGas;
                    @Gas.canceled -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnGas;
                    @Box.started -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnBox;
                    @Box.performed -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnBox;
                    @Box.canceled -= m_Wrapper.m_ExplosivesActionsCallbackInterface.OnBox;
                }
                m_Wrapper.m_ExplosivesActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Barrel.started += instance.OnBarrel;
                    @Barrel.performed += instance.OnBarrel;
                    @Barrel.canceled += instance.OnBarrel;
                    @Gas.started += instance.OnGas;
                    @Gas.performed += instance.OnGas;
                    @Gas.canceled += instance.OnGas;
                    @Box.started += instance.OnBox;
                    @Box.performed += instance.OnBox;
                    @Box.canceled += instance.OnBox;
                }
            }
        }
        public ExplosivesActions @Explosives => new ExplosivesActions(this);

        // Detonator
        private readonly InputActionMap m_Detonator;
        private IDetonatorActions m_DetonatorActionsCallbackInterface;
        private readonly InputAction m_Detonator_Explosive;
        private readonly InputAction m_Detonator_Button;
        public struct DetonatorActions
        {
            private @HotbarInputActions m_Wrapper;
            public DetonatorActions(@HotbarInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Explosive => m_Wrapper.m_Detonator_Explosive;
            public InputAction @Button => m_Wrapper.m_Detonator_Button;
            public InputActionMap Get() { return m_Wrapper.m_Detonator; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DetonatorActions set) { return set.Get(); }
            public void SetCallbacks(IDetonatorActions instance)
            {
                if (m_Wrapper.m_DetonatorActionsCallbackInterface != null)
                {
                    @Explosive.started -= m_Wrapper.m_DetonatorActionsCallbackInterface.OnExplosive;
                    @Explosive.performed -= m_Wrapper.m_DetonatorActionsCallbackInterface.OnExplosive;
                    @Explosive.canceled -= m_Wrapper.m_DetonatorActionsCallbackInterface.OnExplosive;
                    @Button.started -= m_Wrapper.m_DetonatorActionsCallbackInterface.OnButton;
                    @Button.performed -= m_Wrapper.m_DetonatorActionsCallbackInterface.OnButton;
                    @Button.canceled -= m_Wrapper.m_DetonatorActionsCallbackInterface.OnButton;
                }
                m_Wrapper.m_DetonatorActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Explosive.started += instance.OnExplosive;
                    @Explosive.performed += instance.OnExplosive;
                    @Explosive.canceled += instance.OnExplosive;
                    @Button.started += instance.OnButton;
                    @Button.performed += instance.OnButton;
                    @Button.canceled += instance.OnButton;
                }
            }
        }
        public DetonatorActions @Detonator => new DetonatorActions(this);
        public interface IWindowActions
        {
            void OnShop(InputAction.CallbackContext context);
            void OnMenu(InputAction.CallbackContext context);
        }
        public interface IExplosivesActions
        {
            void OnBarrel(InputAction.CallbackContext context);
            void OnGas(InputAction.CallbackContext context);
            void OnBox(InputAction.CallbackContext context);
        }
        public interface IDetonatorActions
        {
            void OnExplosive(InputAction.CallbackContext context);
            void OnButton(InputAction.CallbackContext context);
        }
    }
}
