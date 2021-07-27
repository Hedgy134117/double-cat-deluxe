// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""WASDPlayer"",
            ""id"": ""197b4d27-6543-4aef-abfd-07cbb56bbd43"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""b49b5bcf-0e79-44f7-95fa-7c6ed4f4b3cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8d181522-9a7d-444b-a1ac-8b51e09f79df"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""57bd1c4e-2654-4ef0-86f4-31bd962209dd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7a18b957-80a6-4b6d-a7af-4e69d6f2986c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4f3ce6e1-d2e9-42fa-b0fe-187083b6804a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9fb499b4-9167-45fe-a2a8-547887cf1206"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ARROWSPlayer"",
            ""id"": ""a38940b3-d46a-4450-ad1c-d149127b4253"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""7e312e10-2b71-4eb1-b933-13503e74fcc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ARROWS"",
                    ""id"": ""c7977529-75aa-4622-896b-13a05bd86d58"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""201bf855-4277-4590-a0b2-c1318adee138"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""edec31a6-3876-44f4-ad90-4b80512beb8d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""770c1543-bdbf-45a7-aeeb-7d6337ac4ee8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd66e972-308f-4320-93f3-0fdcae023738"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UHJKPlayer"",
            ""id"": ""c8f5934b-a52c-4c56-a9c0-a64ead30649c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""4d41b16e-b972-4133-b02f-e3507120fdd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ARROWS"",
                    ""id"": ""a4825747-8830-4455-9bd9-58447d40d3ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""95569177-455a-465d-a8ea-22d8574b6f2e"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5e15ddc7-a686-4730-a4ca-9b9e12d404c0"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4ed43445-0478-4c6a-975c-06349188665c"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b3e0e96e-b967-4468-a668-e7d84dc8768b"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // WASDPlayer
        m_WASDPlayer = asset.FindActionMap("WASDPlayer", throwIfNotFound: true);
        m_WASDPlayer_Movement = m_WASDPlayer.FindAction("Movement", throwIfNotFound: true);
        // ARROWSPlayer
        m_ARROWSPlayer = asset.FindActionMap("ARROWSPlayer", throwIfNotFound: true);
        m_ARROWSPlayer_Movement = m_ARROWSPlayer.FindAction("Movement", throwIfNotFound: true);
        // UHJKPlayer
        m_UHJKPlayer = asset.FindActionMap("UHJKPlayer", throwIfNotFound: true);
        m_UHJKPlayer_Movement = m_UHJKPlayer.FindAction("Movement", throwIfNotFound: true);
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

    // WASDPlayer
    private readonly InputActionMap m_WASDPlayer;
    private IWASDPlayerActions m_WASDPlayerActionsCallbackInterface;
    private readonly InputAction m_WASDPlayer_Movement;
    public struct WASDPlayerActions
    {
        private @InputMaster m_Wrapper;
        public WASDPlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_WASDPlayer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_WASDPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WASDPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IWASDPlayerActions instance)
        {
            if (m_Wrapper.m_WASDPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WASDPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WASDPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WASDPlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_WASDPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public WASDPlayerActions @WASDPlayer => new WASDPlayerActions(this);

    // ARROWSPlayer
    private readonly InputActionMap m_ARROWSPlayer;
    private IARROWSPlayerActions m_ARROWSPlayerActionsCallbackInterface;
    private readonly InputAction m_ARROWSPlayer_Movement;
    public struct ARROWSPlayerActions
    {
        private @InputMaster m_Wrapper;
        public ARROWSPlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ARROWSPlayer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_ARROWSPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ARROWSPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IARROWSPlayerActions instance)
        {
            if (m_Wrapper.m_ARROWSPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ARROWSPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ARROWSPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ARROWSPlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_ARROWSPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public ARROWSPlayerActions @ARROWSPlayer => new ARROWSPlayerActions(this);

    // UHJKPlayer
    private readonly InputActionMap m_UHJKPlayer;
    private IUHJKPlayerActions m_UHJKPlayerActionsCallbackInterface;
    private readonly InputAction m_UHJKPlayer_Movement;
    public struct UHJKPlayerActions
    {
        private @InputMaster m_Wrapper;
        public UHJKPlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_UHJKPlayer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_UHJKPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UHJKPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IUHJKPlayerActions instance)
        {
            if (m_Wrapper.m_UHJKPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_UHJKPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_UHJKPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_UHJKPlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_UHJKPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public UHJKPlayerActions @UHJKPlayer => new UHJKPlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IWASDPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IARROWSPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IUHJKPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
