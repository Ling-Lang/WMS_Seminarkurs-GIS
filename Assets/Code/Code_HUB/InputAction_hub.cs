// GENERATED AUTOMATICALLY FROM 'Assets/Code/Code_HUB/InputAction_hub.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputAction_hub : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputAction_hub()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputAction_hub"",
    ""maps"": [
        {
            ""name"": ""Museum"",
            ""id"": ""f99c2e45-4779-463d-b08a-819b10c673c7"",
            ""actions"": [
                {
                    ""name"": ""W"",
                    ""type"": ""Button"",
                    ""id"": ""7dc93ca0-3c2a-4978-a812-695579ca430b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""7c78696b-0464-4983-82cb-934d13cd1ac4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""390ca8be-4138-410b-90c3-d23ae83b869f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""2a3e3e52-4fe8-457e-b9bd-f82a4785e4a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""interact"",
                    ""type"": ""Button"",
                    ""id"": ""8f34e705-2b57-411e-9c82-7deca3c67c9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_C"",
                    ""type"": ""Value"",
                    ""id"": ""f8ec182a-9c39-456b-8ffd-cf6a3c499fa6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58a205ce-0a80-48b6-a9e4-3ed4720f656f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e78f9d38-607c-434c-8c19-1e612e25d17e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c34d0d98-3b17-4e65-afcc-5387378ecef7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aab0037-5b62-4407-a9ed-c4c447ef0f7e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df9e0696-9bed-49b3-9ce9-307e92c7759d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5988b93-6739-440c-8cb0-435995e5ce17"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11cf0e5b-7588-4107-812f-b5ae3b3a76cc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3624e4e1-8c64-4a71-bbd3-156b5f184a08"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""554720ca-e55a-4659-aa4d-0cf1809adde4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e02d4689-3805-42ce-9b56-63d93541970e"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abb72393-b603-4112-8b35-c57cef128806"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""790fcda9-4fc5-4acf-a1bb-9e61b2cefbc3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_C"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Museum
        m_Museum = asset.FindActionMap("Museum", throwIfNotFound: true);
        m_Museum_W = m_Museum.FindAction("W", throwIfNotFound: true);
        m_Museum_D = m_Museum.FindAction("D", throwIfNotFound: true);
        m_Museum_S = m_Museum.FindAction("S", throwIfNotFound: true);
        m_Museum_A = m_Museum.FindAction("A", throwIfNotFound: true);
        m_Museum_interact = m_Museum.FindAction("interact", throwIfNotFound: true);
        m_Museum_Move_C = m_Museum.FindAction("Move_C", throwIfNotFound: true);
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

    // Museum
    private readonly InputActionMap m_Museum;
    private IMuseumActions m_MuseumActionsCallbackInterface;
    private readonly InputAction m_Museum_W;
    private readonly InputAction m_Museum_D;
    private readonly InputAction m_Museum_S;
    private readonly InputAction m_Museum_A;
    private readonly InputAction m_Museum_interact;
    private readonly InputAction m_Museum_Move_C;
    public struct MuseumActions
    {
        private @InputAction_hub m_Wrapper;
        public MuseumActions(@InputAction_hub wrapper) { m_Wrapper = wrapper; }
        public InputAction @W => m_Wrapper.m_Museum_W;
        public InputAction @D => m_Wrapper.m_Museum_D;
        public InputAction @S => m_Wrapper.m_Museum_S;
        public InputAction @A => m_Wrapper.m_Museum_A;
        public InputAction @interact => m_Wrapper.m_Museum_interact;
        public InputAction @Move_C => m_Wrapper.m_Museum_Move_C;
        public InputActionMap Get() { return m_Wrapper.m_Museum; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MuseumActions set) { return set.Get(); }
        public void SetCallbacks(IMuseumActions instance)
        {
            if (m_Wrapper.m_MuseumActionsCallbackInterface != null)
            {
                @W.started -= m_Wrapper.m_MuseumActionsCallbackInterface.OnW;
                @W.performed -= m_Wrapper.m_MuseumActionsCallbackInterface.OnW;
                @W.canceled -= m_Wrapper.m_MuseumActionsCallbackInterface.OnW;
                @D.started -= m_Wrapper.m_MuseumActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_MuseumActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_MuseumActionsCallbackInterface.OnD;
                @S.started -= m_Wrapper.m_MuseumActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_MuseumActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_MuseumActionsCallbackInterface.OnS;
                @A.started -= m_Wrapper.m_MuseumActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_MuseumActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_MuseumActionsCallbackInterface.OnA;
                @interact.started -= m_Wrapper.m_MuseumActionsCallbackInterface.OnInteract;
                @interact.performed -= m_Wrapper.m_MuseumActionsCallbackInterface.OnInteract;
                @interact.canceled -= m_Wrapper.m_MuseumActionsCallbackInterface.OnInteract;
                @Move_C.started -= m_Wrapper.m_MuseumActionsCallbackInterface.OnMove_C;
                @Move_C.performed -= m_Wrapper.m_MuseumActionsCallbackInterface.OnMove_C;
                @Move_C.canceled -= m_Wrapper.m_MuseumActionsCallbackInterface.OnMove_C;
            }
            m_Wrapper.m_MuseumActionsCallbackInterface = instance;
            if (instance != null)
            {
                @W.started += instance.OnW;
                @W.performed += instance.OnW;
                @W.canceled += instance.OnW;
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @interact.started += instance.OnInteract;
                @interact.performed += instance.OnInteract;
                @interact.canceled += instance.OnInteract;
                @Move_C.started += instance.OnMove_C;
                @Move_C.performed += instance.OnMove_C;
                @Move_C.canceled += instance.OnMove_C;
            }
        }
    }
    public MuseumActions @Museum => new MuseumActions(this);
    public interface IMuseumActions
    {
        void OnW(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMove_C(InputAction.CallbackContext context);
    }
}
