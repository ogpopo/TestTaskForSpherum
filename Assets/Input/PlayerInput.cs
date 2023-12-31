//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""RedCube"",
            ""id"": ""0fa8a0d0-2dcc-4a9d-a0b7-50fbd8884ca1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7aa03c05-1d8e-4e70-a6c8-36d24d5319e4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a6cb5b39-9725-4f1d-bed4-0f2bd6d9121a"",
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
                    ""id"": ""4aa1510d-3f01-4e10-b0d0-fa0500c22211"",
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
                    ""id"": ""d1f2a625-564c-4d47-8891-2eef87668020"",
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
                    ""id"": ""1044d361-e484-4316-9528-f9a795a5d52f"",
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
                    ""id"": ""1beb4f58-a8fa-4144-935a-f01f0d998e59"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""GreenCube"",
            ""id"": ""e6f96fae-8e41-4b1c-8c7e-82b4878a16bd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""52b7c447-7f86-40c4-b986-990bf34dfec4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""8c406c27-0a44-43d9-84d4-adf5c473d285"",
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
                    ""id"": ""a500158a-183b-444e-94f4-001a6246cfdb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""83ce187f-710d-4e95-a5be-d87e2e4ee229"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""40871ac7-a03c-49b6-a2ae-292372303496"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d99cea6b-b3b0-4ee3-b172-0f7fac42a7f7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RedCube
        m_RedCube = asset.FindActionMap("RedCube", throwIfNotFound: true);
        m_RedCube_Move = m_RedCube.FindAction("Move", throwIfNotFound: true);
        // GreenCube
        m_GreenCube = asset.FindActionMap("GreenCube", throwIfNotFound: true);
        m_GreenCube_Move = m_GreenCube.FindAction("Move", throwIfNotFound: true);
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

    // RedCube
    private readonly InputActionMap m_RedCube;
    private List<IRedCubeActions> m_RedCubeActionsCallbackInterfaces = new List<IRedCubeActions>();
    private readonly InputAction m_RedCube_Move;
    public struct RedCubeActions
    {
        private @PlayerInput m_Wrapper;
        public RedCubeActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_RedCube_Move;
        public InputActionMap Get() { return m_Wrapper.m_RedCube; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RedCubeActions set) { return set.Get(); }
        public void AddCallbacks(IRedCubeActions instance)
        {
            if (instance == null || m_Wrapper.m_RedCubeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RedCubeActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IRedCubeActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IRedCubeActions instance)
        {
            if (m_Wrapper.m_RedCubeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRedCubeActions instance)
        {
            foreach (var item in m_Wrapper.m_RedCubeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RedCubeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RedCubeActions @RedCube => new RedCubeActions(this);

    // GreenCube
    private readonly InputActionMap m_GreenCube;
    private List<IGreenCubeActions> m_GreenCubeActionsCallbackInterfaces = new List<IGreenCubeActions>();
    private readonly InputAction m_GreenCube_Move;
    public struct GreenCubeActions
    {
        private @PlayerInput m_Wrapper;
        public GreenCubeActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GreenCube_Move;
        public InputActionMap Get() { return m_Wrapper.m_GreenCube; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GreenCubeActions set) { return set.Get(); }
        public void AddCallbacks(IGreenCubeActions instance)
        {
            if (instance == null || m_Wrapper.m_GreenCubeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GreenCubeActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IGreenCubeActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IGreenCubeActions instance)
        {
            if (m_Wrapper.m_GreenCubeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGreenCubeActions instance)
        {
            foreach (var item in m_Wrapper.m_GreenCubeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GreenCubeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GreenCubeActions @GreenCube => new GreenCubeActions(this);
    public interface IRedCubeActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IGreenCubeActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
