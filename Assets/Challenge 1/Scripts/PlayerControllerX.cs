using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public InputAction MoveAction;
    public GameObject proppeller;
    public float proppellerSpeed = 500f;

    // Start is called before the first frame update
    void OnEnable()
    {
        MoveAction.Enable();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = MoveAction.ReadValue<float>();

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.fixedDeltaTime*speed);
        proppeller.transform.Rotate(Vector3.forward* proppellerSpeed * Time.fixedDeltaTime);
        // tilt the plane up/down based on up/down arrow keys
        if (verticalInput!=0) {
            transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.fixedDeltaTime);
        }
        else
        {
            transform.Rotate(0,0,0);
        }
    }
}
