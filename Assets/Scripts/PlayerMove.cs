//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerMove : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMove()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player_Blue"",
            ""id"": ""68508c1f-7f01-4ac1-b0a2-bf57c042885a"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""c752d365-8252-4e30-b73e-2df78a1f11e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""a974614c-4601-4e1e-b0f9-e00660dc4e51"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""651628d9-efdd-4f59-9fad-53c72cbb6110"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7fac7a21-268a-40ec-80e4-237b82443c36"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0c90f67f-fed5-41c4-964a-4fbf194a3d91"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""df2369d1-59c2-41af-9659-40aa62e53ace"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player_Pink"",
            ""id"": ""0b4d9a12-8b59-417c-b493-e43b7d4e9b9c"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""a8a1df72-2308-4298-b866-690cb1618622"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""b71a6f94-b793-4961-8d5d-8ba06399fbdd"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""114c48d3-e765-4412-9ada-01856e91589c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""150118a2-d886-4283-b901-6a5978d67bd3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""543b96b1-7a91-4aa3-b3c9-9f4bd4289528"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""299c70c1-4a0c-4455-814c-bb3ebc5ac0be"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // Player_Blue
        m_Player_Blue = asset.FindActionMap("Player_Blue", throwIfNotFound: true);
        m_Player_Blue_HorizontalMovement = m_Player_Blue.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_Player_Blue_Jump = m_Player_Blue.FindAction("Jump", throwIfNotFound: true);
        // Player_Pink
        m_Player_Pink = asset.FindActionMap("Player_Pink", throwIfNotFound: true);
        m_Player_Pink_HorizontalMovement = m_Player_Pink.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_Player_Pink_Jump = m_Player_Pink.FindAction("Jump", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player_Blue
    private readonly InputActionMap m_Player_Blue;
    private IPlayer_BlueActions m_Player_BlueActionsCallbackInterface;
    private readonly InputAction m_Player_Blue_HorizontalMovement;
    private readonly InputAction m_Player_Blue_Jump;
    public struct Player_BlueActions
    {
        private @PlayerMove m_Wrapper;
        public Player_BlueActions(@PlayerMove wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Player_Blue_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_Player_Blue_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player_Blue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_BlueActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_BlueActions instance)
        {
            if (m_Wrapper.m_Player_BlueActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_Player_BlueActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_Player_BlueActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_Player_BlueActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_Player_BlueActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player_BlueActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player_BlueActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Player_BlueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public Player_BlueActions @Player_Blue => new Player_BlueActions(this);

    // Player_Pink
    private readonly InputActionMap m_Player_Pink;
    private IPlayer_PinkActions m_Player_PinkActionsCallbackInterface;
    private readonly InputAction m_Player_Pink_HorizontalMovement;
    private readonly InputAction m_Player_Pink_Jump;
    public struct Player_PinkActions
    {
        private @PlayerMove m_Wrapper;
        public Player_PinkActions(@PlayerMove wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Player_Pink_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_Player_Pink_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player_Pink; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_PinkActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_PinkActions instance)
        {
            if (m_Wrapper.m_Player_PinkActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_Player_PinkActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_Player_PinkActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_Player_PinkActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_Player_PinkActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player_PinkActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player_PinkActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Player_PinkActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public Player_PinkActions @Player_Pink => new Player_PinkActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayer_BlueActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayer_PinkActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
