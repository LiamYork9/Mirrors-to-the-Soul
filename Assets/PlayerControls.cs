//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""01b4176f-0214-49cc-a821-83b2c0d23be5"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Value"",
                    ""id"": ""d87317ee-76f5-41b0-a2fa-4ab06b94b2c1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Value"",
                    ""id"": ""3f7a785a-591c-4081-9a76-af04a33b3942"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Value"",
                    ""id"": ""f5fece04-f1e9-4162-8e81-157e865d32c9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Value"",
                    ""id"": ""f9292eea-5619-4ead-bdea-a5130b4125e9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AimBookY"",
                    ""type"": ""Value"",
                    ""id"": ""53cd11ce-6c24-48f8-a214-d2f9d6a10427"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AimBookX"",
                    ""type"": ""Value"",
                    ""id"": ""3a3c5bd2-af7f-4958-91bc-190976d912c7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AimBookUp"",
                    ""type"": ""Button"",
                    ""id"": ""21bbd526-1a83-4572-a10b-26671bfbc217"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AimBookDown"",
                    ""type"": ""Button"",
                    ""id"": ""da79e5b5-3c82-4643-8c96-2e7231f290ec"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AimBookRight"",
                    ""type"": ""Button"",
                    ""id"": ""93e1284c-3400-4929-8d40-8f936465ee32"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AimBookLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c44d5c50-557a-4d69-a4f0-30bb2eb50d27"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""b55d58bb-7a3b-4830-b375-f8e320c9f153"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7d082c3-3c06-4823-841f-dbeab3becabe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a400a07a-19ec-458a-b58b-e648ed22e0c5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a654631c-5436-4ca4-a9c1-da5b76f01eae"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2e798f1-5c91-457a-a26e-ba2cf60c564d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a0758ad-8dce-4618-953f-125bff0c47bf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7975e5fa-f20b-4b16-a49b-7814f249d946"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a9fe652-a74f-434a-b540-27ef9c252961"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff6cf894-de5f-48e2-9f24-7307bbf7bc85"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f216e1e9-b484-4c00-92c6-b5545f7d73e6"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b48b68c3-7c01-4fd4-9cfd-64a234d67a67"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""584eac53-bbcd-40b9-8054-72af3f52b0b7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBookUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c166b36-aa94-4a01-81f1-cb1b0b136d56"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBookDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cc27565-1b17-433d-9335-07009180a908"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBookRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1c2fe67-b345-4874-bc99-fcb0c27ae1b2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBookLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""917e7e07-d340-4a3f-8d09-c4e900f9d105"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50795854-5c77-48fc-8e25-2cdf2cc3445c"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_MoveUp = m_Controls.FindAction("MoveUp", throwIfNotFound: true);
        m_Controls_MoveDown = m_Controls.FindAction("MoveDown", throwIfNotFound: true);
        m_Controls_MoveRight = m_Controls.FindAction("MoveRight", throwIfNotFound: true);
        m_Controls_MoveLeft = m_Controls.FindAction("MoveLeft", throwIfNotFound: true);
        m_Controls_AimBookY = m_Controls.FindAction("AimBookY", throwIfNotFound: true);
        m_Controls_AimBookX = m_Controls.FindAction("AimBookX", throwIfNotFound: true);
        m_Controls_AimBookUp = m_Controls.FindAction("AimBookUp", throwIfNotFound: true);
        m_Controls_AimBookDown = m_Controls.FindAction("AimBookDown", throwIfNotFound: true);
        m_Controls_AimBookRight = m_Controls.FindAction("AimBookRight", throwIfNotFound: true);
        m_Controls_AimBookLeft = m_Controls.FindAction("AimBookLeft", throwIfNotFound: true);
        m_Controls_Shoot = m_Controls.FindAction("Shoot", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Controls.enabled, "This will cause a leak and performance issues, PlayerControls.Controls.Disable() has not been called.");
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

    // Controls
    private readonly InputActionMap m_Controls;
    private List<IControlsActions> m_ControlsActionsCallbackInterfaces = new List<IControlsActions>();
    private readonly InputAction m_Controls_MoveUp;
    private readonly InputAction m_Controls_MoveDown;
    private readonly InputAction m_Controls_MoveRight;
    private readonly InputAction m_Controls_MoveLeft;
    private readonly InputAction m_Controls_AimBookY;
    private readonly InputAction m_Controls_AimBookX;
    private readonly InputAction m_Controls_AimBookUp;
    private readonly InputAction m_Controls_AimBookDown;
    private readonly InputAction m_Controls_AimBookRight;
    private readonly InputAction m_Controls_AimBookLeft;
    private readonly InputAction m_Controls_Shoot;
    public struct ControlsActions
    {
        private @PlayerControls m_Wrapper;
        public ControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_Controls_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_Controls_MoveDown;
        public InputAction @MoveRight => m_Wrapper.m_Controls_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_Controls_MoveLeft;
        public InputAction @AimBookY => m_Wrapper.m_Controls_AimBookY;
        public InputAction @AimBookX => m_Wrapper.m_Controls_AimBookX;
        public InputAction @AimBookUp => m_Wrapper.m_Controls_AimBookUp;
        public InputAction @AimBookDown => m_Wrapper.m_Controls_AimBookDown;
        public InputAction @AimBookRight => m_Wrapper.m_Controls_AimBookRight;
        public InputAction @AimBookLeft => m_Wrapper.m_Controls_AimBookLeft;
        public InputAction @Shoot => m_Wrapper.m_Controls_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void AddCallbacks(IControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_ControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ControlsActionsCallbackInterfaces.Add(instance);
            @MoveUp.started += instance.OnMoveUp;
            @MoveUp.performed += instance.OnMoveUp;
            @MoveUp.canceled += instance.OnMoveUp;
            @MoveDown.started += instance.OnMoveDown;
            @MoveDown.performed += instance.OnMoveDown;
            @MoveDown.canceled += instance.OnMoveDown;
            @MoveRight.started += instance.OnMoveRight;
            @MoveRight.performed += instance.OnMoveRight;
            @MoveRight.canceled += instance.OnMoveRight;
            @MoveLeft.started += instance.OnMoveLeft;
            @MoveLeft.performed += instance.OnMoveLeft;
            @MoveLeft.canceled += instance.OnMoveLeft;
            @AimBookY.started += instance.OnAimBookY;
            @AimBookY.performed += instance.OnAimBookY;
            @AimBookY.canceled += instance.OnAimBookY;
            @AimBookX.started += instance.OnAimBookX;
            @AimBookX.performed += instance.OnAimBookX;
            @AimBookX.canceled += instance.OnAimBookX;
            @AimBookUp.started += instance.OnAimBookUp;
            @AimBookUp.performed += instance.OnAimBookUp;
            @AimBookUp.canceled += instance.OnAimBookUp;
            @AimBookDown.started += instance.OnAimBookDown;
            @AimBookDown.performed += instance.OnAimBookDown;
            @AimBookDown.canceled += instance.OnAimBookDown;
            @AimBookRight.started += instance.OnAimBookRight;
            @AimBookRight.performed += instance.OnAimBookRight;
            @AimBookRight.canceled += instance.OnAimBookRight;
            @AimBookLeft.started += instance.OnAimBookLeft;
            @AimBookLeft.performed += instance.OnAimBookLeft;
            @AimBookLeft.canceled += instance.OnAimBookLeft;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
        }

        private void UnregisterCallbacks(IControlsActions instance)
        {
            @MoveUp.started -= instance.OnMoveUp;
            @MoveUp.performed -= instance.OnMoveUp;
            @MoveUp.canceled -= instance.OnMoveUp;
            @MoveDown.started -= instance.OnMoveDown;
            @MoveDown.performed -= instance.OnMoveDown;
            @MoveDown.canceled -= instance.OnMoveDown;
            @MoveRight.started -= instance.OnMoveRight;
            @MoveRight.performed -= instance.OnMoveRight;
            @MoveRight.canceled -= instance.OnMoveRight;
            @MoveLeft.started -= instance.OnMoveLeft;
            @MoveLeft.performed -= instance.OnMoveLeft;
            @MoveLeft.canceled -= instance.OnMoveLeft;
            @AimBookY.started -= instance.OnAimBookY;
            @AimBookY.performed -= instance.OnAimBookY;
            @AimBookY.canceled -= instance.OnAimBookY;
            @AimBookX.started -= instance.OnAimBookX;
            @AimBookX.performed -= instance.OnAimBookX;
            @AimBookX.canceled -= instance.OnAimBookX;
            @AimBookUp.started -= instance.OnAimBookUp;
            @AimBookUp.performed -= instance.OnAimBookUp;
            @AimBookUp.canceled -= instance.OnAimBookUp;
            @AimBookDown.started -= instance.OnAimBookDown;
            @AimBookDown.performed -= instance.OnAimBookDown;
            @AimBookDown.canceled -= instance.OnAimBookDown;
            @AimBookRight.started -= instance.OnAimBookRight;
            @AimBookRight.performed -= instance.OnAimBookRight;
            @AimBookRight.canceled -= instance.OnAimBookRight;
            @AimBookLeft.started -= instance.OnAimBookLeft;
            @AimBookLeft.performed -= instance.OnAimBookLeft;
            @AimBookLeft.canceled -= instance.OnAimBookLeft;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
        }

        public void RemoveCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_ControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    public interface IControlsActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnAimBookY(InputAction.CallbackContext context);
        void OnAimBookX(InputAction.CallbackContext context);
        void OnAimBookUp(InputAction.CallbackContext context);
        void OnAimBookDown(InputAction.CallbackContext context);
        void OnAimBookRight(InputAction.CallbackContext context);
        void OnAimBookLeft(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
