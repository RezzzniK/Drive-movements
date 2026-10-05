
using UnityEngine;
using UnityEngine.InputSystem;
 
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 [] cameraOffset={new   Vector3(0   ,7.33f,-13.35f),new Vector3(13.8303413f,3.09132862f,-0.816539943f)};
    private Vector3 [] cameraRotate ={new Vector3(15f,0f,0f)     ,new Vector3(1f,-90f,0f)};
    private int viewOption = 0;
    public InputAction cameraView;

    private void OnEnable()
    {
        cameraView.Enable();
    }

    private void OnDisable()
    {
        cameraView.Disable();
    }

    private void Update()
    {
        if (cameraView.WasPressedThisFrame()){
            if (viewOption==1)viewOption =0;
            else if (viewOption==0)viewOption=1;
           
            transform.rotation=Quaternion.Euler(cameraRotate[viewOption]);
        }
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset[viewOption];
        
    }
}