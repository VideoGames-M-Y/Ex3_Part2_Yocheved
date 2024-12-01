using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D; 
    [SerializeField] private InputAction moveUp = new InputAction(type: InputActionType.Button);
    [SerializeField] private float jumpForce = 5f;

    private void OnEnable(){
        moveUp.Enable();
    }

    private void OnDisable(){
        moveUp.Disable();
    }

    void Update(){
        if (moveUp.WasPressedThisFrame())
        {
            myRigidbody2D.linearVelocity = new Vector2(myRigidbody2D.linearVelocity.x, jumpForce);
        }
    }
}
