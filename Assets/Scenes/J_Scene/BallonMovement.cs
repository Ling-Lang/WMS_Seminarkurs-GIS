// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/J_Scene/BallonMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BallonMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BallonMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BallonMovement"",
    ""maps"": [
        {
            ""name"": ""Ballon"",
            ""id"": ""f40c22ff-5b6d-4176-aa3f-910fdbc24230"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""339c7e8b-c42d-4cb9-b3c3-d3d9cb908079"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7a4ab4e4-358d-46f0-90f9-85339d7160b3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a8771ea9-ae1b-4e26-bca1-700c7b11c3d0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0f4b17bc-92b4-4e4e-84cd-c5aa6ef4f9c7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ballon
        m_Ballon = asset.FindActionMap("Ballon", throwIfNotFound: true);
        m_Ballon_Movement = m_Ballon.FindAction("Movement", throwIfNotFound: true);
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

    // Ballon
    private readonly InputActionMap m_Ballon;
    private IBallonActions m_BallonActionsCallbackInterface;
    private readonly InputAction m_Ballon_Movement;
    public struct BallonActions
    {
        private @BallonMovement m_Wrapper;
        public BallonActions(@BallonMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Ballon_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Ballon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallonActions set) { return set.Get(); }
        public void SetCallbacks(IBallonActions instance)
        {
            if (m_Wrapper.m_BallonActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BallonActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BallonActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BallonActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_BallonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public BallonActions @Ballon => new BallonActions(this);
    public interface IBallonActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
