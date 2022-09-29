// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerAction"",
            ""id"": ""f327af9a-1b4c-4931-a9a4-3f85f8fc193f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""30b58810-dec8-418f-aff7-0fa28dcf0084"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cb7dff50-9190-4d2a-91d9-eee4c1a47082"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""62eeab20-6acf-4072-8439-9fba39445624"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""13a4414a-77b2-4b40-b6c3-cc0f61bd5a1c"",
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
                    ""id"": ""1a8bef3f-2a57-4816-a28c-428717fa854c"",
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
                    ""id"": ""968786fb-1768-489b-befb-2d9d20b8c0a8"",
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
                    ""id"": ""83d540fd-3f97-42dd-97e1-2379fec96d87"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""c7e2bb48-0047-40b2-9902-79e2202dc73a"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c8dee531-896e-484c-b43e-5cf1ba13f312"",
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
                    ""id"": ""ab341fe5-bbc8-4a8a-8979-6b43320b9155"",
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
                    ""id"": ""869d0ed5-9266-40d8-89e2-b6ce6c0e0671"",
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
                    ""id"": ""0650e4b4-75b5-406e-a07e-8c369d633754"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8cf915e4-43ff-40be-b9b7-122a01e18636"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_Move = m_PlayerAction.FindAction("Move", throwIfNotFound: true);
        m_PlayerAction_Jump = m_PlayerAction.FindAction("Jump", throwIfNotFound: true);
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

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private IPlayerActionActions m_PlayerActionActionsCallbackInterface;
    private readonly InputAction m_PlayerAction_Move;
    private readonly InputAction m_PlayerAction_Jump;
    public struct PlayerActionActions
    {
        private @InputActions m_Wrapper;
        public PlayerActionActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerAction_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerAction_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);
    public interface IPlayerActionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
