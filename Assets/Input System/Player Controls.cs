// GENERATED AUTOMATICALLY FROM 'Assets/Input System/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Main Action Map"",
            ""id"": ""a9ca4bfe-0d36-46b1-a38b-fa97e9280840"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0011e38b-69a2-4563-a932-1fc54f88c073"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d8d3c90f-c710-4d28-8f8b-84aa98a6eb06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""057d19d4-ba8f-49dd-a4ab-3b48508e2738"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f4411d6c-79e7-474d-9b37-838c49e6424a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""cf1ea583-f9aa-4334-8312-2fb3e406976e"",
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
                    ""id"": ""6b8eef73-563b-448c-9bdf-52d3f2eb1a68"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a9926771-19e9-47dd-bb10-7b087f80edb6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e1a009c2-401c-4df8-a521-e1a56408cd70"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""72c90520-8cb4-474b-b5b3-41436c4130cf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""122f33d7-61d5-4357-8945-53f790665fb5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ee6a1f-2c18-4d4e-b253-d7f3e0685b89"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbb48daa-754c-4c9a-9365-5add3c699fa6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Main Action Map
        m_MainActionMap = asset.FindActionMap("Main Action Map", throwIfNotFound: true);
        m_MainActionMap_Move = m_MainActionMap.FindAction("Move", throwIfNotFound: true);
        m_MainActionMap_Jump = m_MainActionMap.FindAction("Jump", throwIfNotFound: true);
        m_MainActionMap_MouseLook = m_MainActionMap.FindAction("MouseLook", throwIfNotFound: true);
        m_MainActionMap_Interact = m_MainActionMap.FindAction("Interact", throwIfNotFound: true);
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

    // Main Action Map
    private readonly InputActionMap m_MainActionMap;
    private IMainActionMapActions m_MainActionMapActionsCallbackInterface;
    private readonly InputAction m_MainActionMap_Move;
    private readonly InputAction m_MainActionMap_Jump;
    private readonly InputAction m_MainActionMap_MouseLook;
    private readonly InputAction m_MainActionMap_Interact;
    public struct MainActionMapActions
    {
        private @PlayerControls m_Wrapper;
        public MainActionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MainActionMap_Move;
        public InputAction @Jump => m_Wrapper.m_MainActionMap_Jump;
        public InputAction @MouseLook => m_Wrapper.m_MainActionMap_MouseLook;
        public InputAction @Interact => m_Wrapper.m_MainActionMap_Interact;
        public InputActionMap Get() { return m_Wrapper.m_MainActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IMainActionMapActions instance)
        {
            if (m_Wrapper.m_MainActionMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnJump;
                @MouseLook.started -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnMouseLook;
                @Interact.started -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MainActionMapActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_MainActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public MainActionMapActions @MainActionMap => new MainActionMapActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IMainActionMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
