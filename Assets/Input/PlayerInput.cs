// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""80bfd7f3-d608-497c-be90-0b6d7cef688c"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""b0af18a5-c9a8-4b9d-bb41-467089173877"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e487b562-ab7d-438f-9f0d-c067c73855de"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""7259d6ca-ec5f-4a47-957d-c1bcf4636087"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""63b118cf-e7bc-4cdf-a522-1351ec38dc24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""fc144666-8147-4551-82e1-cfcd93ccdfec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeployDrone"",
                    ""type"": ""Value"",
                    ""id"": ""89434f26-20ed-48e6-a225-5f1bc95816b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Value"",
                    ""id"": ""9355b59e-9680-4030-8ad4-df4b1b97eda0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryFire"",
                    ""type"": ""Button"",
                    ""id"": ""2da41512-1f62-4453-b84d-ac29ebb7011e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryFire"",
                    ""type"": ""Button"",
                    ""id"": ""4a6a01a8-8afe-44b7-b124-4f2f77f81ca6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""aa60067a-c1d0-4aba-9097-04d24dd441fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""8d6d9c35-5ac1-4bda-9e28-9f039a481305"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ce6c2e0-1b83-41d2-a67c-386a2ff2a178"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76a9b2dd-2b20-49bb-9b96-2a6b5b2969f4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4bc97b6c-345a-428c-8d17-b22b31a35724"",
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
                    ""id"": ""abc6b841-b233-42c7-989d-11023adb43e3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""004d0e6d-30a4-40d4-bad7-55e1e5257532"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""44219f68-cd85-4dba-8f51-63e2080bb17e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8e565e83-1be5-4ab7-ba02-b363ba353264"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2b4002d2-131e-4b88-bbe8-2c96870205bf"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f65ec8fd-ff74-4ddd-bf22-7b8884dd1ae4"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c54dc74-04b7-4e32-b3f3-2e2fe08db9fa"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f974921-f357-4076-a4aa-684d5f0f2ad4"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee558e88-1c91-4e9e-b781-f9e917a355a0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2d470f5-5ce2-4421-b303-14f07aaaffdd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=15,y=15)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ef22a4c-fd96-49cc-a0b2-863b4d7562ab"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),StickDeadzone,ScaleVector2(x=300,y=300)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeb9c515-51e0-4058-a309-d601bfd5737d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeployDrone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8a5d132-daba-4675-85db-342c25d1d87f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeployDrone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""678cf618-1dbb-42f8-87a6-8dea06262dda"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""056c3190-06fa-4f93-aecd-a04b396aae04"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8232c750-15cf-4097-8a57-92d2cfa556d2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b31b773c-d21e-4bd8-8499-2ce9bd98d491"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a3730f7-3ff1-414c-8b1f-60a400805d27"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9b3e213-a63c-4faf-a72d-be754eb220b0"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d489332a-5ad1-479b-9574-801dae0bb5d2"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f605526e-2ea4-4a1e-bd43-4e11111052a1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eff324d-327b-4063-856e-f59be27d077f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""228e7039-fab0-4f35-a4c2-26ee1ae5972d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameControls"",
            ""id"": ""bb69614b-9dcf-43c6-a79e-f0d15e1d09a5"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5fe89f37-1b5a-4a95-92a8-92e498dd6dce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""257285f5-0aa2-452b-8972-cae3c67736d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""6565e7b0-63ec-4105-9887-304af9128d85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""b6f0c0a9-3f5b-4a4d-a269-396d1a158c06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""ae4e73ab-3b2b-41c5-a54b-5ce159ac0d1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""83258f02-d4e1-48f1-b2d7-241d373a4be8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""c7486be3-8892-40ba-bcd5-1938200e2a19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""827de303-299d-4647-8ec1-4dfb4088e536"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaad0ce3-ef83-4874-a25b-08ddad25bc0c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72ad760c-41b2-4977-99ef-23bbcb82d68a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96a514c2-1b7a-43c3-946f-981079e90550"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dab9ff4-7d22-4641-b0b4-ff481e88b049"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d4edc90-8d24-4549-b837-6782fd2dc1f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8736c9f3-3d48-455f-b5f8-71c04984e9a5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f46a350e-f45e-4d79-bd7a-9b9e964ce1cf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31326677-11f9-491f-8b4d-acb74f01ccf0"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25749065-2cf4-4d96-9be2-d1f59e721e8a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7a3cda1-feea-4779-a90e-1d309d3e7020"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f35e3b6b-d9b3-45a1-afc1-889e058c59be"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8aa032f-c9ec-4a10-b24d-c2ba0a367160"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DroneMovement"",
            ""id"": ""44232c75-9351-4868-86d2-562f20e51e0e"",
            ""actions"": [
                {
                    ""name"": ""DroneMovement"",
                    ""type"": ""Value"",
                    ""id"": ""f911ea38-2131-4f03-9c43-7a8db7ca0914"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DroneLook"",
                    ""type"": ""Value"",
                    ""id"": ""0e870313-482b-454a-81a4-2e4d65ca8647"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ascend"",
                    ""type"": ""Value"",
                    ""id"": ""d84a4b47-c267-4365-8d4b-1f76b2e41a25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Descend"",
                    ""type"": ""Button"",
                    ""id"": ""49fd456f-d5bb-40c7-ba18-6910bfc79210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DroneInteract"",
                    ""type"": ""Value"",
                    ""id"": ""86d47c0d-128c-4e66-9544-64db0086b801"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DroneExit"",
                    ""type"": ""Value"",
                    ""id"": ""6e94f9cc-510a-4ad0-b7d8-5d75f411dc38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ceb324b7-7da0-42f4-a8b3-70ea8c2b8e23"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2da47cdd-9100-40ae-8a1e-d4dc715d3324"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""99415602-52cd-4c36-a331-700eb6b2f81a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""52949ae3-c0c9-4dfc-a999-96603efc6327"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dee1dec2-3dca-46ff-a562-388a3beea8ef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e711faa1-430a-4476-bb2b-a9e1846aa687"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a545158-d2d3-4e2b-a806-c410026d4fb1"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),StickDeadzone,ScaleVector2(x=300,y=300)"",
                    ""groups"": """",
                    ""action"": ""DroneLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7d7bd71-aeb9-46a9-84a1-851e525d4e4a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=15,y=15),InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""DroneLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""093aaff5-76ad-42fd-ba75-c613b884a9c7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5c7ebc9-9e56-4ace-97d1-571d8891c6a7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b0337f3-f1a1-42d9-a57b-06ecd6ae9efc"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Descend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42fa2979-73ea-40d6-9fa7-371f0c41d768"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Descend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75b3b01e-fae8-4645-8a01-04655800ebf4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6ef4319-1c3d-4438-84b2-8b4212159327"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1df7172-de45-4b87-8c96-e7a06f88f02b"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneExit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3d46565-48b5-494c-9c56-b0ed31525685"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneExit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""14b1b94e-9449-4d21-b434-c34a9606e1c0"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69e78ebf-6c0d-4989-82d5-c17d2588bb22"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2934e967-0ddd-4a99-a2b3-2c6cd968177d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1d9b9770-4e32-4037-b90b-2fe48b4e68d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44a5ac8b-ac7b-41ae-bb9f-8e3d07d31782"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7d7d000b-22fb-4a96-8452-4918e2c353ca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b96a18a-defe-46b7-a0d4-e811054ab7cd"",
                    ""path"": ""<VirtualMouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12d323f4-b572-42ac-aa94-c2494504d811"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""390de915-0260-4b27-b86e-1051ce251737"",
                    ""path"": ""<VirtualMouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0e5bffe-b427-4dfb-8172-5231ea9301c8"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b254886e-a47b-401a-9fb6-cf8676c72afb"",
                    ""path"": ""<VirtualMouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de0151b0-b0c8-4a49-a290-8d391fe6380c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bdeec0a-f32c-4a80-bd0c-7eb6ad2add53"",
                    ""path"": ""<VirtualMouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e0716da-cbcb-4808-acb7-2c0471efb59a"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f99026d-f9de-43fa-bf5b-03e5ec750527"",
                    ""path"": ""<VirtualMouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d7d76da-22e4-49e8-ae2b-25927f6887fa"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Sprint = m_PlayerMovement.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerMovement_Crouch = m_PlayerMovement.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerMovement_Look = m_PlayerMovement.FindAction("Look", throwIfNotFound: true);
        m_PlayerMovement_DeployDrone = m_PlayerMovement.FindAction("DeployDrone", throwIfNotFound: true);
        m_PlayerMovement_Interact = m_PlayerMovement.FindAction("Interact", throwIfNotFound: true);
        m_PlayerMovement_PrimaryFire = m_PlayerMovement.FindAction("PrimaryFire", throwIfNotFound: true);
        m_PlayerMovement_SecondaryFire = m_PlayerMovement.FindAction("SecondaryFire", throwIfNotFound: true);
        m_PlayerMovement_Reload = m_PlayerMovement.FindAction("Reload", throwIfNotFound: true);
        m_PlayerMovement_Inventory = m_PlayerMovement.FindAction("Inventory", throwIfNotFound: true);
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_Pause = m_GameControls.FindAction("Pause", throwIfNotFound: true);
        m_GameControls_Confirm = m_GameControls.FindAction("Confirm", throwIfNotFound: true);
        m_GameControls_Up = m_GameControls.FindAction("Up", throwIfNotFound: true);
        m_GameControls_Down = m_GameControls.FindAction("Down", throwIfNotFound: true);
        m_GameControls_Left = m_GameControls.FindAction("Left", throwIfNotFound: true);
        m_GameControls_Right = m_GameControls.FindAction("Right", throwIfNotFound: true);
        m_GameControls_Back = m_GameControls.FindAction("Back", throwIfNotFound: true);
        // DroneMovement
        m_DroneMovement = asset.FindActionMap("DroneMovement", throwIfNotFound: true);
        m_DroneMovement_DroneMovement = m_DroneMovement.FindAction("DroneMovement", throwIfNotFound: true);
        m_DroneMovement_DroneLook = m_DroneMovement.FindAction("DroneLook", throwIfNotFound: true);
        m_DroneMovement_Ascend = m_DroneMovement.FindAction("Ascend", throwIfNotFound: true);
        m_DroneMovement_Descend = m_DroneMovement.FindAction("Descend", throwIfNotFound: true);
        m_DroneMovement_DroneInteract = m_DroneMovement.FindAction("DroneInteract", throwIfNotFound: true);
        m_DroneMovement_DroneExit = m_DroneMovement.FindAction("DroneExit", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_LeftClick = m_UI.FindAction("LeftClick", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_Scroll = m_UI.FindAction("Scroll", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Sprint;
    private readonly InputAction m_PlayerMovement_Crouch;
    private readonly InputAction m_PlayerMovement_Look;
    private readonly InputAction m_PlayerMovement_DeployDrone;
    private readonly InputAction m_PlayerMovement_Interact;
    private readonly InputAction m_PlayerMovement_PrimaryFire;
    private readonly InputAction m_PlayerMovement_SecondaryFire;
    private readonly InputAction m_PlayerMovement_Reload;
    private readonly InputAction m_PlayerMovement_Inventory;
    public struct PlayerMovementActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Sprint => m_Wrapper.m_PlayerMovement_Sprint;
        public InputAction @Crouch => m_Wrapper.m_PlayerMovement_Crouch;
        public InputAction @Look => m_Wrapper.m_PlayerMovement_Look;
        public InputAction @DeployDrone => m_Wrapper.m_PlayerMovement_DeployDrone;
        public InputAction @Interact => m_Wrapper.m_PlayerMovement_Interact;
        public InputAction @PrimaryFire => m_Wrapper.m_PlayerMovement_PrimaryFire;
        public InputAction @SecondaryFire => m_Wrapper.m_PlayerMovement_SecondaryFire;
        public InputAction @Reload => m_Wrapper.m_PlayerMovement_Reload;
        public InputAction @Inventory => m_Wrapper.m_PlayerMovement_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Sprint.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCrouch;
                @Look.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @DeployDrone.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDeployDrone;
                @DeployDrone.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDeployDrone;
                @DeployDrone.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDeployDrone;
                @Interact.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInteract;
                @PrimaryFire.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPrimaryFire;
                @PrimaryFire.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPrimaryFire;
                @PrimaryFire.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPrimaryFire;
                @SecondaryFire.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSecondaryFire;
                @SecondaryFire.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSecondaryFire;
                @SecondaryFire.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnSecondaryFire;
                @Reload.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReload;
                @Inventory.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInventory;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @DeployDrone.started += instance.OnDeployDrone;
                @DeployDrone.performed += instance.OnDeployDrone;
                @DeployDrone.canceled += instance.OnDeployDrone;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @PrimaryFire.started += instance.OnPrimaryFire;
                @PrimaryFire.performed += instance.OnPrimaryFire;
                @PrimaryFire.canceled += instance.OnPrimaryFire;
                @SecondaryFire.started += instance.OnSecondaryFire;
                @SecondaryFire.performed += instance.OnSecondaryFire;
                @SecondaryFire.canceled += instance.OnSecondaryFire;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // GameControls
    private readonly InputActionMap m_GameControls;
    private IGameControlsActions m_GameControlsActionsCallbackInterface;
    private readonly InputAction m_GameControls_Pause;
    private readonly InputAction m_GameControls_Confirm;
    private readonly InputAction m_GameControls_Up;
    private readonly InputAction m_GameControls_Down;
    private readonly InputAction m_GameControls_Left;
    private readonly InputAction m_GameControls_Right;
    private readonly InputAction m_GameControls_Back;
    public struct GameControlsActions
    {
        private @PlayerInput m_Wrapper;
        public GameControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_GameControls_Pause;
        public InputAction @Confirm => m_Wrapper.m_GameControls_Confirm;
        public InputAction @Up => m_Wrapper.m_GameControls_Up;
        public InputAction @Down => m_Wrapper.m_GameControls_Down;
        public InputAction @Left => m_Wrapper.m_GameControls_Left;
        public InputAction @Right => m_Wrapper.m_GameControls_Right;
        public InputAction @Back => m_Wrapper.m_GameControls_Back;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Confirm.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnConfirm;
                @Up.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRight;
                @Back.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_GameControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);

    // DroneMovement
    private readonly InputActionMap m_DroneMovement;
    private IDroneMovementActions m_DroneMovementActionsCallbackInterface;
    private readonly InputAction m_DroneMovement_DroneMovement;
    private readonly InputAction m_DroneMovement_DroneLook;
    private readonly InputAction m_DroneMovement_Ascend;
    private readonly InputAction m_DroneMovement_Descend;
    private readonly InputAction m_DroneMovement_DroneInteract;
    private readonly InputAction m_DroneMovement_DroneExit;
    public struct DroneMovementActions
    {
        private @PlayerInput m_Wrapper;
        public DroneMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @DroneMovement => m_Wrapper.m_DroneMovement_DroneMovement;
        public InputAction @DroneLook => m_Wrapper.m_DroneMovement_DroneLook;
        public InputAction @Ascend => m_Wrapper.m_DroneMovement_Ascend;
        public InputAction @Descend => m_Wrapper.m_DroneMovement_Descend;
        public InputAction @DroneInteract => m_Wrapper.m_DroneMovement_DroneInteract;
        public InputAction @DroneExit => m_Wrapper.m_DroneMovement_DroneExit;
        public InputActionMap Get() { return m_Wrapper.m_DroneMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneMovementActions set) { return set.Get(); }
        public void SetCallbacks(IDroneMovementActions instance)
        {
            if (m_Wrapper.m_DroneMovementActionsCallbackInterface != null)
            {
                @DroneMovement.started -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneMovement;
                @DroneMovement.performed -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneMovement;
                @DroneMovement.canceled -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneMovement;
                @DroneLook.started -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneLook;
                @DroneLook.performed -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneLook;
                @DroneLook.canceled -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneLook;
                @Ascend.started -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnAscend;
                @Ascend.performed -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnAscend;
                @Ascend.canceled -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnAscend;
                @Descend.started -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDescend;
                @Descend.performed -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDescend;
                @Descend.canceled -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDescend;
                @DroneInteract.started -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneInteract;
                @DroneInteract.performed -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneInteract;
                @DroneInteract.canceled -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneInteract;
                @DroneExit.started -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneExit;
                @DroneExit.performed -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneExit;
                @DroneExit.canceled -= m_Wrapper.m_DroneMovementActionsCallbackInterface.OnDroneExit;
            }
            m_Wrapper.m_DroneMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DroneMovement.started += instance.OnDroneMovement;
                @DroneMovement.performed += instance.OnDroneMovement;
                @DroneMovement.canceled += instance.OnDroneMovement;
                @DroneLook.started += instance.OnDroneLook;
                @DroneLook.performed += instance.OnDroneLook;
                @DroneLook.canceled += instance.OnDroneLook;
                @Ascend.started += instance.OnAscend;
                @Ascend.performed += instance.OnAscend;
                @Ascend.canceled += instance.OnAscend;
                @Descend.started += instance.OnDescend;
                @Descend.performed += instance.OnDescend;
                @Descend.canceled += instance.OnDescend;
                @DroneInteract.started += instance.OnDroneInteract;
                @DroneInteract.performed += instance.OnDroneInteract;
                @DroneInteract.canceled += instance.OnDroneInteract;
                @DroneExit.started += instance.OnDroneExit;
                @DroneExit.performed += instance.OnDroneExit;
                @DroneExit.canceled += instance.OnDroneExit;
            }
        }
    }
    public DroneMovementActions @DroneMovement => new DroneMovementActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_LeftClick;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_Scroll;
    public struct UIActions
    {
        private @PlayerInput m_Wrapper;
        public UIActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @LeftClick => m_Wrapper.m_UI_LeftClick;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @Scroll => m_Wrapper.m_UI_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @LeftClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftClick;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @Scroll.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnDeployDrone(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPrimaryFire(InputAction.CallbackContext context);
        void OnSecondaryFire(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
    public interface IGameControlsActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
    public interface IDroneMovementActions
    {
        void OnDroneMovement(InputAction.CallbackContext context);
        void OnDroneLook(InputAction.CallbackContext context);
        void OnAscend(InputAction.CallbackContext context);
        void OnDescend(InputAction.CallbackContext context);
        void OnDroneInteract(InputAction.CallbackContext context);
        void OnDroneExit(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
}
