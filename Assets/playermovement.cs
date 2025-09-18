using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public class playermovement : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(0,rb.linearVelocity.y,10);
        
        
        if (Input.GetKeyDown(KeyCode.Space)){
            Physics.gravity=-(Physics.gravity);

        
        }
    }
}
