using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

    private Vector2 movement;
    public float speed = 10;

    private void Update()
    {
        transform.Translate(-Vector3.left * Time.deltaTime * speed * movement.x);
        transform.Translate(Vector3.up * Time.deltaTime * speed * movement.y);
    }

    public void Move(InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
        Debug.Log("move! " + movement);
    }
}
