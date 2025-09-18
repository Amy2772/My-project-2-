using UnityEngine;

public class tunnelrotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(0,0,2f);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0,0,-2f);
        }

        
    }
}
