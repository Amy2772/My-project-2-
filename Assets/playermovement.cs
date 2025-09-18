using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.1f);
        if (Input.GetKeyDown(KeyCode.Space)){
            Physics.gravity=-(Physics.gravity);

        
        }
    }
}
