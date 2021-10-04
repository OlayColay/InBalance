// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Battle"",
            ""id"": ""f21211bf-828a-4dc6-9f11-9617f3f94974"",
            ""actions"": [
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""d579df67-aece-439d-b067-c81e384151a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Parry"",
                    ""type"": ""Button"",
                    ""id"": ""a211e342-4081-4a51-b8d0-3fecd6a202b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Air"",
                    ""type"": ""Button"",
                    ""id"": ""365fb72d-c356-4372-8013-a556460670e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Water"",
                    ""type"": ""Button"",
                    ""id"": ""3e618898-6735-4d18-9089-102538b85b4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Earth"",
                    ""type"": ""Button"",
                    ""id"": ""5c580270-ebe6-4785-b02c-fb83b1b4aba2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""ebceec96-1e12-4a7e-be47-7b13b6317b11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lightning"",
                    ""type"": ""Button"",
                    ""id"": ""7699a4ba-1098-4067-b098-5da8ccc36498"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Physical"",
                    ""type"": ""Button"",
                    ""id"": ""770bee78-96af-42dc-8e79-8caa5ad43137"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Directional Input"",
                    ""type"": ""Value"",
                    ""id"": ""57664200-4f5f-4631-a2af-fb8cffbbff4d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""28c93133-6e77-41ea-adbe-434f7863cf4e"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e78b9c92-6d11-444f-a5fa-4170a4fe26f0"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca19f31f-04dd-4e70-829c-3beddeac6095"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9834848f-a994-434b-a708-b380b1bdea9f"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""829d39d7-54e3-42af-b5b0-d41e44787b40"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7313e632-058d-4962-8336-768ee0a2ed34"",
                    ""path"": ""<SwitchProControllerHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9406d048-e7ab-431a-9e38-3c7b222e6f4b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c2c8dfa-1bef-45fe-bf94-4336a4ca1b6b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a720ce1-d2f3-4762-8ede-364ef2e07856"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78916c40-a54f-4595-bf36-b330abfbebe8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efb578d1-d1aa-4f57-a484-e0c364c95d22"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d872e47-7daa-4533-8082-a5ec1a958c62"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ec4d808-5fc9-492c-816d-d3e28c41badb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Earth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc60aff8-78f4-4812-b25c-f00572f10bd8"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Earth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eda57a5f-66e7-4f05-9e31-b1f5bff17641"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Earth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2ee00f4-6970-4616-9e45-d2fdff0fd79d"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e769a53-13ca-4e18-b06e-a4da43be2bf0"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3839e459-67c9-4238-9156-805aac586f30"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0045df13-f90f-4acf-b29d-82ab198baa4d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lightning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6331829-bf11-47fc-8146-281c6fda2b8e"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lightning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48a3e0cb-77f1-48bd-a418-5c00a07fa38e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lightning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""096fc188-848d-4244-85e0-91863cbe7e6a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lightning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91885f8a-99ab-4cb6-955d-0bf4244f0ddf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Physical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b8b3c0d-23ec-4d3b-b17d-d713e709a4aa"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Physical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39dee61b-c5ea-4056-8fb9-65580994033f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Physical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29a2e932-433e-4ee3-b6c7-5e01edc0c328"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Physical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""04af4b4d-0c49-4948-b312-91dfb2ace481"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""412b5e1b-fd6f-494c-91a8-ddf694d5b25e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6025f5e1-e716-4bfb-bec7-a51cd24a8f7d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a235fd7b-2449-4183-9191-e911ef61c216"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce6b7c74-eb41-4d7f-9a42-e54a0b088afc"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Overworld"",
            ""id"": ""a4e9b21d-bc6a-448f-be25-2de66461e34a"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""ac4ca789-9780-4de7-8add-f669e86094ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""188ebb83-19c2-4ac2-a33b-00265ca41435"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fd6d57ac-617e-4902-ad5e-07ff665051bf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f17bdc66-b32f-4314-81b5-358887289194"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b983276c-ad4c-46d0-8c52-3df4181cbde1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""c9223542-d142-4def-a171-26f5600298ff"",
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
                    ""id"": ""94f90401-daa7-4b41-9894-feecb25b9cc3"",
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
                    ""id"": ""b2b2dd5e-05c0-4d59-85df-6b770d1e14f2"",
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
                    ""id"": ""1c591b59-b459-4a21-afea-38c78d8c4703"",
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
                    ""id"": ""0194c013-68a5-49e5-b2c5-180b17b2c0d9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ae24b5ca-7c40-4236-a3ad-45b9f69d34b4"",
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
                    ""id"": ""d57b4217-103e-4779-8cc9-91cb664146ca"",
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
                    ""id"": ""d47056fe-3e55-4b44-8d9e-1aaa55547c6a"",
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
                    ""id"": ""5f601645-bbe2-4459-8402-92170b534243"",
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
                    ""id"": ""15b02a8f-c1b4-4cac-99f7-c84f08809bb5"",
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
            ""name"": ""UI"",
            ""id"": ""5702f3e9-98c7-4d28-9654-dfeec04c4ebc"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""179e9c2d-5113-4625-9f95-92f537ce0ea4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""3eb5eb90-90f0-4972-8274-f849a5b3707e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""987dd180-4d44-48cd-a896-ebfcce338bef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4927c145-58cb-41ee-a7c9-c8f17e56c724"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4759b963-6e53-4730-8e92-c65b9dc49ab3"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60d69e38-ddbf-4a0b-9fc3-fc3c24703f67"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a701d464-a994-47cd-839a-8188d122f3fa"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2718368b-2ddf-47cb-b49e-75fe960136f0"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff0c8a1c-31f6-46ac-ac0b-eb813dcd456d"",
                    ""path"": ""<SwitchProControllerHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe80f9db-4e4c-429b-be98-ab4e6c802eb0"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c9e2ba7-1990-4e91-9365-32d91ea7be20"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07989e0a-58f0-46d2-b3e3-68c1317c00a1"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Defend"",
            ""id"": ""51e84989-3db4-4682-83a4-f5b4bea72ae6"",
            ""actions"": [
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""74622a65-fb8c-4951-8b02-8cae36f8b337"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Parry"",
                    ""type"": ""Button"",
                    ""id"": ""03a5b631-9ac6-4ab9-a836-66f81697e582"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""091453f3-f26e-4047-aae2-55a182453e54"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ce45445-da24-4e9c-8069-9e116577aa5a"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4598bf0-5f5d-4495-bda1-828c3a1ca5b3"",
                    ""path"": ""<SwitchProControllerHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b8a207d-0d56-4e0e-b317-a3891cc4ead3"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b353697a-e982-4c03-90ff-9bf3e5ca1c71"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b63dd68-c286-4eb6-a02d-cdc1347012e0"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Battle
        m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
        m_Battle_Block = m_Battle.FindAction("Block", throwIfNotFound: true);
        m_Battle_Parry = m_Battle.FindAction("Parry", throwIfNotFound: true);
        m_Battle_Air = m_Battle.FindAction("Air", throwIfNotFound: true);
        m_Battle_Water = m_Battle.FindAction("Water", throwIfNotFound: true);
        m_Battle_Earth = m_Battle.FindAction("Earth", throwIfNotFound: true);
        m_Battle_Fire = m_Battle.FindAction("Fire", throwIfNotFound: true);
        m_Battle_Lightning = m_Battle.FindAction("Lightning", throwIfNotFound: true);
        m_Battle_Physical = m_Battle.FindAction("Physical", throwIfNotFound: true);
        m_Battle_DirectionalInput = m_Battle.FindAction("Directional Input", throwIfNotFound: true);
        // Overworld
        m_Overworld = asset.FindActionMap("Overworld", throwIfNotFound: true);
        m_Overworld_Interact = m_Overworld.FindAction("Interact", throwIfNotFound: true);
        m_Overworld_Move = m_Overworld.FindAction("Move", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Confirm = m_UI.FindAction("Confirm", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Close = m_UI.FindAction("Close", throwIfNotFound: true);
        // Defend
        m_Defend = asset.FindActionMap("Defend", throwIfNotFound: true);
        m_Defend_Block = m_Defend.FindAction("Block", throwIfNotFound: true);
        m_Defend_Parry = m_Defend.FindAction("Parry", throwIfNotFound: true);
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

    // Battle
    private readonly InputActionMap m_Battle;
    private IBattleActions m_BattleActionsCallbackInterface;
    private readonly InputAction m_Battle_Block;
    private readonly InputAction m_Battle_Parry;
    private readonly InputAction m_Battle_Air;
    private readonly InputAction m_Battle_Water;
    private readonly InputAction m_Battle_Earth;
    private readonly InputAction m_Battle_Fire;
    private readonly InputAction m_Battle_Lightning;
    private readonly InputAction m_Battle_Physical;
    private readonly InputAction m_Battle_DirectionalInput;
    public struct BattleActions
    {
        private @Controls m_Wrapper;
        public BattleActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Block => m_Wrapper.m_Battle_Block;
        public InputAction @Parry => m_Wrapper.m_Battle_Parry;
        public InputAction @Air => m_Wrapper.m_Battle_Air;
        public InputAction @Water => m_Wrapper.m_Battle_Water;
        public InputAction @Earth => m_Wrapper.m_Battle_Earth;
        public InputAction @Fire => m_Wrapper.m_Battle_Fire;
        public InputAction @Lightning => m_Wrapper.m_Battle_Lightning;
        public InputAction @Physical => m_Wrapper.m_Battle_Physical;
        public InputAction @DirectionalInput => m_Wrapper.m_Battle_DirectionalInput;
        public InputActionMap Get() { return m_Wrapper.m_Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
        public void SetCallbacks(IBattleActions instance)
        {
            if (m_Wrapper.m_BattleActionsCallbackInterface != null)
            {
                @Block.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnBlock;
                @Parry.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnParry;
                @Parry.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnParry;
                @Parry.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnParry;
                @Air.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnAir;
                @Air.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnAir;
                @Air.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnAir;
                @Water.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnWater;
                @Water.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnWater;
                @Water.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnWater;
                @Earth.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnEarth;
                @Earth.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnEarth;
                @Earth.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnEarth;
                @Fire.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnFire;
                @Lightning.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnLightning;
                @Lightning.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnLightning;
                @Lightning.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnLightning;
                @Physical.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnPhysical;
                @Physical.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnPhysical;
                @Physical.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnPhysical;
                @DirectionalInput.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnDirectionalInput;
                @DirectionalInput.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnDirectionalInput;
                @DirectionalInput.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnDirectionalInput;
            }
            m_Wrapper.m_BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Parry.started += instance.OnParry;
                @Parry.performed += instance.OnParry;
                @Parry.canceled += instance.OnParry;
                @Air.started += instance.OnAir;
                @Air.performed += instance.OnAir;
                @Air.canceled += instance.OnAir;
                @Water.started += instance.OnWater;
                @Water.performed += instance.OnWater;
                @Water.canceled += instance.OnWater;
                @Earth.started += instance.OnEarth;
                @Earth.performed += instance.OnEarth;
                @Earth.canceled += instance.OnEarth;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Lightning.started += instance.OnLightning;
                @Lightning.performed += instance.OnLightning;
                @Lightning.canceled += instance.OnLightning;
                @Physical.started += instance.OnPhysical;
                @Physical.performed += instance.OnPhysical;
                @Physical.canceled += instance.OnPhysical;
                @DirectionalInput.started += instance.OnDirectionalInput;
                @DirectionalInput.performed += instance.OnDirectionalInput;
                @DirectionalInput.canceled += instance.OnDirectionalInput;
            }
        }
    }
    public BattleActions @Battle => new BattleActions(this);

    // Overworld
    private readonly InputActionMap m_Overworld;
    private IOverworldActions m_OverworldActionsCallbackInterface;
    private readonly InputAction m_Overworld_Interact;
    private readonly InputAction m_Overworld_Move;
    public struct OverworldActions
    {
        private @Controls m_Wrapper;
        public OverworldActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Overworld_Interact;
        public InputAction @Move => m_Wrapper.m_Overworld_Move;
        public InputActionMap Get() { return m_Wrapper.m_Overworld; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OverworldActions set) { return set.Get(); }
        public void SetCallbacks(IOverworldActions instance)
        {
            if (m_Wrapper.m_OverworldActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteract;
                @Move.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_OverworldActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public OverworldActions @Overworld => new OverworldActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Confirm;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Close;
    public struct UIActions
    {
        private @Controls m_Wrapper;
        public UIActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_UI_Confirm;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Close => m_Wrapper.m_UI_Close;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_UIActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Close.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClose;
                @Close.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClose;
                @Close.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClose;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Close.started += instance.OnClose;
                @Close.performed += instance.OnClose;
                @Close.canceled += instance.OnClose;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Defend
    private readonly InputActionMap m_Defend;
    private IDefendActions m_DefendActionsCallbackInterface;
    private readonly InputAction m_Defend_Block;
    private readonly InputAction m_Defend_Parry;
    public struct DefendActions
    {
        private @Controls m_Wrapper;
        public DefendActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Block => m_Wrapper.m_Defend_Block;
        public InputAction @Parry => m_Wrapper.m_Defend_Parry;
        public InputActionMap Get() { return m_Wrapper.m_Defend; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefendActions set) { return set.Get(); }
        public void SetCallbacks(IDefendActions instance)
        {
            if (m_Wrapper.m_DefendActionsCallbackInterface != null)
            {
                @Block.started -= m_Wrapper.m_DefendActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_DefendActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_DefendActionsCallbackInterface.OnBlock;
                @Parry.started -= m_Wrapper.m_DefendActionsCallbackInterface.OnParry;
                @Parry.performed -= m_Wrapper.m_DefendActionsCallbackInterface.OnParry;
                @Parry.canceled -= m_Wrapper.m_DefendActionsCallbackInterface.OnParry;
            }
            m_Wrapper.m_DefendActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Parry.started += instance.OnParry;
                @Parry.performed += instance.OnParry;
                @Parry.canceled += instance.OnParry;
            }
        }
    }
    public DefendActions @Defend => new DefendActions(this);
    public interface IBattleActions
    {
        void OnBlock(InputAction.CallbackContext context);
        void OnParry(InputAction.CallbackContext context);
        void OnAir(InputAction.CallbackContext context);
        void OnWater(InputAction.CallbackContext context);
        void OnEarth(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnLightning(InputAction.CallbackContext context);
        void OnPhysical(InputAction.CallbackContext context);
        void OnDirectionalInput(InputAction.CallbackContext context);
    }
    public interface IOverworldActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnClose(InputAction.CallbackContext context);
    }
    public interface IDefendActions
    {
        void OnBlock(InputAction.CallbackContext context);
        void OnParry(InputAction.CallbackContext context);
    }
}
