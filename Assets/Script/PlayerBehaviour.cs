using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    private Inputs inputs;
    
    private void OnEnable()
    {
        inputs = new Inputs();
        inputs.Enabe();
        inputs.Player.move.performed += OnMovePerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        var direction = obj.ReadValue<Vector2>();
        Debug.Log(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
