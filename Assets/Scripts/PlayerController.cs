using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed =20f;
    public float turnSpeed = 15f;

    public InputAction MoveAction;
    private Vector2 movmentInputVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        MoveAction.Enable();
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        movmentInputVector = MoveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward*Time.deltaTime*speed      *movmentInputVector.y);
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed * movmentInputVector.x);
    }
}
