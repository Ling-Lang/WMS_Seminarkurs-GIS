// GENERATED AUTOMATICALLY FROM 'Assets/Code/Code_CM/Player_Input_CM.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Input_CM : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Input_CM()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Input_CM"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""a59768f9-25ca-4103-b642-f9094658731e"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""328a10e1-440f-4f81-8822-dbc1a7982005"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""walk"",
                    ""type"": ""Value"",
                    ""id"": ""e66a98c9-2158-4b78-b07e-0e3180e9fbae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""vShoot"",
                    ""type"": ""Button"",
                    ""id"": ""335e749f-ceb0-4629-83f2-79307732c938"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""hShoot"",
                    ""type"": ""Button"",
                    ""id"": ""7fa82510-d58a-4fdf-82c3-b500ea949a1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ddd7e9ae-35b5-46c8-b1ef-f3def8df1cdb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9de2d99-7c86-4340-86f4-0794822ba6a4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8ec6e497-b90c-4ef1-9f3d-432feb48c116"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""98750d7d-a5ab-4f72-9af8-be2753714351"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""817c518b-42d1-4638-a113-748df99848e7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2f824a3e-dd0f-40c6-b922-7cb2ed31ceb4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""672eb159-72aa-46bc-9a86-4531be938388"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""vShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3470efd1-8db3-4458-a0b2-528e7d6df8eb"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TestMovement"",
            ""id"": ""55f8ccd1-5fc4-4940-bfb4-0a2b3660222f"",
            ""actions"": [
                {
                    ""name"": ""hShoot"",
                    ""type"": ""Button"",
                    ""id"": ""909c9a67-4528-443c-8973-6ddd988fde22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""vShoot"",
                    ""type"": ""Button"",
                    ""id"": ""2eccb75b-de02-449f-b44b-df24d29f5b1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""walk"",
                    ""type"": ""Value"",
                    ""id"": ""c44eee43-4c55-44a2-ae83-da8856681ac9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""d568cc74-05ef-4015-acab-d8daef6f4470"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ea5787c-5870-4b2a-b871-051a0dd0f85a"",
                    ""path"": ""<Keyboard>/rightAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input_control_scheme"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1da7045e-d904-493b-bfa0-2c96b928de5a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c35c7a7-0bb1-4940-8573-aed049aef1ee"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e041b478-43ff-438f-9084-2443587bf977"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4374d0f9-cc9c-47b0-bdd4-2dc2faf79875"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""02e005f4-8bdd-417a-bc9f-b4107ce46284"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bbb65af7-2bc2-4bf2-96e4-0aa3aebf1f12"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector Xbox-Controller-01-Switch"",
                    ""id"": ""e45b7707-bf02-4988-a029-0ded9e7136c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5d4eb531-6dd3-466e-9ebf-455603fe07e1"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8671c562-c6ac-4c13-a739-a3f1dab7f772"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""724b2aef-a32c-4692-a20f-9bf915b90773"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c4ccc2c7-aa22-48bf-85fc-d3e32dd94568"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""vShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46c24c68-364c-4d06-b82a-fb2f94f1dc0e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""vShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ceea642-3b64-40f9-82e8-941145d7e41b"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1db9269a-5e3c-4da3-886b-9f20a6bae6a3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Input_control_scheme"",
            ""bindingGroup"": ""Input_control_scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox Controller"",
            ""bindingGroup"": ""Xbox Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_jump = m_Movement.FindAction("jump", throwIfNotFound: true);
        m_Movement_walk = m_Movement.FindAction("walk", throwIfNotFound: true);
        m_Movement_vShoot = m_Movement.FindAction("vShoot", throwIfNotFound: true);
        m_Movement_hShoot = m_Movement.FindAction("hShoot", throwIfNotFound: true);
        // TestMovement
        m_TestMovement = asset.FindActionMap("TestMovement", throwIfNotFound: true);
        m_TestMovement_hShoot = m_TestMovement.FindAction("hShoot", throwIfNotFound: true);
        m_TestMovement_vShoot = m_TestMovement.FindAction("vShoot", throwIfNotFound: true);
        m_TestMovement_walk = m_TestMovement.FindAction("walk", throwIfNotFound: true);
        m_TestMovement_jump = m_TestMovement.FindAction("jump", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_jump;
    private readonly InputAction m_Movement_walk;
    private readonly InputAction m_Movement_vShoot;
    private readonly InputAction m_Movement_hShoot;
    public struct MovementActions
    {
        private @Player_Input_CM m_Wrapper;
        public MovementActions(@Player_Input_CM wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Movement_jump;
        public InputAction @walk => m_Wrapper.m_Movement_walk;
        public InputAction @vShoot => m_Wrapper.m_Movement_vShoot;
        public InputAction @hShoot => m_Wrapper.m_Movement_hShoot;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @walk.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @walk.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @walk.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @vShoot.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnVShoot;
                @vShoot.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnVShoot;
                @vShoot.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnVShoot;
                @hShoot.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHShoot;
                @hShoot.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHShoot;
                @hShoot.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHShoot;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @walk.started += instance.OnWalk;
                @walk.performed += instance.OnWalk;
                @walk.canceled += instance.OnWalk;
                @vShoot.started += instance.OnVShoot;
                @vShoot.performed += instance.OnVShoot;
                @vShoot.canceled += instance.OnVShoot;
                @hShoot.started += instance.OnHShoot;
                @hShoot.performed += instance.OnHShoot;
                @hShoot.canceled += instance.OnHShoot;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // TestMovement
    private readonly InputActionMap m_TestMovement;
    private ITestMovementActions m_TestMovementActionsCallbackInterface;
    private readonly InputAction m_TestMovement_hShoot;
    private readonly InputAction m_TestMovement_vShoot;
    private readonly InputAction m_TestMovement_walk;
    private readonly InputAction m_TestMovement_jump;
    public struct TestMovementActions
    {
        private @Player_Input_CM m_Wrapper;
        public TestMovementActions(@Player_Input_CM wrapper) { m_Wrapper = wrapper; }
        public InputAction @hShoot => m_Wrapper.m_TestMovement_hShoot;
        public InputAction @vShoot => m_Wrapper.m_TestMovement_vShoot;
        public InputAction @walk => m_Wrapper.m_TestMovement_walk;
        public InputAction @jump => m_Wrapper.m_TestMovement_jump;
        public InputActionMap Get() { return m_Wrapper.m_TestMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestMovementActions set) { return set.Get(); }
        public void SetCallbacks(ITestMovementActions instance)
        {
            if (m_Wrapper.m_TestMovementActionsCallbackInterface != null)
            {
                @hShoot.started -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnHShoot;
                @hShoot.performed -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnHShoot;
                @hShoot.canceled -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnHShoot;
                @vShoot.started -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnVShoot;
                @vShoot.performed -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnVShoot;
                @vShoot.canceled -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnVShoot;
                @walk.started -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnWalk;
                @walk.performed -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnWalk;
                @walk.canceled -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnWalk;
                @jump.started -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_TestMovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_TestMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @hShoot.started += instance.OnHShoot;
                @hShoot.performed += instance.OnHShoot;
                @hShoot.canceled += instance.OnHShoot;
                @vShoot.started += instance.OnVShoot;
                @vShoot.performed += instance.OnVShoot;
                @vShoot.canceled += instance.OnVShoot;
                @walk.started += instance.OnWalk;
                @walk.performed += instance.OnWalk;
                @walk.canceled += instance.OnWalk;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public TestMovementActions @TestMovement => new TestMovementActions(this);
    private int m_Input_control_schemeSchemeIndex = -1;
    public InputControlScheme Input_control_schemeScheme
    {
        get
        {
            if (m_Input_control_schemeSchemeIndex == -1) m_Input_control_schemeSchemeIndex = asset.FindControlSchemeIndex("Input_control_scheme");
            return asset.controlSchemes[m_Input_control_schemeSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("Xbox Controller");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnVShoot(InputAction.CallbackContext context);
        void OnHShoot(InputAction.CallbackContext context);
    }
    public interface ITestMovementActions
    {
        void OnHShoot(InputAction.CallbackContext context);
        void OnVShoot(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
