using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScrollDetector : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;

    private void OnEnable()
    {
        _playerInput.actions["ScrollWheel"].performed += ScrollInputOnperformed;
    }

    private void ScrollInputOnperformed(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValueAsObject();
        Debug.Log($"scroll value is {value}");
    }
}
